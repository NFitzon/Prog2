public class Lastkraftwagen : Kraftfahrzeug
{
    private double Ladegewicht;

    public void Beladen(double d){}
    public void Entladen(){}
    public string GetInfo(){
        Lastkraftwagen dummy = new Lastkraftwagen();
        string info = " Kennzeichen = " + Kennzeichen +
                      " Kilometerstand = "  + Kilometerstand +
                      " CO2-Abdruck = " + dummy.BerechneCarbonFootprint();
                      
                return info;}
}