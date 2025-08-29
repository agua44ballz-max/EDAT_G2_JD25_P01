namespace NumerosAleatorios
{
    internal class Propiedades
    {
        public Empleado GenerarEmpleadoAleatorio()
        {
            Random rnd = new Random();
            string[] nombres = { "maria", "Lui", "Carl", "anna", "Sofí" };
            string[] sexos = { "Masculino", "Femenino" };
            char[] grupos = { 'A', 'B', 'C', 'D' };

            return new Empleado()
            {
                Numero = rnd.Next(1000, 9999),
                Nombre = nombres[rnd.Next(nombres.Length)],
                FechaNacimiento = new DateTime(rnd.Next(1970, 2025), rnd.Next(1, 13), rnd.Next(1, 31)),
                Sexo = sexos[rnd.Next(sexos.Length)],
                Grupo = grupos[rnd.Next(grupos.Length)],
                Sueldo = Math.Round(rnd.NextDouble() * 10000 + 3000, 2),
                SeguroMedico = rnd.Next(2) == 1
            };
        }
    }
}
