 using System;
namespace baru.Interfaces
{
    public interface IDeskrip
    {
        void View();
    }

    class Baca : IDeskrip
    {
        public void View()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Data Piket Kantor");
            Console.WriteLine("Kecamatan Cawas");
            Console.WriteLine("================================");
        }
    }
}