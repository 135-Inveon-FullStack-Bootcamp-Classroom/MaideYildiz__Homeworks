using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public class Dermatologist : IDoctor
    {
        public string doctorName { get; set; }

        public void IlacYaz()
        {
            Console.WriteLine(doctorName+" (Dermatolog) ilac yazıyor...");
        }

        public void MuayeneEt()
        {
            Console.WriteLine(doctorName+ " (Dermatolog) muayene ediyor...");
        }

        public void NobetTut()
        {
            Console.WriteLine(doctorName+ " (Dermatolog) nobet tutuyor...");
        }

        public void RaporYaz()
        {
            Console.WriteLine(doctorName+ " (Dermatolog) rapor yazıyor...");
        }

        public void TahlilIncele()
        {
            Console.WriteLine(doctorName+ " (Dermatolog) tahlil incele...");
        }
    }
}
