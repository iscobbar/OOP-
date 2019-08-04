using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Araba sınıfından HondaCRV_1  adında bir nesne türettik.
            Araba HondaCRV_1 = new Araba("Honda");
            HondaCRV_1.ID = 1;
            HondaCRV_1.Model = "CRV";
            HondaCRV_1.MotorHacmi = 2000;
            HondaCRV_1.Renk = "Kırmızı";
            HondaCRV_1.UretimYili = 2019;
            HondaCRV_1.YakitTipi = "Hibrit";
            HondaCRV_1.Segment = 'K';

            Console.WriteLine(HondaCRV_1.Mensei);

            // Parametreli yapıcı metot ile 2. nesneyi oluşturduk.
            Araba BMW_M3_1 = new Araba(2, "M3", 2500, "Mavi", 2018, "Dizel", 'C', "BMW");
            Console.WriteLine(BMW_M3_1.Marka);
            Console.WriteLine(BMW_M3_1.Model);
            Console.WriteLine(BMW_M3_1.Mensei);

            Console.Read();

        }
    }
    class Araba
    {
        public int ID;
        public string Marka;
        public string Model;

        // Encapsulation: kapsülleme: dolaylı ve kontrollü eriştirme.
        private short _UretimYili;
        public short UretimYili
        {
            get { return _UretimYili; }
            set
            {
                if (DateTime.Now.Year < value)
                {
                    Console.WriteLine("İleri tarih seçilemez.");
                }
                else
                {
                    _UretimYili = value;
                }
            }
        }

        public string YakitTipi;
        public string Renk;

        // Encapsulation: kapsülleme: dolaylı ve kontrollü eriştirme.
        // Menşei sadece programın kendisi tarafından set edilsin.
        // Dışardan kullanıcı sadece get edebilsin.
        private string _Mensei;
        public string Mensei { get { return _Mensei; } }
        public char Segment;
        public short MotorHacmi;
        public double Vergi;
        public double Fiyat;

        public Araba()
        {
            //vt bağlantısı.
            Console.WriteLine("Yeni bir araba nesnesi oluşturuldu..");
            // sitedeki ilan sayısı sayacını 1 artırma işlemini yapabiliriz.
        }
        public Araba(string marka)
        {
            MenseiBelirle(marka);
            Console.WriteLine("Yeni bir araba nesnesi oluşturuldu..");
        }
        public Araba(int id, string model, short motorHacmi, string renk, short uretimYili, string yakitTipi, char segment, string marka)
        {
            this.ID = id;
            this.Model = model;
            this.MotorHacmi = motorHacmi;
            this.Renk = renk;
            this.UretimYili = uretimYili;
            this.YakitTipi = yakitTipi;
            this.Segment = segment;
            this.Marka = marka;
            MenseiBelirle(marka);
            Console.WriteLine("Yeni bir araba nesnesi oluşturuldu..");
        }
        ~Araba()
        {
            // SQL kontrolü
            // kaydedilmemişse kaydet.
            // sql bağlantısını kapat.
            Console.WriteLine("YIKICI METOT ÇALIŞTI.");
        }

        private void MenseiBelirle(string mrk)
        {
            mrk = mrk.ToLower();
            if (mrk == "honda" || mrk == "mazda" || mrk == "mitsubishi")
            {
                _Mensei = "Japonya";
            }
            else if (mrk == "bmw" || mrk == "mercedes")
            {
                _Mensei = "Almanya";
            }
            else
            {
                _Mensei = "Sivas";
            }
        }


        public void MTVHesapla()
        {
            //this.Vergi = this.MotorHacmi * 0.20;

            // Hesaplama Formülleri...
        }
        public void VergiliFİyatHesapla()
        {
            //MTVHesapla();
            //...
            //Fiyat....
        }
    }
}