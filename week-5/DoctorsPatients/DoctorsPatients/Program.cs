using DoctorsPatients.Classes;

var doctor = new Doctor()
{
    name = "Ayse",
    surname = "Bir",
    field = "KBB",
    age = 30
};
var doctor2 = new Doctor()
{
    name = "Fatma",
    surname = "İki",
    field = "Goz",
    age = 25
};
var doctor3 = new Doctor()
{
    name = "Melek",
    surname = "Üç",
    field = "Ortopedi",
    age = 50
};

var hasta = new Patient()
{
    name = "Reyhan",
    surname = "Bir",
    disease = "Kulak",
    age = 40
};
var hasta2 = new Patient()
{
    name = "Sultan",
    surname = "İki",
    disease = "Goz",
    age = 35
};
var hasta3 = new Patient()
{
    name = "Gunes",
    surname = "Üç",
    disease = "Ortopedi",
    age = 15
};

void displayD(Doctor d)
{
    Console.WriteLine("Doctor name, surname: " + d.name + " " + d.surname);
    Console.WriteLine("Doctor age: " + d.age);
    Console.WriteLine("Doctor field: " + d.field);
    Console.WriteLine("--------------------------------");
}
void displayP(Patient p)
{
    Console.WriteLine("Patient name, surname: " + p.name + " " + p.surname);
    Console.WriteLine("Patient age: " + p.age);
    Console.WriteLine("Patient disease: " + p.disease);
    Console.WriteLine("+++++++++++++++++++++++++++++++++");
}
Console.WriteLine("Doctors....");
displayD(doctor);
displayD(doctor2);
displayD(doctor3);
Console.WriteLine("**********************************");
Console.WriteLine("Patients....");
displayP(hasta);
displayP(hasta2);
displayP(hasta3);