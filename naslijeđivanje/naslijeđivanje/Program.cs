using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslijeđivanje
{
    public class Osoba
    {
        private string m_ime;
        private string m_prezime;


        public string ime
        {
            get { return m_ime; }
            set { m_ime = value; }
        }

        public string prezime
        {
            get { return m_prezime; }
            set { m_prezime = value; }
        }

        public void ispis()
        {
            Console.WriteLine(" ime: {0} \n prezime: {1},", m_ime, m_prezime );
        }

        public Osoba(string m_ime, string m_prezime)

        {
            ime = m_ime;    
            prezime = m_prezime;
        }

    }

    public class Ucenik : Osoba
    {
        private string m_godine;
        private string m_razred;


        public string godine
        {
            get { return m_godine; }
            set { m_godine = value; }
        }

        public string razred
        {
            get { return m_razred; }
            set { m_razred = value; }
        }

        

        public Ucenik(string a_ime, string a_prezime, string a_godine, string a_razred) : base(a_ime, a_prezime)
        {
            
            m_godine = a_godine;
            m_razred = a_razred;
        }

        public new void ispis()
        {
            Console.WriteLine(" ime: {0} \n prezime: {1} \n godine: {2} \n razred {3}, ", ime, prezime, m_godine, m_razred);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("mate", "Josic");
            Ucenik ucenik = new Ucenik("Marko", "Marulić", "20", "3.D");

         

            osoba.ispis();

            ucenik.ispis();

            Console.ReadKey();

        }
            
    
    }
    
}
