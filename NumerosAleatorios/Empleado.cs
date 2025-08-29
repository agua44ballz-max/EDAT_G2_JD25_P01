namespace NumerosAleatorios
{
    internal class Empleado
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public char Grupo { get; set; }
        public double Sueldo { get; set; }
        public bool SeguroMedico { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero}\n" +
                   $"Nombre: {Nombre}\n" +
                   $"Fecha Nacimiento: {FechaNacimiento.ToShortDateString()}\n" +
                   $"Sexo: {Sexo}\n" +
                   $"Grupo: {Grupo}\n" +
                   $"Sueldo: ${Sueldo}\n" +
                   $"Seguro Médico: {(SeguroMedico ? "Sí" : "No")}";
        }
    }
}
