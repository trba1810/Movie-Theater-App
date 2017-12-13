using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public class Film
    {
        public string NazivFilma { get; set; }
        public int CenaKarte { get; set; }
        public DateTime[] Datum { get; set; }
        public Genre[] Zanr { get; set; }
        public int GodinaIzdavanja { get; set; }
        public int VremeTrajanja { get; set; }



        
        
        public List<Film> ReturnListuFilmova()
        {
            List<Film> ListaFilmova = new List<Film>
            {
            new Film
            {
                NazivFilma = "Dunkirk",
                CenaKarte = 250,
                Datum = MovieDates(5,24),
                Zanr = new Genre[] { Genre.Akcija,Genre.Triler },
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma ="The lost citi of Z",
                CenaKarte =300,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Biografija,Genre.Avantura},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "Moana",
                CenaKarte = 200,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Animacija,Genre.Avantura,Genre.Komedija},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Sucide Squad",
                CenaKarte = 350,
                Datum = MovieDates(7,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.Fantazija},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "Roque One",
                CenaKarte = 350,
                Datum = MovieDates(7,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.SciFi},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "Lion",
                CenaKarte = 400,
                Datum = MovieDates(4,24),
                Zanr = new Genre[] {Genre.Biografija,Genre.Drama},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "Keeping up with the Joneses",
                CenaKarte = 350,
                Datum = MovieDates(5,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Komedija},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Split",
                CenaKarte =500,
                Datum = MovieDates(3,24),
                Zanr =new Genre[] {Genre.Horor,Genre.Triler},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 75
            },
            new Film
            {
                NazivFilma = "Trols",
                CenaKarte = 450,
                Datum = MovieDates(5,24),
                Zanr = new Genre[] {Genre.Animacija,Genre.Avantura,Genre.Komedija},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 75
            },
            new Film
            {
                NazivFilma = "Noncturnal Animals",
                CenaKarte = 200,
                Datum = MovieDates(14,24),
                Zanr = new Genre[] {Genre.Drama,Genre.Triler},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 75
            },
            new Film
            {
                NazivFilma = "Passengers",
                CenaKarte = 350,
                Datum = MovieDates(14,24),
                Zanr = new Genre[] {Genre.Avantura,Genre.Drama,Genre.Romansa},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "Hacksaw Ridge",
                CenaKarte = 250,
                Datum = MovieDates(5,24),
                Zanr = new Genre[] {Genre.Biografija,Genre.Drama,Genre.Istorijski},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Captain America Civil War",
                CenaKarte = 400,
                Datum = MovieDates(10,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.SciFi},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "Deadpool",
                CenaKarte = 300,
                Datum = MovieDates(21,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.Komedija},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "Doctor Strange",
                CenaKarte = 450,
                Datum = MovieDates(7,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.Fantazija},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "X men Apocalypse",
                CenaKarte = 250,
                Datum = MovieDates(7,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.SciFi},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "La La Land",
                CenaKarte = 250,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Komedija,Genre.Drama},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 75
            },
            new Film
            {
                NazivFilma = "Fantastic Beasts and Where to find them",
                CenaKarte = 300,
                Datum = MovieDates(5,24),
                Zanr = new Genre[] {Genre.Avantura,Genre.Fantazija},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Star Trek Beyond",
                CenaKarte = 350,
                Datum = MovieDates(10,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.SciFi},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Batman v Superman Dawn of Justice",
                CenaKarte = 500,
                Datum = MovieDates(21,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.SciFi},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Arrival",
                CenaKarte = 250,
                Datum = MovieDates(21,24),
                Zanr = new Genre[] {Genre.Drama,Genre.Misterija,Genre.SciFi},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "The Promise",
                CenaKarte = 300,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Drama,Genre.Istorijski},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "12 Feet Deep",
                CenaKarte = 200,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Triler},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 75
            },
            new Film
            {
                NazivFilma = "Me Before You",
                CenaKarte = 300,
                Datum = MovieDates(7,24),
                Zanr = new Genre[] {Genre.Drama,Genre.Romansa},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Hidden Figures",
                CenaKarte = 300,
                Datum = MovieDates(14,24),
                Zanr = new Genre[] {Genre.Biografija,Genre.Drama,Genre.Istorijski},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "The Belko Experiment",
                CenaKarte = 250,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Horor,Genre.Triler},
                GodinaIzdavanja = 2016,
                VremeTrajanja = 120
            },
            new Film
            {
                NazivFilma = "The Accountant",
                CenaKarte = 300,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Kriminal,Genre.Drama},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "The magnificent seven",
                CenaKarte =350,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Moonlight",
                CenaKarte = 300,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Drama},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Sleight",
                CenaKarte = 300,
                Datum = MovieDates(7,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Drama,Genre.SciFi},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "The girl on the train",
                CenaKarte = 250,
                Datum = MovieDates(3,24),
                Zanr = new Genre[] {Genre.Drama,Genre.Kriminal,Genre.Misterija},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "The Great Wall",
                CenaKarte = 450,
                Datum = MovieDates(14,24),
                Zanr = new Genre[] {Genre.Akcija,Genre.Avantura,Genre.Fantazija},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 90
            },
            new Film
            {
                NazivFilma = "Nerve",
                CenaKarte = 500,
                Datum = MovieDates(21,24),
                Zanr = new Genre[] {Genre.Avantura,Genre.Kriminal,Genre.Misterija},
                GodinaIzdavanja = 2017,
                VremeTrajanja = 120
            },
        };
            return ListaFilmova;
        }
    
        private DateTime[] MovieDates(int rep, double termin)
        {
            var Dates = new DateTime[rep];
            var Today = DateTime.Now;
            Dates[0] = Today;
            for (var i = 1; i < rep; i++)
            {
                Dates[i] = Today.AddHours(termin);
                termin = termin + 24;

            }
            return Dates;
        }

    }
    public enum Genre
    {
        Komedija,
        Triler,
        Akcija,
        Drama,
        SciFi,
        Animacija,
        Horor,
        Dokumentarac,
        Kriminal,
        Istorijski,
        Misterija,
        Biografija,
        Avantura,
        Fantazija,
        Romansa
    }
    public enum Genre2
    {
        NotFound
    }
}
