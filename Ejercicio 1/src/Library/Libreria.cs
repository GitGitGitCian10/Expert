using System.Collections.Generic;

namespace SRP
{
    // Librería debe conocer las estanterias que tiene y sus sectores.
    public class Libreria
    {

        public Dictionary<int, Estanteria> Coleccion = new Dictionary<int, Estanteria>();

        public void AñadirEstanteria(int sector, Estanteria estanteria)
        {
            Coleccion.Add(sector, estanteria);
        }

    }

}