using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagement
{
    internal class EBook : Book
    {
        public double Filesize { get; set; }
        public string Format { get; set; }

        public EBook(double filesize, string format,int bookId, string title, string author, decimal rentalPrice):base(bookId, title, author, rentalPrice)
        {
            Filesize = filesize;
            Format = format;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, format:{Format},filesize:{Filesize}";
        }
    }
}
