using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssionMakale
{

    public class Recursion
    {
        public Recursion()
        {
            PopulateSirasizTaslar();
        }

        public class Tas
        {
            public string Numara { get; set; }
            public string UstNumara { get; set; }
        }


        List<Tas> _sirasizTaslar = new List<Tas>();

        public List<Tas> SirasizTaslar
        {
            get { return _sirasizTaslar; }
        }


        public void UstNumarasi_X_OlanlariYerlestir(string X)
        {
            List<Tas> UstNumarasi_X_OlanTaslar = _sirasizTaslar.Where(t => t.UstNumara.Equals(X)).ToList();
            foreach (Tas t in UstNumarasi_X_OlanTaslar)
            {
                TasYaz(t);
            }
        }

        public void TasYaz(Tas t)
        {
            Console.WriteLine("<Tas:{0} />", t.Numara);
            Console.WriteLine("<AltTaslar>");
            UstNumarasi_X_OlanlariYerlestir(t.Numara);
            Console.WriteLine("</AltTaslar>");
        }


        private void PopulateSirasizTaslar()
        {
            _sirasizTaslar.Add(new Tas() { Numara = "1", UstNumara = "" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,1", UstNumara = "1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,2", UstNumara = "1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,3", UstNumara = "1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,4", UstNumara = "1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,1,1", UstNumara = "1,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,1,2", UstNumara = "1,1,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,1,1,1", UstNumara = "1,1,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,1,1,2", UstNumara = "1,1,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "2", UstNumara = "" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,1", UstNumara = "2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,2", UstNumara = "2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,3", UstNumara = "2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,4", UstNumara = "2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,1,1", UstNumara = "2,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,1,2", UstNumara = "2,1,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,1,1,1", UstNumara = "2,1,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,1,1,2", UstNumara = "2,1,1" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,2,1", UstNumara = "1,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,2,2", UstNumara = "1,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,2,3", UstNumara = "1,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "1,2,4", UstNumara = "1,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,2,1", UstNumara = "2,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,2,2", UstNumara = "2,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,2,3", UstNumara = "2,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,2,4", UstNumara = "2,2" });
            _sirasizTaslar.Add(new Tas() { Numara = "2,2,5", UstNumara = "2,2" });
        }




    }
}
