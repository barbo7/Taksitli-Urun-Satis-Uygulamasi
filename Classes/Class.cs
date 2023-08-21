using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.DynamicData;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Data.Common;
using System.Text;

namespace TahsilatUyg_.Classes
{
    public class VeriTabani
    {
        string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;

        public string UrunB()
        {
            StringBuilder htmlBuilder = new StringBuilder();
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT urun_ad as 'Ürün Adı',fiyat as 'Fiyat' FROM[TBL_URUNLER]", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                htmlBuilder.Append("<tr>");
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Ürün Adı"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Fiyat"].ToString());
                htmlBuilder.Append("</tr>");
            }
            dr.Close();
            con.Close();

            return htmlBuilder.ToString();
        }

        public void MusteriAd(DropDownList ddl)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [musteri_id], [ad_soyad] FROM [TBL_MUSTERI]", con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            ddl.DataSource = dataTable;
            ddl.DataTextField = "ad_soyad";
            ddl.DataValueField = "musteri_id";
            ddl.DataBind();

            reader.Close();
            con.Close();
        }

        public void UrunAdi(DropDownList ddl)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT[urun_ad], [urun_id] FROM[TBL_URUNLER]", con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            ddl.DataSource = dataTable;
            ddl.DataTextField = "urun_ad";
            ddl.DataValueField = "urun_id";
            ddl.DataBind();

            reader.Close();
            con.Close();
        }
        //public void AdVeyaIdGoreListeleMT(string veri, GridView gridV)
        //{
        //    if (string.IsNullOrWhiteSpace(veri))
        //        return;


        //    SqlConnection con = new SqlConnection(connectionStringGenel);
        //    con.Open();
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MUSTERI_TAKSIT_BILGILERI WHERE[AD SOYAD] like '" + veri + "%' OR [Müşteri Id] like '" + veri + "%'", con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    con.Close();

        //    gridV.DataSource = dt;
        //    gridV.DataBind();
        //}
        public string AdVeyaIdGoreTable(string veri)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM MUSTERI_TAKSIT_BILGILERI WHERE[AD SOYAD] like '" + veri + "%' OR [Müşteri Id] like '" + veri + "%'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                htmlBuilder.Append("<tr>");
                htmlBuilder.AppendFormat("<td>{0}</td>", reader["Müşteri Id"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", reader["Ad Soyad"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", reader["Toplam Borç"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", reader["Toplam Ödenen"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", reader["Toplam Kalan"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", reader["MaksimumTaksit Miktarı"].ToString());
                htmlBuilder.Append("</tr>");
            }

            reader.Close();
            con.Close();

            return htmlBuilder.ToString();
        }

        public string AdVeyaIdGoreListeleOT2(string veri)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT [ad_soyad] 'Ad Soyad',[urun_ad] 'Satılan Ürün Adı',[odenen_miktar] 'Ödenen Tutar',[tarih] 'Tarih' FROM SATIS_TUTANAGI WHERE musteri_id like '" + veri + "%' or ad_soyad like '" + veri + "%'", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                htmlBuilder.Append("<tr>");
                htmlBuilder.AppendFormat("<td>{0}</td>", dr2["Ad Soyad"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr2["Satılan Ürün Adı"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr2["Ödenen Tutar"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr2["Tarih"].ToString());
                htmlBuilder.Append("</tr>");
            }
            dr2.Close();
            con.Close();
            return htmlBuilder.ToString();
        }
        public string AdVeyaIdGoreListeleOT1(string veri)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT m.ad_soyad 'Ad Soyad',u.urun_ad 'Ürün Adı',t.kac_taksit 'Taksit Miktarı',t.toplam_fiyat 'Toplam Fiyat',t.odenen 'Toplam Ödenen',tt.eklenme_tarihi 'Ödeme Başlangıç Tarihi' FROM TBL_TAKSITLER t INNER JOIN TBL_MUSTERI m ON m.musteri_id=t.musteri_id INNER JOIN TBL_TAKSIT_TARIH tt ON tt.taksit_id=t.taksit_id INNER JOIN URUN_TAKSIT u on u.taksit_id=t.taksit_id WHERE t.musteri_id in(SELECT musteri_id FROM TBL_MUSTERI WHERE ad_soyad like '" + veri + "%' OR musteri_id like'" + veri + "')", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                htmlBuilder.Append("<tr>");
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Ad Soyad"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Ürün Adı"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Taksit Miktarı"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Toplam Fiyat"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Toplam Ödenen"].ToString());
                htmlBuilder.AppendFormat("<td>{0}</td>", dr["Ödeme Başlangıç Tarihi"].ToString());
                htmlBuilder.Append("</tr>");

            }
            dr.Close();
            return htmlBuilder.ToString();
        }
    }
}