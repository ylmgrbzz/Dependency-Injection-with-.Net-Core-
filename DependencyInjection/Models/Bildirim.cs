using System.Diagnostics;

namespace DependencyInjection.Models
{
    public class Bildirim
    {
        public void Yap(IBildirim bildirim)
        {
            IBildirim bildirim = new EPostaBildirim();
            ePostaBildirim.Gonder();

        }
    }


    public interface IBildirim
    {
        void Gonder();
    }


    public class EPostaBildirim : IBildirim
    {
        public void Gonder()
        {
            //Console.WriteLine("Eposta gönderildi");
            Debug.WriteLine("Eposta gönderildi");
            //return "ylm";
        }
    }


    public class SmsBildirim : IBildirim
    {
        public void Gonder()
        {
            //Console.WriteLine("Sms gönderildi");
            Debug.WriteLine("Sms gönderildi");
        }
    }

}
