using System;

/* Para que la clase cumpla con el concepto de SOLID y SRP, esta deberia tener una unica responsabilidad. 
Es decir, la clase book, unicamente deberia crear los libros o brindar la informacion sobre cada libro
y no tener informacion extra como el estante y sector en el que esta ubicado. La clase libro conoce informacion
que no deberia conocer. 

Para modificar el codigo, podriamos crear otra clase que tenga informacion de donde deberia ubicarse el libro. 
*/
namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
