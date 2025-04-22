using System.Collections.Generic;
using System.Linq;
using View_Models.Models;

namespace View_Components.Data
{
    public class MovieResponsitory
    {
        private static readonly List<Movie> _movies = null;

        static MovieResponsitory()
        {
            _movies = new List<Movie>()
            {
                new Movie
                {
                    MovieId = 1,
                    Title = "Film 1 ",
                    Description = "Açıklama 1",
                    Director = "Yönetmen 1",
                    Players = new string[]  {"Oyuncu 1","Oyuncu 2"},
                    ImgUrl = "1917.jpg",
                    GenreId = 1
                },
                new Movie
                {
                    MovieId = 2,
                    Title = "Film 2 ",
                    Description = "Açıklama 2",
                    Director = "Yönetmen 2",
                    Players = new string[] { "Oyuncu 1", "Oyuncu 2" },
                    ImgUrl = "avatar.jpg",
                    GenreId = 1
                },
                new Movie
                {
                    MovieId = 3,
                    Title = "Film 3 ",
                    Description = "Açıklama 3",
                    Director = "Yönetmen 3",
                    Players = new string[] { "Oyuncu 1", "Oyuncu 2" },
                    ImgUrl = "thor.jpg",
                    GenreId = 3
                },
                new Movie
                {
                    MovieId = 4,
                    Title = "Film 1 ",
                    Description = "Açıklama 1",
                    Director = "Yönetmen 1",
                    Players = new string[]  {"Oyuncu 1","Oyuncu 2"},
                    ImgUrl = "1917.jpg",
                    GenreId = 3
                },
                new Movie
                {
                    MovieId = 5,
                    Title = "Film 2 ",
                    Description = "Açıklama 2",
                    Director = "Yönetmen 2",
                    Players = new string[] { "Oyuncu 1", "Oyuncu 2" },
                    ImgUrl = "avatar.jpg",
                    GenreId = 4
                },
                new Movie
                {
                    MovieId = 6,
                    Title = "Film 3 ",
                    Description = "Açıklama 3",
                    Director = "Yönetmen 3",
                    Players = new string[] { "Oyuncu 1", "Oyuncu 2" },
                    ImgUrl = "thor.jpg",
                    GenreId = 4
                }
            };
        }

        public static List<Movie> Movies 
        {
            get
            {
                return _movies;
            }
        }

        public static void Add(Movie movie)
        {
            movie.MovieId = _movies.Count() + 1;
            _movies.Add(movie);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault (m => m.MovieId == id);
        }

        public static void Edit(Movie m)
        {
            foreach (var movie in _movies)
            {
                if (movie.MovieId == m.MovieId)
                {
                    movie.Title = m.Title;
                    movie.Description = m.Description;
                    movie.Director = m.Director;
                    movie.ImgUrl = m.ImgUrl;
                    movie.GenreId = m.GenreId;
                    break;
                }
            }
        }
    }
}
