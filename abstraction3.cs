using System;
using baru.abstraction;
using baru.Interfaces;
namespace baru
{
    public class Program
    {
        static void Main(string[] args)
        {

            IDeskrip desk = new Baca();
            Bio bi = new Bio();

            string nama="Muhammad";
            string jabatan ="sekretaris desa";
            string telp="089654825055";
            string alamat="Cawas,Klaten";

            desk.View();
            bi.ViewBio(nama,jabatan,telp,alamat);
            bi.ViewData(nama,jabatan,telp,alamat);
        }
    }
}