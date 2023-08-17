using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TahsilatUyg_
{
    public partial class MusteriTakip : System.Web.UI.Page
    {
        Classes.VeriTabani Vt = new Classes.VeriTabani();

        string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            RequiredFieldValidator1.ControlToValidate = TextBox2.ClientID;
            RequiredFieldValidator1.InitialValue = "";
            RequiredFieldValidator2.ControlToValidate = TextBox3.ClientID;
            RequiredFieldValidator2.InitialValue = "";

            RegularExpressionValidator1.ControlToValidate = TextBox2.ClientID;
            RegularExpressionValidator1.ValidationExpression = @"^\d+$";
            RegularExpressionValidator2.ControlToValidate = TextBox3.ClientID;
            RegularExpressionValidator2.ValidationExpression = @"^\d+(\.\d+)?$";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Vt.AdVeyaIdGoreListeleMT(TextBox1.Text, GridView1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            decimal toplam, odenen;
            con.Open();
            SqlCommand odeme = new SqlCommand("SELECT toplam_fiyat,odenen FROM TBL_TAKSITLER WHERE musteri_id =" + TextBox2.Text, con);
            SqlDataReader reader = odeme.ExecuteReader();
            if (reader.Read())
            {
                toplam = reader.GetDecimal(0);
                odenen = reader.GetDecimal(1);
                odenen += decimal.Parse(TextBox3.Text);
                if(odenen <=toplam)
                {
                    reader.Close();
                    SqlCommand cmd = new SqlCommand("Update TBL_TAKSITLER SET odenen =" + odenen + " WHERE musteri_id =" + TextBox2.Text + " AND taksit_id=" + DropDownList1.SelectedValue, con);
                    cmd.ExecuteNonQuery();
                    Response.Write("İşlem başarıyla tamamlandı!");
                    GridView1.DataBind();
                    GridView2.DataBind();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";

                }
                else
                {
                    Response.Write("Ödeme Miktarı Ürün Ücretinden fazla!");
                }
            }

            con.Close();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT taksit_id, urun_ad FROM URUN_TAKSIT WHERE musteri_id=" + TextBox2.Text, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "urun_ad";
            DropDownList1.DataValueField = "taksit_id";
            DropDownList1.DataBind();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT [AD SOYAD],[Ürün Adı],[Alış Tarihi],[Kalan Tutar],[Aylık Taksit Tutarı] FROM TARIH_BILGI WHERE [musteri_id]=" + TextBox2.Text, con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            GridView2.DataSource = dt2;
            GridView2.DataBind();
            con.Close();
        }
    }
}