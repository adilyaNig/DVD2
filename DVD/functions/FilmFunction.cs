using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVD.Connection;
using System.Collections.ObjectModel;

namespace DVD.functions
{
    internal class FilmFunction
    {
        public static ObservableCollection<Film> films { get; set; }
        public static ObservableCollection<Film> GetFilms()
        {
            return new ObservableCollection<Film>(Connection.Connection.dvd.Film.ToList());

        }
        public static ObservableCollection<Film> SearchFilm(string name)
        {
            return new ObservableCollection<Film>(Connection.Connection.dvd.Film.Where(x => x.Title.Contains(name)).ToList());
            
        }
        public static Film GitFilmInfo(int id)
        {
            Film selectedFilm = Connection.Connection.dvd.Film.Where(filmID => filmID.id_film == id).FirstOrDefault();
            Film film = new Film()
            {
                id_film = selectedFilm.id_film,
                Title = selectedFilm.Title,
                id_genre = selectedFilm.id_genre,
                Price = selectedFilm.Price
            };
            return film;
        }

    }
}
