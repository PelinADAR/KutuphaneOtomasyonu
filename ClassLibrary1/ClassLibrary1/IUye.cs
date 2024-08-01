using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public interface IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }

        public bool UyeMi { get; set; }

        List<BaseKitap> OduncKitaplarim { get; set; }

        void KitapOduncAl(BaseKitap baseKitap,Uye uye,Kutuphane kutuphane);

        void KitapIadeEt(BaseKitap baseKitap, Kutuphane kutuphane);


    }
}
