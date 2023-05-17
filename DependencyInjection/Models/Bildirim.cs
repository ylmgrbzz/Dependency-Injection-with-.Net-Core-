using System.Diagnostics;

namespace DependencyInjection.Models
{

    public class Creator
    {

        private Creator()
        {
        }

        public static Bildirim CreateBildirimInstance()
        {
            return new Bildirim(new EPostaBildirim());
        }

    }

    public class Bildirim
    {
        private IBildirim _bildirim;

        public Bildirim(IBildirim bildirim)
        {
            _bildirim = bildirim;
        }

        public void Yap()
        {
            _bildirim.Gonder();

            //Console.WriteLine("Bildirim gönderildi");
            Debug.WriteLine("Bildirim gönderildi");
        }
        public void Yap2()
        {
            _bildirim.Gonder();

            //Console.WriteLine("Bildirim gönderildi");
            Debug.WriteLine("Bildirim2 gönderildi");
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
