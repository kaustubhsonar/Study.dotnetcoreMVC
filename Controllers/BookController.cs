using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Study.dotnetcoreMVC.Repository;
using Study.dotnetcoreMVC.Models;

namespace Study.dotnetcoreMVC.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = null;
        public BookController()
        {
            bookRepository = new BookRepository();
        }

        public List<BookModel> GetBooks()
        {
            return bookRepository.GetAllBooks();
        }

        public BookModel GetBook(int id)
        {
            return bookRepository.GetBookById(id);
        }

        //http://localhost:1180/book/searchbooks?name=jobs&authorname=kaustubh
        public List<BookModel> SearchBooks(string name, string authorName)
        {
            return bookRepository.SearchBook(name, authorName);
        }
    }
}