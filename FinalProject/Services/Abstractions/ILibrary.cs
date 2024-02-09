using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services.Abstractions
{
    internal interface ILibrary
    {
        void AddBook(Book book);
        void AddMember(Member member);
        void DisplayInventory();

    }
}
