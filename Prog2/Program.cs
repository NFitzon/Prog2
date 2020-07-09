using System;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personenkraftwagen pkw = new Personenkraftwagen();
            Personenkraftwagen pkw2 = new Personenkraftwagen();
            pkw2 = pkw.PkwErzeugen();
        }


        public Personenkraftwagen PkwErzeugen()
        {
            Personenkraftwagen pkw = new Personenkraftwagen();
            pkw.SetKennzeichen("B-ABC12");
            Motor pkwMotor = new Motor(10 / 100, Treibstoff.Benzin);
            pkw.SetMotor(pkwMotor);
            return pkw;

        }
    }
}
