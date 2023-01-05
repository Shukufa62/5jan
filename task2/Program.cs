using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nt1 = new Notebook { Name = "Acer 1", Price = 1200, Ram = 2, Storage = 500 };
            var nt2 = new Notebook { Name = "Acer 2", Price = 1400, Ram = 2, Storage = 500 };
            var nt3 = new Notebook { Name = "Acer 3", Price = 1600, Ram = 2, Storage = 500 };
            var ph1 = new Phone { Name = "Iphone 1", Price = 500, Camera = 4, SimCount = 1 };
            var ph2 = new Phone { Name = "Iphone 11", Price = 1500, Camera = 14, SimCount = 1 };
            var ph3 = new Phone { Name = "Iphone 12", Price = 2500, Camera = 4, SimCount = 1 };
            var ph4 = new Phone { Name = "Iphone 13", Price = 3500, Camera = 4, SimCount = 1 };

            Product[] products = { nt1, nt2, nt3, ph1, ph2, ph3, ph4 };

            string opt;
            do
            {
                Console.WriteLine("---------Menu----------");

                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Notebooklarin sayina bax bax");
                Console.WriteLine("5. Telefonlarin sayina bax bax");
                Console.WriteLine("6. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("7. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("0. Cix");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":

                        Console.WriteLine("----------- Products----------");
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(products[i].Name + " - " + products[i].Price);
                        }
                        break;

                    case "2":
                        Console.WriteLine("----------Notebooks----------");
                        for(int i = 0; i < products.Length; i++)
                        {
                            if (products[i]is Notebook)
                            {
                                var nt = products[i] as Notebook;
                                Console.WriteLine(products[i].Name+"-"+nt.Price+"-"+nt.Ram);
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("----------Phones----------");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                            {
                                var ph = products[i] as Phone;
                                Console.WriteLine(products[i].Name + "-" + ph.Price + "-" + ph.Camera+"-"+ph.SimCount);
                            }
                        }

                        break;
                    case "4":
                        int notebookcount = 0;
                        Console.WriteLine("---------Notebookcount---------");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                notebookcount++;
                            }
                        }
                        Console.WriteLine("Notebook sayi: " + notebookcount);

                        break;
                    case "5":
                        int phonecount = 0;
                        Console.WriteLine("---------Phonecount---------");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                phonecount++;
                            }
                        }
                        Console.WriteLine("Notebook sayi: " + phonecount);


                        break;
                    case "6":
                        int notebookcountavg = 0;
                        int noteboookpricesum = 0;
                       int result ;
                        Console.WriteLine("---------NotebookcAverage---------");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                var nt = products[i] as Notebook;
                                notebookcountavg++;
                                noteboookpricesum += nt.Price;
                               
                                
                            }
                            ;
                        }
                        result = noteboookpricesum / notebookcountavg;
                        Console.WriteLine(result);

                        break;
                    case "7":
                        int phonecountavg = 0;
                        int phonepricesum = 0;
                        int result1;
                        Console.WriteLine("---------PhonecAvergae---------");
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                            {
                                var nt = products[i] as Notebook;
                               phonecountavg++;
                              phonepricesum += nt.Price;


                            }
                            
                        }
                        result1 = phonepricesum / phonecountavg;
                        Console.WriteLine(result1);

                        break;

                }

            } while (opt != "0");
            Console.WriteLine("Proses bitdi");

        }
    }
}

