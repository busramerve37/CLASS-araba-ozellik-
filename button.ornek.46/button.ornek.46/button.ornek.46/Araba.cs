using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace button.ornek._46
{
    internal class Araba
    {
        string marka;
        string model;
        int vites;
        int hiz = 0;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Vites { get => vites; set => vites = value; }
        public int Hiz { get => hiz; set => hiz = value; }

        public Araba(string marka, string model)
        {
            this.marka = marka;
            this.model = model;
        }
        public void Hizlan()
        {
            Hiz += 5;
        }
        public void Yavasla()
        {
            Hiz -= 5;
        }
        public string KornaCal()
        {
            return "Biiiiipppppp";
        }
        public string BilgiYazdir()
        {
            return "Marka;" + marka + "\n Model:" + model + "\n Vites:" + vites + "\n Hız:" + hiz;
        }

        
        
    }
}
