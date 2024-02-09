﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services.Abstractions
{
    internal interface IBook
    {
        void BorrowBook(Member member);
        void ReturnBook(Member member);
        void DisplayDetails();

    }
}
