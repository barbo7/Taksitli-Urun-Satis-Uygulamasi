using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using TahsilatUyg_.Classes;

namespace TahsilatUyg_
{
    public partial class KefilBilgi : System.Web.UI.Page
    {
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
                RegularExpressionValidator2.ControlToValidate = TextBox3.ID;
                RegularExpressionValidator2.ValidationExpression = @"^\d{11}$";
                RegularExpressionValidator2.Text = "11 Haneli TC giriniz.";

                RequiredFieldValidator3.ControlToValidate = TextBox3.ID;
                RequiredFieldValidator3.InitialValue = "";
                RequiredFieldValidator3.Text = "Cep telefonu alanı Boş bırakılamaz.";
                RegularExpressionValidator3.ControlToValidate = TextBox2.ID;
                RegularExpressionValidator3.ValidationExpression = @"^\d{11}$";
                RegularExpressionValidator3.Text = "11 Haneli Telefon numarasını giriniz.";
            }

            VeriTabani vt = new VeriTabani();
            vt.MusteriAd(DropDownList1);
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into TBL_KEFIL(musteri_id,kefil_ad_soyad,telno,tc) VALUES(" + DropDownList1.SelectedValue + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("İşlem başarıyla tamamlandı!");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }

    }
}