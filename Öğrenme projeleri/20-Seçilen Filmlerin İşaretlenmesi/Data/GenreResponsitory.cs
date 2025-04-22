using System.Collections.Generic;
using System.Linq;
using View_Models.Models;

namespace View_Components.Data
{
    public class GenreResponsitory
    {
        private static readonly List<Genre> _genre = null;

        static GenreResponsitory()
        {
            _genre = new List<Genre>()
            {

                new Genre { GenreId = 1,Name = "Aksiyon"},
                new Genre { GenreId = 2,Name = "Macera"},
                new Genre { GenreId = 3,Name = "Romantik"},
                new Genre { GenreId = 4,Name = "Bilim Kurgu"}
            };
        }

        public static List<Genre> Genre
        {
            get
            {
                return _genre;
            }
        }

        public static void Add(Genre genre)
        {
            _genre.Add(genre);
        }
        public static Genre GetById(int id)
        {
            return _genre.FirstOrDefault(g => g.GenreId == id);
        }
    }
}
