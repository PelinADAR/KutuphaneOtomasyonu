using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
       
        public Kutuphane()
        {
            MevcutKitaplar = new List<BaseKitap>();
            Uyeler = new List<IUye>();
            OduncVerilenKitaplar=new List<BaseKitap>();
        }


        public List<BaseKitap> MevcutKitaplar { get; set; }
        public List<BaseKitap> OduncVerilenKitaplar { get; set; }
        public List<IUye> Uyeler { get; set; }

       
        public void Uyelikoluştur(Uye uye)
        {
           
            Uyeler.Add(uye);
            
        }

        public void OduncVer(Kutuphane kutuphane,BaseKitap baseKitap)
        {
            if (MevcutKitaplar.Count>0 && baseKitap.durum==Durum.OduncAlınabilir) 
            {
                Console.WriteLine(baseKitap+" ödünç verilebilir.");
            }

        }

        public void İadeEt()
        {


        }

        public void MevcutDurumGuncelle(BaseKitap baseKitap, Uye uye)
        {
            if (uye.UyeMi)
            {
               
                //Uyeler.Add(uye);
                //Console.WriteLine("Yeni üye eklendi");
                Console.WriteLine("Toplam üye sayısı: " + Uyeler.Count);
                Console.WriteLine("Mevcut uyeler:");
                foreach (var uyee in Uyeler)
                {
                    Console.WriteLine("-" + uyee.Ad+" "+uyee.Soyad);
                }

            }

            else
            {
                Console.WriteLine("Kutuphanemizde böyle bir üye bulunmamaktadır.");
            }

            if (baseKitap.durum==Durum.OduncVerildi)
            {
                MevcutKitaplar.Remove(baseKitap);
                OduncVerilenKitaplar.Add(baseKitap);

                Console.WriteLine("Ödünç verilen kitaplar:");
                foreach (var Odunckitap in OduncVerilenKitaplar)
                {
                    Console.WriteLine("- " + Odunckitap.Ad);
                }
                Console.WriteLine("Mevcut kitaplar:");
                foreach (var kitap in MevcutKitaplar)
                {
                    Console.WriteLine("- " + kitap.Ad); 
                }
            }
            
        }
    }
}
