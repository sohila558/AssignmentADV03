using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV03
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn, string title, string[] authors, DateTime date, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = date;
            Price = price;
        }

        public override string ToString()
        {
            return $"ISBN : {ISBN}, Title : {Title}, Authors : {Authors}, PublicationDate : {PublicationDate}, Price : {Price}";
        }
    }
}
