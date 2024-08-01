using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public Uye()
        {
            OduncKitaplarim =new List<BaseKitap>();
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool UyeMi { get; set; }
        public int UyeNumarasi { get; set; }
        

        public List<BaseKitap> OduncKitaplarim { get; set; }


        public void KitapIadeEt(BaseKitap baseKitap,Kutuphane kutuphane)
        {
            if (OduncKitaplarim.Count>0 && OduncKitaplarim.Contains(baseKitap))
            {
                
                OduncKitaplarim.Remove(baseKitap);
                kutuphane.MevcutKitaplar.Add(baseKitap);
                baseKitap.durum=Durum.OduncAlınabilir;     //Kitap artık ödünç alınabilir duruma getirilir.
                
                Console.WriteLine("Kitabınız iade edildi");

            }
            else
            {
                Console.WriteLine("İade edecek kitabınız bulunmamaktadır.");
            }
        }

        public void KitapOduncAl(BaseKitap baseKitap, Uye uye,Kutuphane kutuphane)
        {
            //Sisteme dahil olmak
            //kütüphane stoğunda yeterli sayıda kitap olması


            if (kutuphane.MevcutKitaplar.Count>0 &&  baseKitap.durum==Durum.OduncAlınabilir && uye.UyeMi==true)
            {
                baseKitap.durum=Durum.OduncVerildi;
                OduncKitaplarim.Add(baseKitap);
                kutuphane.MevcutKitaplar.Remove(baseKitap);
                Console.WriteLine("Kitabı ödünç aldınız");
            }
            else
            {
                Console.WriteLine("Kitabı ödünç almanız için şartları sağlamanız gerekmektedir.");
            }
        }

    }
}
