using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[] {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Something.</p>",
                Favorite = true,
                Artists = new Artist[] {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" }
                }
            },

            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p>Something.</p>",
                Favorite = false,
                Artists = new Artist[] {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" }
                }
            }
        };

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach(var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }
           return comicBookToReturn;
        }
    }
}