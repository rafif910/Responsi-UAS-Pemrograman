using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer        
        static List<Customer> daftarCustomer = new List<Customer>();

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
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilihan Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection            
            int i = 0;
            i++;
            Customer[] customer = new Customer[10];
            customer[i] = new Customer();

            Console.WriteLine("Tambah Data Customer");
            Console.WriteLine();
            Console.Write("Kode Customer: ");
            customer[i].Kode = Console.ReadLine();
            Console.Write("Nama Customer: ");
            customer[i].Nama = Console.ReadLine();
            Console.Write("Total Piutang: ");
            customer[i].Piutang = int.Parse(Console.ReadLine());

            daftarCustomer.Add(customer[i]);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection
            Console.WriteLine("Hapus Data Customer");
            Console.WriteLine();
            Console.Write("Kode Customer: ");
            string kd = Console.ReadLine();

            //Mengecek Kode
            if (daftarCustomer.Any(n => n.Kode == kd))
            {
                daftarCustomer.RemoveAll(x => x.Kode == kd);
                Console.WriteLine("Data Customer berhasil dihapus\n\n");
            }
            else
            {
                Console.WriteLine("Kode Customer tidak ditemukan\n\n");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection
            Console.WriteLine("Menampilkan Data Customer");
            Console.WriteLine();
            int nourut = 0;

            foreach (Customer customer in daftarCustomer)
            {
                nourut++;
                Console.WriteLine("{0}. {1}, {2}, {3}", nourut, customer.Kode, customer.Nama, customer.Piutang);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}