using FinalProject.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Member:IMember
    {
        public string Name { get; set; }
        public bool FinesOwed { get; set; }

        public void BorrowBook(Book book)
        {

            book.BorrowBook(this);
        }
        public void ReturnBook(Book book)
        {
            book.ReturnBook(this);
        }
        public void DisplayDetails()
        {
            Console.WriteLine(Name + "\n" + FinesOwed);
        }
    }
}
