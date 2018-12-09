using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using QuanLyBaoHiem.Models;
using QuanLyBaoHiem.ModelDoanhThu;

namespace QuanLyBaoHiem
{
    public partial class Formtest2 : DevExpress.XtraEditors.XtraForm
    {
        QLBHContext db = new QLBHContext();
        decimal[] doanhthutungthang = new decimal[12] { 0,0,0,0,0,0,0,0,0,0,0,0};
        List<DoanhThu> listdoanhthu = new List<DoanhThu>();
        public Formtest2()
        {
            InitializeComponent();
            laydulieu();
            
            xulyradoanhthuhangthang();
            showketquatest();
            ve();
        }
        public void ve()
        {
            ChartControl pointChart = new ChartControl();

            // Create a point series.
            Series series1 = new Series("Doanh thu", ViewType.Bar);

            // Set the numerical argument scale type for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Auto;

            // Add points to it.
            for(int i=0;i<12;i++)
            {
                series1.Points.Add(new SeriesPoint("Tháng "+(i+1)+"", doanhthutungthang[i]));

            }
            /*series1.Points.Add(new SeriesPoint("Tháng 1", 10));
            series1.Points.Add(new SeriesPoint("Tháng 2", 22));
            series1.Points.Add(new SeriesPoint("Tháng 3", 14));
            series1.Points.Add(new SeriesPoint("Tháng 4", 27));
            series1.Points.Add(new SeriesPoint("Tháng 5", 15));
            series1.Points.Add(new SeriesPoint("Tháng 6", 28));
            series1.Points.Add(new SeriesPoint("Tháng 7", 15));
            series1.Points.Add(new SeriesPoint("Tháng 8", 33));
            series1.Points.Add(new SeriesPoint("Tháng 9", 33));
            series1.Points.Add(new SeriesPoint("Tháng 10", 33));
            series1.Points.Add(new SeriesPoint("Tháng 11", 33));
            series1.Points.Add(new SeriesPoint("Tháng 12", 33));*/


            // Add the series to the chart.
            pointChart.Series.Add(series1);

            // Access the view-type-specific options of the series.
            BarSeriesView myView1 = (BarSeriesView)series1.View;
            //myView1.PointMarkerOptions.Kind = MarkerKind.Star;
            //myView1.PointMarkerOptions.StarPointCount = 5;
            //myView1.PointMarkerOptions.Size = 20;

            // Access the type-specific options of the diagram.
            ((XYDiagram)pointChart.Diagram).EnableAxisXZooming = true;

            // Hide the legend (if necessary).
            pointChart.Legend.Visible = true;
            

            // Add a title to the chart (if necessary).
            pointChart.Titles.Add(new ChartTitle());
            pointChart.Titles[0].Text = "Doanh thu từng tháng";


            // Add the chart to the form.
            pointChart.Dock = DockStyle.Fill;
            this.Controls.Add(pointChart);
        }
        public void laydulieu()
        {
            
            var dulieu = (from p in db.HopDongs
                          join b in db.GoiHopDongs
                          on p.MaGoiHD equals b.MaGoiHD
                          select new
                          {
                              MaHD = p.MaHD,
                              MucPhi = b.MucPhi,
                              NgayHieuLuc = p.NgayHieuLuc
                          }
                        ).ToList();
            foreach(var a in dulieu)
            {
                DoanhThu b = new DoanhThu();
                b.MaHD = a.MaHD;
                b.MucPhi = a.MucPhi;
                b.NgayHieuLuc = a.NgayHieuLuc;
                listdoanhthu.Add(b);
            }
        }
        public void xulyradoanhthuhangthang()
        {
            for(int i=0;i<12;i++)
            {
                foreach(var a in listdoanhthu)
                {
                    DateTime temp =(DateTime) a.NgayHieuLuc;
                    if(temp.Month==i+1)
                    {
                        doanhthutungthang[i] = (decimal)(doanhthutungthang[i] + a.MucPhi);
                        //doanhthutungthang[i] = 0;
                    }
                    
                }
            }
        }
        public void showketquatest()
        {
            foreach(var a in doanhthutungthang)
            {
                System.Diagnostics.Debug.WriteLine(a);
            }
        }
    }
}