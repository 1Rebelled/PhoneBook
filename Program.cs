using System;
using System.Collections.Generic;
namespace KsiazkaTelefoniczna1
{
    class Program
    {
        static void Main(string[] args)
        {


            SortedDictionary<string, string> definition = new SortedDictionary<string, string>();
            definition.Add("Anna Czarnecka", "765756756");
            definition.Add("Aldona Maciejewska", "765754456");
            definition.Add("Marcela Borkowska", "654634345");
            definition.Add("Alina Piotrowska", "4252523");
            definition.Add("Daniela Chmielewska", "25323523");
            definition.Add("Hortensja Dąbrowska", "324324234");
            definition.Add("Marysia Kowalczyk", "4324234234");
            definition.Add("Julita Ziółkowska", "21312321");
            definition.Add("Florentyna Kubiak", "321312321");
            definition.Add("Ewelina Bąk", "321312312");

            do
            {

                Console.WriteLine("Wybierz opcje\n" +
                    "- [w]  Wyświetlanie całej książki telefonicznej\n" +
                    "- [s] Szukanie po imieniu i nazwisku\n" +
                    "- [a] Szukanie po numerze telefonu\n" +
                    "- [d] Dodawanie nowego wpisu do książki \n");
                ConsoleKeyInfo keyinfo = Console.ReadKey();

                if (keyinfo.Key == ConsoleKey.D)
                {
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wprowadz imie i nazwisko oddzielajac je spacjami: ");
                    string imie = Console.ReadLine();
                    Console.WriteLine("Wprowadz numer ");
                    string nazwisko = Console.ReadLine();

                    definition[imie] = nazwisko;
                    Console.ForegroundColor = ConsoleColor.Gray;

                }

                else if (keyinfo.Key == ConsoleKey.W)
                {
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    foreach (KeyValuePair<string, string> def in definition)
                    {
                        Console.WriteLine($" {def.Key}: {def.Value}");
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }

                }

                else if (keyinfo.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\n Szukaj po numerze telefonu");
                    string SzukajNazwiska = Console.ReadLine();

                    foreach (KeyValuePair<string, string> def in definition)
                    {
                        if (def.Value == SzukajNazwiska)
                        {
                            Console.WriteLine($"{def.Key}: {def.Value}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {

                            break;
                        }



                    }


                }
                else if (keyinfo.Key == ConsoleKey.S)
                {
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\n Szukaj po imieniu i nazwisku");
                    string SzukajNazwiska = Console.ReadLine();

                    foreach (KeyValuePair<string, string> def in definition)
                    {
                        if (def.Key == SzukajNazwiska)
                        {
                            Console.WriteLine($"{def.Key}: {def.Value}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {

                            break;
                        }

                    }

                }


                else
                {
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Czy chcesz wyjsc z programu t/n");

                    if (Console.ReadKey().Key == ConsoleKey.T)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }



            } while (true);

        }


    }
}
