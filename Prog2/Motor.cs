public enum Treibstoff
{
    Diesel,
    Benzin
}
public class Motor
{
    private double Verbrauch;
    private Treibstoff Treibstoff;
    public Motor(double verbrauch, Treibstoff treibstoff){}
    public double GetVerbrauch(){return 0;}
    public double GetTreibstoffFaktor(){
        if(Treibstoff == Treibstoff.Diesel){
            return 470;
        }
        if(Treibstoff == Treibstoff.Benzin){
            return 780;
        }
        return 0;
        }

}