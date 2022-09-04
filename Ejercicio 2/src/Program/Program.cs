using System;

namespace SistemaCitasMedicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Armand Jay", "836694756", "4847-324-920", "Cirujano");
            Doctor doctor2 = new Doctor("Sergio Kelvin", "412349562", "7164-232-798", "Anestesiologo");
            Paciente paciente1 = new Paciente("Steven Jhonson", "986782342", "5555-555-555", 36);
            Paciente paciente2 = new Paciente("Ralf Manson", "", "5555-555-555", 54);
            Cita cita1 = new Cita(paciente1, DateTime.Now, "Clínica Uruguay", doctor1);
            Cita cita2 = new Cita(paciente2, DateTime.Now, "Médica Uruguaya", doctor2);
            Console.WriteLine(ImpresionCita.ImprimirCita(cita1));
            Console.WriteLine(ImpresionCita.ImprimirCita(cita2));
        }
    }
}
