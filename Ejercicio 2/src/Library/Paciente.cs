namespace SistemaCitasMedicas
{
    // Paciente debe conocer y validar la información del paciente.
    public class Paciente
    {
        private bool valido = true;
        private string nombre;
        private string id;
        private string telefono;
        private int edad;

        public bool Valido
        {
            get
            {
                return this.valido;
            }

            set
            {
                this.valido = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = null;
                    Valido = false;
                }
            }
        }
        public string Id 
        {
            get
            {
                return this.id;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.id = value;
                }
                else
                {
                    this.id = null;
                    Valido = false;
                }
            }
        }
        public string Telefono
        {
            get
            {
                return this.telefono;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.telefono = value;
                }
                else
                {
                    this.telefono = null;
                    Valido = false;
                }
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }

            set
            {
                if (value >= 0 && value <= 125)
                {
                    this.edad = value;
                }
                else
                {
                    this.edad = -1;
                    Valido = false;
                }
            }
        }

        public Paciente(string nombre, string id, string telefono, int edad)
        {
            Nombre = nombre;
            Id = id;
            Telefono = telefono;
            Edad = edad;
        }
    }
}