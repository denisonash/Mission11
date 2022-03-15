﻿using System;
using System.Linq;

namespace Mission7.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Books> Books { get; }

        public void SaveBook(Books b);
        public void CreateBook(Books b);
        public void DeleteBook(Books b);
    }
}
