namespace UnitTestSchulung;

public class Auftrag
{
    public string Beschreibung { get; set; }
    public int Größe { get; set; }
    public Koordinaten Zielort { get; set; }
    public DateTime Liefertermin { get; set; }
    public List<Auftragsposition> Auftragspositionen { get; set; }
}