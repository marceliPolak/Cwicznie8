public struct Student
{
    public string Imię;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
    public int RokStudiów;
    public int NrPESEL;
}

public struct Przedmiot
{
    public string Nazwa;
    public string Kod; //string gdyż kod możę zawierać też litery
    public string PoziomZaaawansowania; //Podstawa, Rozszerzenie
    public string Wykładowca;
}

public struct NauczycielAkademicki
{
    public string Imię;
    public string Nazwisko;
    public string StopieńNaukowy;
    public string Specjalizacja;
}
