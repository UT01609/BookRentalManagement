using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagement
{
    internal class PrintBook : Book
    {
        public int ISBN { get; set; }
        public int NumberOfPages { get; set; }

        public PrintBook(int iSBN, int numberOfPages,int bookId, string title, string author, decimal rentalPrice):base(bookId, title, author, rentalPrice)
        {
            ISBN = iSBN;
            NumberOfPages = numberOfPages;
        }


        public override string ToString()
        {
            return $"{base.ToString()},isbn:{ISBN},numberofpages:{NumberOfPages}";
        }
    }
}
