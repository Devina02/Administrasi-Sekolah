using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_1 //Nama file
{
    public class Program;
    {
        public static void Main(string[] args)// Method untuk menjalankan program
        {
            //String berfungsi untuk mendeklarasikan variabel untuk menyimpan kalimat 
            string NamaSiswa, NIS, JenisKelamin, AlamatSiswa, Kelas, NamaWaliKelas;
            string AdministrasiSekolah;
            string data;
            string namafile;

            try //Blok kode ini dieksekusi terlebih dahulu
            {
                Console.Write("Tekan Enter Untuk Memasukan Data Siswa "); //Fungsi Console.Write() digunakan untuk menampilkan informasi ke layar.
                namafile = Convert.ToString(Console.ReadLine()); //Convert.ToStrinng memiliki fungsi untuk mengconvert data ke string kemudian data tersebut akan di dispay
                StreamWriter sw = new StreamWriter("D:\\" + namafile + ".txt");


                Console.Write("Nama Siswa : "); //Fungsi Console.Write() digunakan untuk menampilkan informasi ke layar.
                NamaSiswa = Console.ReadLine(); //Fungsi Console.ReadLine() digunakan untuk meminta nilai atau menginputkan data yang dimasukan oleh pengguna

                Console.Write("NIS : "); //Fungsi Console.Write() digunakan untuk menampilkan informasi ke layar.
                NIS = Console.ReadLine(); //Fungsi Console.ReadLine() digunakan untuk meminta nilai atau menginputkan data yang dimasukan oleh pengguna

                Console.Write("Jenis Kelamin : "); //Fungsi Console.Write() digunakan untuk menampilkan informasi ke layar.
                JenisKelamin = Console.ReadLine(); //Fungsi Console.ReadLine() digunakan untuk meminta nilai atau menginputkan data yang dimasukan oleh pengguna

                Console.Write("Alamat Siswa : "); //Fungsi Console.Write() digunakan untuk menampilkan informasi ke layar.
                AlamatSiswa = Console.ReadLine(); //Fungsi Console.ReadLine() digunakan untuk meminta nilai atau menginputkan data yang dimasukan oleh pengguna

                Console.Write("Kelas : "); //Fungsi Console.Write() digunakan untuk menampilkan informasi ke layar.
                Kelas = Console.ReadLine(); //Fungsi Console.ReadLine() digunakan untuk meminta nilai atau menginputkan data yang dimasukan oleh pengguna

                Console.Write("Nama Wali kelas :"); //Fungsi Console.Write() digunakan untuk menampilkan informasi ke layar.
                NamaWaliKelas = Console.ReadLine(); //Fungsi Console.ReadLine() digunakan untuk meminta nilai atau menginputkan data yang dimasukan oleh pengguna


                //Console.WriteLine berfungsi untuk mendisplay kata yang dimasukan dalam tanda ""
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Berikut hasil data yang dimasukan ");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Nama Siswa = {NamaSiswa}");
                Console.WriteLine($"NIS = {NIS}");
                Console.WriteLine($"Nama Siswa = {JenisKelamin}");
                Console.WriteLine($"Nama Siswa = {AlamatSiswa}");
                Console.WriteLine($"Kelas = {Kelas}");
                Console.WriteLine($"Nama Wali Kelas = {NamaWaliKelas}");
                Console.WriteLine();
                

               
                sw.Close();// Digunakan untuk menyimpan data pada folder 
            }

            //Tujuan dari blok catch adalah untuk memunculkan pesan error yang errornya tidak terlihat dimana
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}