using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public interface IDoctor
    {
        public string doctorName { get; set; }
        public void IlacYaz()
        {
            Console.WriteLine(doctorName+" Doktor ilac yazıyor...");
        }

        public void MuayeneEt()
        {
            Console.WriteLine(doctorName + " Doktor muayene ediyor...");
        }

        public void NobetTut()
        {
            Console.WriteLine(doctorName + " Doktor nobet tutuyor...");
        }

        public void RaporYaz()
        {
            Console.WriteLine(doctorName + " Doktor rapor yazıyor...");
        }

        public void TahlilIncele()
        {
            Console.WriteLine(doctorName + " Doktor tahlil incele...");
        }
    }
}
