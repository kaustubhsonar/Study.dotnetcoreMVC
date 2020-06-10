using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Study.dotnetcoreMVC.Controllers
{
    public class BookController : Controller
    {
        public string GetBooks()
        {
            return "Getting all the books";
        }

        public string GetBook(int id)
        {
            return $"Getting book with id = {id}";
        }

        //http://localhost:1180/book/searchbooks?name=jobs&authorname=kaustubh
        public string SearchBooks(string name, string authorName)
        {
            return $"Getting book with name = {name} and author = {authorName}";
        }
    }
}