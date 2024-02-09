using FinalProject.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Library:ILibrary
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Member> Members { get; set; } = new List<Member>();

        

        public void AddBook(Book book)
        {
            Console.WriteLine("Book " + book.Title + " Added");
            Books.Add(book);
        }
        public void AddMember(Member member)
        {
            Console.WriteLine("Member " + member.Name + " Added");
            Members.Add(member);
        }
        public void DisplayInventory()
        {
            for (int i = 0; i < Members.Count; i++)
            {
                Console.WriteLine(Members[i].Name+ " - " + Books[i].Title);
            }
        }
    }
}
