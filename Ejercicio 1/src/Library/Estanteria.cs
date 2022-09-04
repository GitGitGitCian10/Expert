using System.Collections.Generic;

namespace SRP
{
    public class Estanteria
    {
    // Estantería debe conocer su propio nombre, los libros que contiene y sus posiciones.
        public Dictionary<int, Libro> PosicionesLibros = new Dictionary<int, Libro>();

        public string Nombre {get; set;}

        public Estanteria(string nombre)
        {
            Nombre = nombre;
        }

        public void AñadirLibro(int posicionLibro, Libro libro)
        {
            PosicionesLibros.Add(posicionLibro, libro);
        }

    }

}
