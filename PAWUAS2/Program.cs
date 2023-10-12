using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace PAWUAS2
{
    public class Kedai
    {
        //membuat variabel yang akan digunakan
        public decimal blackburger, spaghetti, nasigoreng, cappucino, icetea, airmineral, Hblackburger, Hspaghetti, Hnasigoreng, Hcappucino, Hicetea, Hairmineral, namapelanggan, namakasir, jam, tanggal;
        //membuat format list
        public List<decimal> price = new List<decimal>();
        int choose;

        string data;



        public void BlackBurger()
        {
            try
            {
                Console.Write("Black Burger = ");
                blackburger = Decimal.Parse(Console.ReadLine());
                Hblackburger = blackburger * 25000;
                price.Add(Hblackburger);
                Console.WriteLine("\n Total Harga Black Burger {0} \n", Hblackburger);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void Spaghetti()
        {
            try
            {
                Console.Write("Spaghetti = ");
                spaghetti = Decimal.Parse(Console.ReadLine());
                Hspaghetti = spaghetti * 70000;
                price.Add(Hspaghetti);
                Console.WriteLine("\n Total Harga Spaghetti {0}\n", Hspaghetti);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void NasiGoreng()
        {
            try
            {
                Console.Write("Nasi Goreng = ");
                nasigoreng = Decimal.Parse(Console.ReadLine());
                Hnasigoreng = nasigoreng * 40000;
                price.Add(Hnasigoreng);
                Console.WriteLine("\n Total Harga Nasi Goreng {0}  \n", Hnasigoreng);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void Cappucino()
        {
            try
            {
                Console.Write("Cappucino = ");
                cappucino = Decimal.Parse(Console.ReadLine());
                Hcappucino = cappucino * 15000;
                price.Add(Hcappucino);
                Console.WriteLine("\n Total Harga Cappucino {0} \n", Hcappucino);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void IceTea()
        {
            try
            {
                Console.Write("Ice Tea = ");
                icetea = Decimal.Parse(Console.ReadLine());
                Hicetea = icetea * 17000;
                price.Add(Hicetea);
                Console.WriteLine("\n Total Harga Ice Tea {0} \n", Hicetea);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void AirMineral()
        {
            try
            {
                Console.Write("Air Mineral = ");
                airmineral = Decimal.Parse(Console.ReadLine());
                Hairmineral = airmineral * 20000;
                price.Add(Hairmineral);
                Console.WriteLine("\n Total Harga Air Mineral {0} \n", Hairmineral);
            }
            catch (FormatException)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("\nHanya diisi dengan format angka !\n");
                Console.WriteLine("==========================================");
            }
        }
        public void NamaPelanggan()
        {
            try
            {
                Console.Write("Masukkan Nama Pelanggan = ");
                namapelanggan = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Isikan data dengan benar");
            }
        }
        public void Tanggal()
        {
            try
            {
                Console.Write("Masukkan Tanggal Transaksi =");
                tanggal = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Isikan data dengan benar");
            }
        }
        public void Jam()
        {
            try
            {
                Console.Write("Masukkan Jam Transaksi =");
                jam = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Isikan data dengan benar");
            }
        }
        public void NamaKasir()
        {
            try
            {
                Console.Write("Masukkan Nama Kasir =");
                namakasir = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Isikan data dengan benar");
            }
        }
        public void KedaiViwi()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("1. Black Burger (Rp.25.000)" +
                        "\n2. Spaghetti (Rp.30.000)" +
                        "\n3. Nasi Goreng (Rp.18.000)" +
                        "\n4. Cappucino (Rp.20.000)" +
                        "\n5. Ice Tea (Rp.10.000)" +
                        "\n6. Air Mineral (Rp.5.000)" +
                        "\n7. Finish/Exit");
                    Console.Write("Choose : ");
                    choose = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choose)
                    {
                        case 1:
                            BlackBurger();
                            break;
                        case 2:
                            Spaghetti();
                            break;
                        case 3:
                            NasiGoreng();
                            break;
                        case 4:
                            Cappucino();
                            break;
                        case 5:
                            IceTea();
                            break;
                        case 6:
                            AirMineral();
                            break;
                        case 7:
                            if (!price.Any())
                            {
                                return;
                            }
                            else
                            {
                                Console.Clear();
                                data = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", price.Sum(x => x));
                                Console.WriteLine("Jumlah Pemesanan :" +
                                    "\n {0} Black Burger," +
                                    "\n {1} Spaghetti," +
                                    "\n {2} Nasi Goreng," +
                                    "\n {3} Cappucino" +
                                    "\n {4} Ice Tea" +
                                    "\n {5} Air Mineral" +
                                    "\n\n------------------------" +
                                    "\nTotal : {6}", blackburger, spaghetti, nasigoreng, cappucino, icetea, airmineral, data);

                                Console.Write("\nCash : Rp. ");
                                int tunai = int.Parse(Console.ReadLine());
                                int kembalian = (int)(tunai - price.Sum(x => x));
                                Console.WriteLine("\nReturn : Rp. {0:N}", kembalian);
                                Console.WriteLine("===================");
                                Console.Write("Nama Pelanggan = ");
                                Console.ReadLine();
                                Console.Write(DateTime.Now);
                                Console.ReadLine();
                                Console.Write("Nama Kasir = ");
                                Console.ReadLine();
                                Console.WriteLine("===================");
                                Console.ReadKey();
                                return;
                            }
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please choose a menu in List ");
                }
            }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                Kedai mp = new Kedai();
                string namafile;
                Console.Write("Nama File : ");
                namafile = Console.ReadLine();
                string path = Environment.GetFolderPath
                    (Environment.SpecialFolder.MyDocuments);
                StreamWriter sw = new StreamWriter(Path.Combine(path, $"{namafile}.txt"));
                Console.WriteLine("Welcome to Kedai Viwi" +
                    "\n ------------------------------------------------------" +
                    "\nEnjoy the Food" +
                    "\n-------------------------------------------------------");
                mp.KedaiViwi();
            }
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