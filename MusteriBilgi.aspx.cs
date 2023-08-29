using System;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Web.UI;
using TahsilatUyg_.Classes;

namespace TahsilatUyg_
{
    public partial class MusteriBilgi : System.Web.UI.Page
    {
        string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                RequiredFieldValidator1.ControlToValidate = TextBox1.ID;
                RequiredFieldValidator1.InitialValue = "";
                RequiredFieldValidator1.Text = "Ad-Soyad alanı Boş bırakılamaz.";
                RegularExpressionValidator1.ControlToValidate = TextBox1.ID;
                RegularExpressionValidator1.ValidationExpression = @"^[\wçğıöşüÇĞİÖŞÜ]+( [\wçğıöşüÇĞİÖŞÜ]+){1,2}$";
                RegularExpressionValidator1.Text = "Lütfen sadece harf kullanın.";

                RequiredFieldValidator2.ControlToValidate = TextBox2.ID;
                RequiredFieldValidator2.InitialValue = "";
                RequiredFieldValidator2.Text = "Tc No alanı Boş bırakılamaz.";
                RegularExpressionValidator2.ControlToValidate = TextBox2.ID;
                RegularExpressionValidator2.ValidationExpression = @"^\d{11}$";
                RegularExpressionValidator2.Text = "11 Haneli TC giriniz.";

                RequiredFieldValidator3.ControlToValidate = TextBox3.ID;
                RequiredFieldValidator3.InitialValue = "";
                RequiredFieldValidator3.Text = "Cep telefonu alanı Boş bırakılamaz.";
                RegularExpressionValidator3.ControlToValidate = TextBox3.ID;
                RegularExpressionValidator3.ValidationExpression = @"^\d{11}$";
                RegularExpressionValidator3.Text = "11 Haneli Telefon numarasını giriniz.";

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            SqlConnection con = new SqlConnection(connectionStringGenel);
            bool engelleyimMi = vt.MusteriTekrarEngel(TextBox1.Text, TextBox2.Text);

            try
            {
                con.Open();

                if (!engelleyimMi)
                {
                    SqlCommand cmd = new SqlCommand("Insert Into TBL_MUSTERI(ad_soyad,tc,telno,vergi_kimlik_no,adres) VALUES(@ad,@tc,@tel,@veriK,@adres)", con);
                    cmd.Parameters.AddWithValue("@ad", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@tc", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@tel", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@veriK", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@adres", TextBox5.Text);

                    cmd.ExecuteNonQuery();
                    successAlert.Style["display"] = "block";
                }
                else
                    unsuccessAlert.Style["display"] = "block";


            }
            catch (Exception ex) {
                unsuccessAlert.Style["display"] = "block";
                unsuccessAlert.InnerText = "Bir hata oluştu: " + ex.Message;
            }
            finally
            {
                con.Close();
            }
           
           
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if(TextBox4.Text.Length>10)
            TextBox4.Text =TextBox4.Text.Substring(0, 10); 
        }

    }
}
