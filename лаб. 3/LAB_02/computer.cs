using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace LAB_02
{
    [Serializable]
    public class computer
    {
        [XmlElement]
        public processor inprocessor { get; set; }
        [Processorr]
        public string processorr {  get; set; }
        [Required(ErrorMessage = "Введите данные!")]
        public string type { get; set; }
        public string videocard { get; set; }
        public int sizeozy { get; set; }
        public string typeozy { get; set; }
        public int sizedisk { get; set; }
        public string typedisk { get; set; }
        public DateTime data { get; set; }

        public computer(processor Inprocessor, string Processorr, string Type, string Videocard, int Sizeozy, string Typeozy, int Sizedisk, string Typedisk, DateTime Data )
        {
            inprocessor= Inprocessor;
            processorr = Processorr;
            type= Type;
            videocard= Videocard;
            sizeozy= Sizeozy;
            typeozy= Typeozy;
            sizedisk= Sizedisk;
            typedisk= Typedisk;
            data= Data;
        }
        public computer() {
        
        }


        public computer(processor Inprocessor,int Sizeozy)
        {
            inprocessor = Inprocessor;
            sizeozy = Sizeozy;
        }


        public override string ToString()
        {
            return $"{inprocessor.proizvoditel},\t {inprocessor.model},\t {inprocessor.chastota},\t {sizeozy}";
        }
    }
}

