using System;
namespace baru.abstraction
{

    class Program
    {
    }
    abstract class Data
    {
        public abstract void ViewBio(string nama, string jabatan,string telp, string alamat);
        public void ViewData(string nama,string jabatan,string telp,string alamat)
        {
            Console.WriteLine("Data Lengkap");
            Console.WriteLine("Nama          : {0}",nama);
            Console.WriteLine("Jabatan       : {0}",jabatan);
            Console.WriteLine("Telp          : {0}",telp);
            Console.WriteLine("Alamat        : {0}",alamat);
            Console.WriteLine("=========================================");
        }
    }
    class Bio : Data
    {
        public override void ViewBio(string nama, string jenis, string telp, string alamat)
        {
            Console.WriteLine("Data Singkat");
            Console.WriteLine("Nama          : {0}",nama);
            Console.WriteLine("Jabatan       : {0}",jabatan);
            Console.WriteLine("No Telp       : {0}",telp);
            Console.WriteLine("Alamat        : {0}",alamat);
            Console.WriteLine();
        }
    }
}