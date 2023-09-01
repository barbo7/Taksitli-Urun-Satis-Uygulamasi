using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TahsilatUyg_.Classes;

namespace TahsilatUyg_
{
    public partial class Tahsilat : System.Web.UI.Page
    {
        string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;
        VeriTabani vt = new VeriTabani();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RangeValidator1.ControlToValidate = TextBox3.ID;
                RangeValidator1.Type = ValidationDataType.Integer;
                RangeValidator1.MinimumValue = "1";
                RangeValidator1.MaximumValue = "36";
                RequiredFieldValidator1.ControlToValidate = TextBox3.ID;
                RequiredFieldValidator1.InitialValue = "";
                RegularExpressionValidator1.ControlToValidate = TextBox2.ID;
                RegularExpressionValidator1.ValidationExpression = @"^\d+(\.\d+)?$";
                RequiredFieldValidator2.ControlToValidate = TextBox2.ID;
                RequiredFieldValidator2.InitialValue = "";

                vt.MusteriAd(DropDownList2);
                vt.UrunAdi(DropDownList1);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(connectionStringGenel);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT fiyat FROM TBL_URUNLER WHERE urun_id=" + DropDownList1.SelectedValue, con);
                TextBox2.Text = cmd.ExecuteScalar().ToString(); // Null değer olma ihtimaline karşı ?. kullanımı
                con.Close();
            }
        //textBox2 = Ürün fiyatı, textBox3 = taksit miktarı, textBox4 = peşin alınan miktar, textBox5 = Aylık ödenecek Taksit tutarı
        double aylikTutar = default;
        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if(TextBox3.Text !="")
            {
                aylikTutar = double.Parse(TextBox2.Text) / double.Parse(TextBox3.Text);
                TextBox4.Text = aylikTutar + "";
                TextBox5.Text = aylikTutar + "";
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(TextBox4.Text) == aylikTutar)
                TextBox5.Text = aylikTutar.ToString();
            else
                TextBox5.Text = ((double.Parse(TextBox2.Text) - double.Parse(TextBox4.Text))/double.Parse(TextBox3.Text)).ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            if (DropDownList2.SelectedValue != "1" && DropDownList1.SelectedValue != "1")
            {
                string verigonder = String.Format("INSERT INTO TBL_TAKSITLER(musteri_id, urun_id, toplam_fiyat, kac_taksit, odenen, kalan, musteri_not) VALUES({0}, {1}, {2}, {3}, {4}, {5}, '{6}')",
         DropDownList2.SelectedValue, DropDownList1.SelectedValue, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text);

                SqlCommand cmd = new SqlCommand(verigonder, con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("UPDATE TBL_TAKSIT_TARIH SET taksit_tutar=" + TextBox5.Text + " WHERE taksit_id in(SELECT taksit_id FROM TBL_TAKSITLER t WHERE t.musteri_id=" + DropDownList2.SelectedValue + " and t.urun_id=" + DropDownList1.SelectedValue + ") and eklenme_tarihi='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", con);
                cmd2.ExecuteNonQuery();
                con.Close();
                successAlert.Style["display"] = "block";


                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
            else
                unsuccessAlert.Style["display"] = "block";

        }
    }
}