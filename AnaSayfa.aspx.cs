﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TahsilatUyg_.Classes;

namespace TahsilatUyg_
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        VeriTabani vt = new VeriTabani();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += " " + vt.AnaSayfa()[0];
            Label2.Text += " " + vt.AnaSayfa()[1];

            Dictionary<string, int> chartBilgiler = vt.AnaSayfaChart();
            string[] urunAd = chartBilgiler.Keys.ToArray();
            int[] miktar = chartBilgiler.Values.ToArray();

            for (int i = 0; i < urunAd.Length; i++)
            {
                string birlesikVeri = urunAd[i] + Environment.NewLine + miktar[i].ToString();
                urunAd[i] = birlesikVeri;
            }

            Chart1.Series["Series1"].Points.DataBindXY(urunAd , miktar);

        }

    }
}