public class Auto
{
    public string Marka { get; set; }
    public int Evszam { get; set; }

    public Auto(string marka, int evszam)
    {
        Marka = marka;
        Evszam = evszam;
    }

    // Segít, hogy a ListBox közvetlenül ki tudja írni az autó adatait
    public override string ToString()
    {
        return $"{Marka} - {Evszam}";
    }
}