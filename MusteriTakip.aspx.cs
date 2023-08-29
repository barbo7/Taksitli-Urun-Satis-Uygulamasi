using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;

namespace TahsilatUyg_
{
    public partial class MusteriTakip : System.Web.UI.Page
    {
        Classes.VeriTabani Vt = new Classes.VeriTabani();

        string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            RequiredFieldValidator1.ControlToValidate = TextBox2.ID;
            RequiredFieldValidator1.InitialValue = "";
            RequiredFieldValidator2.ControlToValidate = TextBox3.ID;
            RequiredFieldValidator2.InitialValue = "";

            RegularExpressionValidator1.ControlToValidate = TextBox2.ID;
            RegularExpressionValidator1.ValidationExpression = @"^\d+$";
            RegularExpressionValidator2.ControlToValidate = TextBox3.ID;
            RegularExpressionValidator2.ValidationExpression = @"^\d+(\.\d+)?$";

            RangeValidator1.ControlToValidate = TextBox3.ID;
            if (!IsPostBack) {
                string tabloBaslangic = Vt.MusteriTakipBaslangic();
                myLiteralControl.Text = tabloBaslangic;
            }
            else
            {
                string script = @"<script type='text/javascript'>
                            function scrollToBottom() {
                                window.scrollTo(0, document.body.scrollHeight);
                            }   
                          </script>";

                ClientScript.RegisterStartupScript(this.GetType(), "scrollScript", script);
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Vt.AdVeyaIdGoreListeleMT(TextBox1.Text, GridView1);
            string tabloVeri =Vt.AdVeyaIdGoreTable(TextBox1.Text);
            myLiteralControl.Text = tabloVeri;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            decimal toplam, odenen;
            con.Open();
            SqlCommand odeme = new SqlCommand("SELECT toplam_fiyat,odenen FROM TBL_TAKSITLER WHERE musteri_id = @musteri_id", con);
            odeme.Parameters.AddWithValue("@musteri_id", int.Parse(TextBox2.Text));

            SqlDataReader reader = odeme.ExecuteReader();
            if (reader.Read())
            {
                toplam = reader.GetDecimal(0);
                odenen = reader.GetDecimal(1);
                odenen += decimal.Parse(TextBox3.Text);
                if(odenen <=toplam)
                {
                    reader.Close();
                    SqlCommand cmd = new SqlCommand("Update TBL_TAKSITLER SET odenen = @odenen WHERE musteri_id = @musteri_id AND taksit_id= @taksit", con);
                    cmd.Parameters.AddWithValue("@odenen", odenen);
                    cmd.Parameters.AddWithValue("@musteri_id", int.Parse(TextBox2.Text));
                    cmd.Parameters.AddWithValue("@taksit", odenen);

                    cmd.ExecuteNonQuery();
                    successAlert.Style["display"] = "block";
                    myLiteralControl.Text = "";
                    Literal2.Text = "";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = ""; 

                }
                else
                {
                    unsuccessAlert.Style["display"] = "block";
                }
            }

            con.Close();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            StringBuilder htmlBuilderA = new StringBuilder();

            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT taksit_id, urun_ad FROM URUN_TAKSIT WHERE musteri_id=" + TextBox2.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "urun_ad";
            DropDownList1.DataValueField = "taksit_id";
            DropDownList1.DataBind();


            SqlCommand cmd = new SqlCommand("SELECT [AD SOYAD],[Ürün Adı],[Alış Tarihi],[Kalan Tutar],[Aylık Taksit Tutarı]FROM TARIH_BILGI WHERE [musteri_id]= @musteri_id", con);
            cmd.Parameters.AddWithValue("@musteri_id", int.Parse(TextBox2.Text));

            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                htmlBuilderA.Append("<tr>");
                htmlBuilderA.AppendFormat("<td>{0}</td>", reader["AD SOYAD"].ToString());
                htmlBuilderA.AppendFormat("<td>{0}</td>", reader["Ürün Adı"].ToString());
                htmlBuilderA.AppendFormat("<td>{0}</td>", reader["Alış Tarihi"].ToString());
                htmlBuilderA.AppendFormat("<td>{0}</td>", reader["Kalan Tutar"].ToString());
                htmlBuilderA.AppendFormat("<td>{0}</td>", reader["Aylık Taksit Tutarı"].ToString());

                htmlBuilderA.Append("</tr>");
            }

            Literal2.Text = htmlBuilderA.ToString();
            reader.Close();
            con.Close();
            FiyatGetir();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            
        }
        void FiyatGetir()
        {
          
            if(DropDownList1.SelectedItem.Text != "") { 
                string selectedValue = DropDownList1.SelectedItem.Text; // DataValueField'a bakın
                SqlConnection con = new SqlConnection(connectionStringGenel);

                if (int.TryParse(TextBox2.Text, out int musteriId))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT [Aylık Taksit Tutarı] FROM TARIH_BILGI WHERE [Ürün Adı]= @urunadi and musteri_id= @id", con);
                    cmd.Parameters.AddWithValue("@urunadi", selectedValue);
                    cmd.Parameters.AddWithValue("@id", musteriId);

                    object deger = cmd.ExecuteScalar();

                    if (deger != null && deger != DBNull.Value)
                    {
                        decimal maxAlinmakIstenen = (decimal)deger;
                    RangeValidator1.MaximumValue = maxAlinmakIstenen.ToString();
                    TextBox3.Text = maxAlinmakIstenen.ToString();
                    }
                }
            }
        }

    }
}