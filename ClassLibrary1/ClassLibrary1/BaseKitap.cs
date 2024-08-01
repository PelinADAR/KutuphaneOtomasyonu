using CSProjeDemo1;

namespace ClassLibrary1
{
    public abstract class BaseKitap 
    {
        public string Ad {  get; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public DateTime YayinYili { get; set; }
        public Durum durum { get; set; }
    }
}
