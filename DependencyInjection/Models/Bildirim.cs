namespace DependencyInjection.Models
{
    public class Bildirim
    {
        public void Yap()
        {
            EPostaBildirim ePostaBildirim = new EPostaBildirim();
            ePostaBildirim.Gonder();

        }
    }

    public class EPostaBildirim
    {
        public void Gonder()
        {
            System.Console.WriteLine("Eposta gönderildi");
        }
    }
}
