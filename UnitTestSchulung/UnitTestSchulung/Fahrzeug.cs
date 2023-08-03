namespace UnitTestSchulung;

public class Fahrzeug
{
    public string Modell { get; set; }
    public int Kapazität { get; set; }
    public string Fahrer { get; set; }
    public bool IstVerfügbar { get; set; }
    public Koordinaten Standort { get; set; }
}