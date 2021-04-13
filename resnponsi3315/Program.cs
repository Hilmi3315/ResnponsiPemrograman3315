using System;

namespace ResponsiPemrograman3315
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan(304111233, "Paijo", 3500000);
            Karyawan kar2 = new Karyawan(304111234, "Jono", 2000000);

            Karyawan.Show(kar1, kar2);
            Karyawan.NaikGaji(kar1, kar2);
            Karyawan.Show(kar1, kar2);
        }
    }
}
