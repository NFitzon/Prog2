public class Personenkraftwagen : Kraftfahrzeug
{
    public string GetInfo()
    {
        Personenkraftwagen dummy = new Personenkraftwagen();
        string info = " Kennzeichen = " + Kennzeichen +
                     " Kilometerstand = " + Kilometerstand +
                     " CO2-Abdruck = " + dummy.BerechneCarbonFootprint();
        return info;
    }
}