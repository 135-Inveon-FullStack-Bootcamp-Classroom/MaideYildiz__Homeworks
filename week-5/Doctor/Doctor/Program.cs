using System;

namespace Doctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dermatologist dermatologist =new Dermatologist();
            dermatologist.doctorName = "Doktor1";
            GeneralSurgeon generalSurgeon = new GeneralSurgeon();
            generalSurgeon.doctorName = "Doktor3";
            IDoctor doctor = new EyeDoctor();
            doctor.doctorName = "Doktor4";
            EyeDoctor eyeDoctor = new EyeDoctor();
            eyeDoctor.doctorName = "Doktor2";

            Console.WriteLine("********* Dermotologist **********");
            dermatologist.MuayeneEt();
            dermatologist.IlacYaz();
            dermatologist.NobetTut();
            dermatologist.TahlilIncele();
            dermatologist.RaporYaz();
            Console.WriteLine("");
            Console.WriteLine("********* Genel Cerrah **********");
            generalSurgeon.MuayeneEt();
            generalSurgeon.IlacYaz();
            generalSurgeon.NobetTut();
            generalSurgeon.TahlilIncele();
            generalSurgeon.RaporYaz();
            generalSurgeon.AmeliyatEt();
            Console.WriteLine("");
            Console.WriteLine("********* Goz Doktoru (IDoktordan) **********");
            doctor.MuayeneEt();
            doctor.IlacYaz();
            doctor.NobetTut();
            doctor.TahlilIncele();
            doctor.RaporYaz();
        }
    }
}
