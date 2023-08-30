using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SRP
{
    public class Shelve
    {
        public string LibraryShelve {get;set;}
        
        public string Name {get;}
        public List<Book> BooksOnShelve {get;} = new List<Book>();
        
        public Shelve(string name)
        {
            this.LibraryShelve = name;
        }
        public void AddBookToShelve (Book book)
        {
            BooksOnShelve.Add(book);
        }
        public void RemoveBookFromShelve(Book book)
        {
            BooksOnShelve.Remove(book);
        }
    }

    // lista de libros, solo contiene los objetos libros
    // 
}