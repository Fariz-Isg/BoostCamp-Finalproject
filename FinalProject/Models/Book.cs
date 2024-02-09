using FinalProject.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Book:IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public bool CopiesAvailable { get; set; }

        public void BorrowBook(Member member) 
        {
            if (CopiesAvailable == false)
                Console.WriteLine($"{member.Name} can not claim {Title} because, book unavailable");
            else
            {
                Console.WriteLine($"{member.Name} claimed {Title}");
                member.FinesOwed = true;
                CopiesAvailable = false;
            }
        }
        public void ReturnBook(Member member)
        {
            member.FinesOwed = false;
            CopiesAvailable = true;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(Title + "\n" + Author + "\n" + Genre + "\n" + PublicationYear + "\n" + CopiesAvailable);
        }

    }
}
