using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LAB_02
{
    [Serializable]
    public class processor
    {
        [RegularExpression(@"^[a-zA-Zа-яА-ЯёЁ\s-]+$", ErrorMessage = "Некорректные данные!")]
        public string proizvoditel { get; set; }
        public string seria { get; set; }

        [RegularExpression(@"^[a-zA-Zа-яА-ЯёЁ\s-]+$", ErrorMessage = "Некорректные данные!")]
        public string model { get; set; }
        public int kolvoyader { get; set; }
        public int chastota { get; set; }
        public int maxchastota { get; set; }
        public string razrarhitect { get; set; }
        public string razmkesha { get; set; }


        public processor(string Proizvoditel, string Seria, string Model, int Kolvoyader, int Chastota, int Maxchastota, string Razrarhitect, string Razmkesha)
        {
            proizvoditel = Proizvoditel;
            seria = Seria;
            model = Model;
            kolvoyader = Kolvoyader;
            chastota = Chastota;
            maxchastota = Maxchastota;
            razrarhitect = Razrarhitect;
            razmkesha = Razmkesha;
        }

        public processor() { }

        public processor(string Proizvoditel, string Model, int Chastota)
        {
            proizvoditel = Proizvoditel;
            model = Model;
            chastota = Chastota;
        }
    }
}
