using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book libro1 = new Book ("Iliada","Homero","1234");
            Book libro2 = new Book ("Los Miserables","Victor Hugo","5678");
            Shelve Estante1 = new Shelve ("Estante1");
            Sector Sector1 = new Sector("Clasicos");
            Estante1.AddBookToShelve(libro1);
            Estante1.AddBookToShelve(libro2);
            Sector1.AddShelveToSector(Estante1);



        }
    }
}
// crear sector, objeto sector, objeto shelve, poner libros en shelve y poner shelve en sector. 