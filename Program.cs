using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilkanMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        private static void TampilkanMahasiswa()
        {
            throw new NotImplementedException();
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampil Mahasiswa");
            Console.WriteLine("4. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Tambah Data Mahasiswa\n");
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.Write("NIM Mahasiswa : ");
            mahasiswa.NIM_Mahasiswa = Console.ReadLine();
            Console.Write("Nama Mahasiswa : ");
            mahasiswa.Nama_Mahasiswa = Console.ReadLine();
            Console.Write("Jenis Kelamin  : ");
            mahasiswa.Jenis_Kelamin = Console.ReadLine();
            Console.Write("Nilai IPK  : ");
            mahasiswa.Nilai_IPK = Convert.ToDouble(Console.ReadLine());
            daftarMahasiswa.Add(mahasiswa);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM Mahasiswa : ");
            string kd = Console.ReadLine();
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                no++;
                if (mahasiswa.NIM_Mahasiswa == NIM)
                {
                    continue;
                }
                hapus = no;
            }
            if (hapus != -1)
            {
                daftarMahasiswa.RemoveAt(hapus);
                Console.WriteLine("\nData Mahasiswa Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nNIM Mahasiswa tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }

    static void TampilkanMahasiswa()
    {
        Console.Clear();
        int noUrut = 0;
        Console.WriteLine("Data Mahasiswa\n");
        foreach (Mahasiswa mahasiswa in daftarMahasiswa)
        {
            noUrut++;
            string jenis;
            if (mahasiswa.Jenis_Kelamin == "L")
            {
                jenis = "Laki-laki";
            }
            else if (mahasiswa.Jenis_Kelamin == "P")
            {
                jenis = "Perempuan";
            }
            else
            {
                jenis = "Jenis Kelamin tidak terdefinisi";
            }
            Console.WriteLine(noUrut + "." + mahasiswa.NIM_Mahasiswa + "." + mahasiswa.Nama_Mahasiswa + "." + mahasiswa.Jenis_Kelamin + "." + mahasiswa.Nilai_IPK);
            if (noUrut < 1)
            {
                Console.WriteLine("Data Mahasiswa Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
