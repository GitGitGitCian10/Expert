using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Libreria libreria1 = new Libreria();
            Estanteria estanteriaA = new Estanteria("A");
            Estanteria estanteriaB = new Estanteria("B");
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libreria1.AñadirEstanteria(101, estanteriaA);
            libreria1.AñadirEstanteria(002, estanteriaB);
            estanteriaA.AñadirLibro(7, libro1);
            estanteriaB.AñadirLibro(3, libro2);
            Console.WriteLine("-----------------------------");
            foreach(KeyValuePair<int, Estanteria> estanteria in libreria1.Coleccion)
            {
                Console.WriteLine($"Estanteria: {estanteria.Value.Nombre}");
                foreach(KeyValuePair<int, Libro> libro in estanteria.Value.PosicionesLibros)
                {
                    Console.WriteLine($"Posición: {libro.Key} \nNombre: {libro.Value.Title}\nAutor: {libro.Value.Author}\nCódigo: {libro.Value.Code}");
                }
                Console.WriteLine("-----------------------------");
            }

        }
    }
}