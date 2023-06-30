using System;

public enum Płeć
{
    Kobieta,
    Mężczyzna
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Płeć Płeć;
}

public class Program
{
    public static void WypelnijStudenta(ref Student student)
    {
        Console.Write("Podaj nazwisko studenta: ");
        student.Nazwisko = Console.ReadLine();

        Console.Write("Podaj numer albumu: ");
        student.NrAlbumu = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj ocenę: ");
        double ocena = Convert.ToDouble(Console.ReadLine());
        student.Ocena = Math.Max(2.0, Math.Min(5.0, ocena));

        Console.WriteLine("Podaj płeć (0 - Kobieta, 1 - Mężczyzna): ");
        int plec = Convert.ToInt32(Console.ReadLine());
        student.Płeć = (Płeć)plec;
    }

    public static double ObliczSrednia(Student[] grupa)
    {
        if (grupa.Length == 0)
            return 0;

        double sumaOcen = 0;

        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }

        return sumaOcen / grupa.Length;
    }

    public static void WyswietlStudenta(Student student)
    {
        Console.WriteLine($"Nazwisko: {student.Nazwisko}, Numer albumu: {student.NrAlbumu}, Ocena: {student.Ocena}, Płeć: {student.Płeć}");
    }

    public static void Main()
    {
        Student[] grupa = new Student[5];

        for (int i = 0; i < grupa.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            WypelnijStudenta(ref grupa[i]);
            Console.WriteLine();
        }

        Console.WriteLine("Wszyscy studenci w grupie:");

        foreach (var student in grupa)
        {
            WyswietlStudenta(student);
        }

        double srednia = ObliczSrednia(grupa);
        Console.WriteLine($"Średnia ocen: {srednia}");
    }
}
