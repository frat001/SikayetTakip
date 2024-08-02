using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DtoLayer.SikayetDTO
{
    public class ResultSikayetDTO
    {
        public int ID { get; set; }
        public int SikayetNo { get; set; }
        public string BolgeSefligi { get; set; }
        public string ParkIsmi { get; set; }
        public string BakimImage { get; set; }
        public string SikayetImage { get; set; }
        public int BeyazMasaNo { get; set; }
        public string Aciklama { get; set; }

        
    }
}
