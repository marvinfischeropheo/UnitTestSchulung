namespace UnitTestSchulung;

public class Verplaner
{
    private const double MaxEntfernung = 100.0; 
    private const double MinEntfernung = 10.0;  

    public bool PrüfeAuftrag(Fahrzeug fahrzeug, Auftrag auftrag)
    {
        if (!fahrzeug.IstVerfügbar)
        {
            return false;
        }

        if (auftrag.Größe > fahrzeug.Kapazität)
        {
            return false;
        }

        var entfernung = BerechneEntfernung(fahrzeug.Standort, auftrag.Zielort);
        if (entfernung is > MaxEntfernung or < MinEntfernung)
        {
            return false;
        }

        if (auftrag.Liefertermin < DateTime.Now)
        {
            return false;
        }

        return true;
    }

    private static double BerechneEntfernung(Koordinaten start, Koordinaten ziel)
    {
        return Math.Sqrt(Math.Pow(start.Breitengrad - ziel.Breitengrad, 2) + Math.Pow(start.Längengrad - ziel.Längengrad, 2));
    }
}