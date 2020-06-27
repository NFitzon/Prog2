public abstract class Kraftfahrzeug
{
    protected string Kennzeichen;
    protected double Kilometerstand;

    protected Motor Motor;

    public void Fahren(double x){

    }
    public void SetMotot(Motor m){

    }

    public void SetKennzeichen(string n){}
    public string GetInfo(){return "";}

    protected double BerechneCarbonFootprint()
    {
        double coFootprint = (Kilometerstand / 100) *
                             Motor.GetVerbrauch() *
                             Motor.GetTreibstoffFaktor();
        return coFootprint;
    }
}