using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMahasiswa
{
    class Program
    {
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi Sebelum UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilAwal();

                Console.Write("Nomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch(nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3:
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilAwal()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");

            Console.WriteLine();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Mahasiswa mahasiswa = new Mahasiswa();

            Console.WriteLine("Tambah Data Mahasiswa\n");

            Console.Write("NIM: ");
            mahasiswa.nim = (Console.ReadLine());

            Console.Write("Nama: ");
            mahasiswa.nama = (Console.ReadLine());

            Console.Write("Jenis Kelamin [L/P]: ");
            mahasiswa.jeniskelamin = (Console.ReadLine());

            Console.Write("Nilai Huruf: ");
            mahasiswa.nilaihuruf = (Console.ReadLine());

            daftarMahasiswa.Add(mahasiswa);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Data Mahasiswa\n");

            Console.WriteLine("===============================================");
            Console.WriteLine("NIM, NAMA, JENIS KELAMIN, NILAI HURUF, BOBOT");
            Console.WriteLine("===============================================");

            for (int i = 0; i < daftarMahasiswa.Count; i++)
            {
                if(daftarMahasiswa[i].jeniskelamin == "L")
                {
                    if(daftarMahasiswa[i].nilaihuruf == "A")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Laki-laki, {3}, 4", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else if(daftarMahasiswa[i].nilaihuruf == "B")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Laki-laki, {3}, 3", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else if (daftarMahasiswa[i].nilaihuruf == "C")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Laki-laki, {3}, 2", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else if (daftarMahasiswa[i].nilaihuruf == "D")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Laki-laki, {3}, 1", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (daftarMahasiswa[i].nilaihuruf == "A")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Perempuan, {3}, 4", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else if (daftarMahasiswa[i].nilaihuruf == "B")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Perempuan, {3}, 3", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else if (daftarMahasiswa[i].nilaihuruf == "C")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Perempuan, {3}, 2", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else if (daftarMahasiswa[i].nilaihuruf == "D")
                    {
                        Console.WriteLine("{0}. {1}, {2}, Perempuan, {3}, 1", i + 1, daftarMahasiswa[i].nim, daftarMahasiswa[i].nama, daftarMahasiswa[i].nilaihuruf);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
