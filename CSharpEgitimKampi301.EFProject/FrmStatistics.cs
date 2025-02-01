using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        EgitimKampiEfTravelDbEntities db= new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            
            lblLocationCount.Text=db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text=db.Location.Count().ToString();
            lblAveregaCapasity.Text = db.Location.Average(x => x.Capacity).ToString();
            lblAverageLocation.Text=db.Location.Average(x=>x.Price)?.ToString("0.00") + "Tl";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text=db.Location.Where(x=>x.LocationId==lastCountryId).Select(y=> y.Country).FirstOrDefault();
            lblCappadociaLocation.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAverage.Text=db.Location.Where(x=>x.Country=="Turkey").Average(y=>y.Capacity).ToString();
            
            var romeGuideId=db.Location.Where(x=>x.City== "Roma turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text=db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName+" "+y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            var guideIdByEyupYildirim = db.Guide.Where(x => x.GuideName == "Eyup" && x.GuideSurname == "Yildirim").Select(y => y.GuideId).FirstOrDefault();
            lblEyupYildirim.Text = db.Location.Where(x => x.GuideId == guideIdByEyupYildirim).Count().ToString();


        }
    }
}
