using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        public static List<Film> Lista
        {
            get;set;
        }

        static void Main(string[] args)
        {
            Film movies = new Film();
            Lista = movies.ReturnListuFilmova();
            var Genres = Enum.GetValues(typeof(Genre));

            Console.WriteLine("**********");
            Console.WriteLine("Dobrodosli u nas bioskop");
            Console.WriteLine("**********");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Izaberite jednu od opcija");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1-Svi filmovi");
            Console.WriteLine("2-Filmovi po zanrovima");
            Console.WriteLine("3-Filmovi po duzini trajanja");
            Console.ResetColor();
            
            string izbor = Console.ReadLine();
            var table = new ConsoleTable("Naziv Filma", "Cena", "Datumi", "Zanrovi");
            switch (izbor)
            {
                case "1":
                    
                    
                    foreach(var m in Lista)
                    {
                        var date = m.Datum.Select(item => item.ToShortDateString());
                        table.AddRow(m.NazivFilma, m.CenaKarte, string.Join(",", date),FindGenre(m.Zanr));
                        
                          
                    }
                    table.Write(Format.Alternative);
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("Zanrovi su:");
                    var sorted = SortMovieByGenre();
                    Console.WriteLine("Izaberite jedan film");
                    foreach (var s in sorted)
                    {
                        var date = s.Datum.Select(item => item.ToShortDateString());
                        table.AddRow(s.NazivFilma, s.CenaKarte, string.Join(",", date), FindGenre(s.Zanr));
                    }
                    table.Write(Format.Alternative);
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Unesi duzinu trajanja 75,90,120");
                    var time = Convert.ToInt32(Console.ReadLine());
                    var result = SortMovieByTime(time);
                    foreach (var r in result)
                    {
                        var date = r.Datum.Select(item => item.ToShortDateString());
                        table.AddRow(r.NazivFilma, r.CenaKarte, string.Join(",", date), FindGenre(r.Zanr));
                    }
                    table.Write(Format.Alternative);
                    Console.WriteLine();
                    break;
            }
            Console.ReadLine();
        }
        public static List<Film> SortMovieByTime(int time)
        {
            switch (time)
            {
                case 75:
                    var list = Lista.Where(item => item.VremeTrajanja == time).ToList();
                    return list;
                case 90:
                    var list2 = Lista.Where(item => item.VremeTrajanja == time).ToList();
                    return list2;
                case 120:
                    var list3 = Lista.Where(item => item.VremeTrajanja == time).ToList();
                    return list3;

                    
            }
            return new List<Film>();
        }
        public static List<Film> SortMovieByGenre()
        {

            List<Film> SortiranaLista = new List<Film>();           
            Console.WriteLine("0-Komedija");
            Console.WriteLine("1-Triler");
            Console.WriteLine("2-Akcija");
            Console.WriteLine("3-Drama");
            Console.WriteLine("4-SciFi");
            Console.WriteLine("5-Animacija");
            Console.WriteLine("6-Horor");
            Console.WriteLine("7-Dokumentarac");
            Console.WriteLine("8-Kriminal");
            Console.WriteLine("9-Istorijski");
            Console.WriteLine("10-Misterija");
            Console.WriteLine("11-Biografija");
            Console.WriteLine("12-Avantura");
            Console.WriteLine("13-Fantazija");
            Console.WriteLine("14-Romansa");
            var choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Komedija)).ToList();
                    break;
                case 1:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Triler)).ToList();
                    break;
                case 2:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Akcija)).ToList();
                    break;
                case 3:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Drama)).ToList();
                    break;
                case 4:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.SciFi)).ToList();
                    break;
                case 5:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Animacija)).ToList();
                    break;
                case 6:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Horor)).ToList();
                    break;
                case 7:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Dokumentarac)).ToList();
                    break;
                case 8:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Kriminal)).ToList();
                    break;
                case 9:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Istorijski)).ToList();
                    break;
                case 10:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Misterija)).ToList();
                    break;
                case 11:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Biografija)).ToList();
                    break;
                case 12:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Avantura)).ToList();
                    break;
                case 13:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Fantazija)).ToList();
                    break;
                case 14:
                    SortiranaLista = Lista.Where(item => item.Zanr.Contains(Genre.Romansa)).ToList();
                    break;


            }
            return SortiranaLista;              
        }
        private static string FindGenre(Genre[] array)
        {
            var genres = "";
            foreach (var g in array)
            {
                if (g == Genre.Komedija)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Triler)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Akcija)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Drama)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.SciFi)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Animacija)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Horor)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Dokumentarac)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Kriminal)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Istorijski)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Misterija)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Biografija)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Avantura)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Fantazija)
                {
                    genres = genres + "," + g.ToString();
                }
                else if (g == Genre.Romansa)
                {
                    genres = genres + "," + g.ToString();
                }                
            }
            if (genres != "")
            {
                return genres;
            }
            
            return "Not Found";
        }

    }
}
