using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_2
{
    public class Computer
    {
        public Processor inprocessor { get; set; }
        public string type { get; set; }
        public string videocard { get; set; }
        public int sizeozy { get; set; }
        public string typeozy { get; set; }
        public int sizedisk { get; set; }
        public string typedisk { get; set; }
        public DateTime data { get; set; }


        public Computer() {
            inprocessor = new Processor();

        }
    }
}
