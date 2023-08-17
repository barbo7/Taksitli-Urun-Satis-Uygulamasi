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

namespace TahsilatUyg_.Classes
{
    public class VeriTabani
    {
        string connectionStringGenel = System.Configuration.ConfigurationManager.ConnectionStrings["connectionStringGenel"].ConnectionString;

        public void UrunB(GridView gv)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT urun_ad as 'Ürün Adı',fiyat as 'Fiyat' FROM[TBL_URUNLER]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gv.DataSource = dt;
            gv.DataBind();
            con.Close();
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
        public void AdVeyaIdGoreListeleMT(string veri, GridView gridV) {
            if (string.IsNullOrWhiteSpace(veri))
                return;


            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MUSTERI_TAKSIT_BILGILERI WHERE[AD SOYAD] like '" + veri + "%' OR [Müşteri Id] like '" + veri + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            gridV.DataSource = dt;
            gridV.DataBind();
        }
        public void AdVeyaIdGoreListeleOT(string veri, GridView gridV, GridView gridV2)
        {
            SqlConnection con = new SqlConnection(connectionStringGenel);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT m.ad_soyad 'Ad Soyad',u.urun_ad 'Ürün Adı',t.kac_taksit 'Taksit Miktarı',t.toplam_fiyat 'Toplam Fiyat',t.odenen 'Toplam Ödenen',tt.eklenme_tarihi 'Ödeme Başlangıç Tarihi' FROM TBL_TAKSITLER t INNER JOIN TBL_MUSTERI m ON m.musteri_id=t.musteri_id INNER JOIN TBL_TAKSIT_TARIH tt ON tt.taksit_id=t.taksit_id INNER JOIN URUN_TAKSIT u on u.taksit_id=t.taksit_id WHERE t.musteri_id in(SELECT musteri_id FROM TBL_MUSTERI WHERE ad_soyad like '" + veri + "%' OR musteri_id like'" + veri + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT [ad_soyad] 'Ad Soyad',[urun_ad] 'Satılan Ürün Adı',[odenen_miktar] 'Ödenen Tutar',[tarih] 'Tarih' FROM SATIS_TUTANAGI WHERE musteri_id like '"+veri+"%' or ad_soyad like '"+veri+"%'", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();

            gridV.DataSource = dt;
            gridV.DataBind();
            gridV2.DataSource = dt2;
            gridV2.DataBind();
        }
    }
}