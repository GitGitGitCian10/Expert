using System.Text;

namespace SistemaCitasMedicas
{
    public class ImpresionCita
    {
        public static string ImprimirCita(Cita cita)
        {
            StringBuilder textoCita = new StringBuilder();
            textoCita.Append("-------------------------\n");
            if (cita.Valido && cita.Paciente.Valido && cita.Doctor.Valido)
            {

                textoCita.Append($"Cita N°: {cita.IdentificadorCita}\nLugar: {cita.LugarCita}\nFecha: {cita.Fecha}\n-\n");
                textoCita.Append($"Paciente: {cita.Paciente.Nombre}\nId: {cita.Paciente.Id}\nTeléfono: {cita.Paciente.Telefono}\nEdad: {cita.Paciente.Edad}\n-\n");
                textoCita.Append($"Doctor: {cita.Doctor.Nombre}\nEspecialidad: {cita.Doctor.Especialidad}\n");
            }
            else
            {
                textoCita.Append("Cita Inválida\n");
            }
            textoCita.Append("-------------------------");
            return textoCita.ToString();
        }
    }
}