using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services.Abstractions
{
    internal interface IMember
    {
        void BorrowBook(Book book);
        void ReturnBook(Book book);
        void DisplayDetails();
    }
}
