using Study.dotnetcoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study.dotnetcoreMVC.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.AuthorName.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>() {
            new BookModel(){ Id = 1 , Title ="MVC" ,AuthorName="kaustubh" },
            new BookModel(){ Id = 2 , Title ="Yoga" ,AuthorName="Sayali" },
            new BookModel(){ Id = 3 , Title ="Docker" ,AuthorName="kaustubh" },
            new BookModel(){ Id = 4 , Title ="AI" ,AuthorName="Saurabh" },
            new BookModel(){ Id = 5 , Title ="MVC" ,AuthorName="Saurabh" },
            new BookModel(){ Id = 6 , Title ="Ayurveda" ,AuthorName="Sayali" }
            };
        }

    }
}
