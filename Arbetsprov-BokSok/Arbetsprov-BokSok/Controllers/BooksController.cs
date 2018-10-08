using Arbetsprov_BokSok.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace Arbetsprov_BokSok.Controllers
{
    public class BooksController : ApiController
    {
        string test = "";
        XmlDocument doc;
        public BooksController()
        {
            test = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/BookStorage.xml");
            doc = new XmlDocument();
            doc.Load(test);
            doc.LoadXml(doc.InnerXml);
        }

        [HttpGet]
        [Route("api/getAllBooks")]
        public IEnumerable<Book> GetAllProducts()
        {
            var book = fetchNodes(doc);
            return book;
        }

        [HttpGet]
        [Route("api/find/{bookTitle}")]
        public IEnumerable<Book> FindByTitle(string bookTitle)
        {
            var booksList = new List<Book>();

            var books = fetchNodes(doc);

            foreach (var book in books)
            {   
                    if (book.Title.Contains(bookTitle))
                {
                    booksList.Add(book);
                }
            }
            return booksList;
        }

        private List<Book> fetchNodes(XmlDocument doc)
        {
            var bookList = new List<Book>();

            foreach (XmlNode node in doc.DocumentElement)
            {
                var id = node.Attributes[0].Value;
                var author = node["author"].InnerText;
                var title = node["title"].InnerText;
                var genre = node["genre"].InnerText;
                var price = node["price"].InnerText;
                var publish_date = DateTime.Parse(node["publish_date"].InnerText);
                var description = node["description"].InnerText;
                bookList.Add(new Book (id, author, title, genre, price, publish_date, description));             
            }
            return bookList;
        }
    }
}
