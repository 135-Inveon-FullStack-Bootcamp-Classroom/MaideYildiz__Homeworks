using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public class GeneralSurgeon:IDoctor
    {
        public string doctorName { get; set; }
        public void AmeliyatEt()
        {
            Console.WriteLine(doctorName+" (Genel cerrah) ameliyat ediyor...");
        }

        public void IlacYaz()
        {
            Console.WriteLine(doctorName+ " (Genel cerrah) ilac yazıyor...");
        }

        public void MuayeneEt()
        {
            Console.WriteLine(doctorName+ " (Genel cerrah) muayene ediyor...");
        }

        public void NobetTut()
        {
            Console.WriteLine(doctorName+ " (Genel cerrah) nobet tutuyor...");
        }

        public void RaporYaz()
        {
            Console.WriteLine(doctorName+ " (Genel cerrah) rapor yazıyor...");
        }

        public void TahlilIncele()
        {
            Console.WriteLine(doctorName+ " (Genel cerrah) tahlil incele...");
        }
    }
}
