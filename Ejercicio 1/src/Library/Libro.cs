namespace SRP
{
    public class Libro 
    {
    // Libro debe conocer la información de sí mismo, siendo esta: Título, Autor y Código.
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        //public string LibrarySector { get ; set; } (Modificación)
        //public string LibraryShelve { get ; set; } (Modificación)

        // Un libro no debería de saber en qué libreria está.

        public Libro(string title, string author, string code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        /* (Modificación)
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        */

    }
}
