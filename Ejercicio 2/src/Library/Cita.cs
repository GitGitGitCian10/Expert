using System;

namespace SistemaCitasMedicas
{
    public class Cita
    {
        /*
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {

            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }
        La cita no debe hacer las verificaciones del paciente ni del doctor, eso deben hacerlo sus respectivas clases.
        */

        private static int numeroCita = 0;
        private bool valido = true;
        private string lugarCita;
        private int identificadorCita;

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
        public Paciente Paciente {get; set;}
        public DateTime Fecha {get; set;}
        public string LugarCita 
        {
            get
            {
                return this.lugarCita;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value)) 
                {
                    this.lugarCita = value;
                }
                else
                {
                    this.lugarCita = null;
                    Valido = false;
                }
            }
        }
        public int IdentificadorCita
        {
            get
            {
                return this.identificadorCita;
            }

            set
            {
                this.identificadorCita = value;
            }
        }
        public Doctor Doctor {get; set;}
        public int NumeroCita
        {
            get
            {
                return Cita.numeroCita;
            }

            set
            {
                Cita.numeroCita = value;
            }
        }

        public Cita(Paciente paciente, DateTime fecha, string lugarCita, Doctor doctor)
        {
            NumeroCita++;
            IdentificadorCita = NumeroCita;
            Paciente = paciente;
            Fecha = fecha;
            LugarCita = lugarCita;
            Doctor = doctor;
        }
    }
}