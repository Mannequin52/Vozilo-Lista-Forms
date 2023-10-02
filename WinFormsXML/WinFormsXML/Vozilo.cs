using System;
using System.Windows.Forms;

namespace WinFormsXML
{
    public class Vozilo
    {
        public string model;
        public int god, brkt;
        public Vozilo(string model, int god, int brkt)
        {
            this.Model = model;
            this.God = god;
            this.Brkt = brkt;
        }

        #region getteri i setteri
        public string Model { get => model; set => model = value; }
        public int God { get => god; set => god = value; }
        public int Brkt { get => brkt; set => brkt = (char)value; }
        #endregion

        
        public override string ToString()
        {
            string ispis = null;

            if (brkt == 2)
            {
                ispis = this.Model + "\n" + this.God + "\n" + this.Brkt + "\nMotor";
            }
            if (brkt == 4)
            {
                ispis = this.Model + "\n" + this.God + "\n" + this.Brkt + "\nAutomobil";
            }
            if(brkt > 4)
            {
                ispis = this.Model + "\n" + this.God + "\n" + this.Brkt + "\nKamion";
            }
                return ispis;
        }
    }
}