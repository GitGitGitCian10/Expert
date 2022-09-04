namespace SistemaCitasMedicas
{
    public class Doctor
    {
        private bool valido = true;
        private string nombre;
        private string id;
        private string telefono;
        private string especialidad;
        
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

        public string Especialidad
        {
            get
            {
                return this.especialidad;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.especialidad = value;
                }
                else
                {
                    this.especialidad = null;
                    Valido = false;
                }
            }
        }

        public Doctor(string nombre, string id, string telefono, string especialidad)
        {
            Nombre = nombre;
            Id = id;
            Telefono = telefono;
            Especialidad = especialidad;
        }
    }
}