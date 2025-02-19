public class CuerpoTecnico : Persona
{
    public string Cargo { get; set; }

    // Constructor correcto
    public CuerpoTecnico(int id, string nombres, string apellidos, DateTime fechaNacimiento, string direccion, string cargo)
        : base() // Llama al constructor de la clase base (Persona)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        FechaNacimiento = fechaNacimiento;
        Direccion = direccion;
        Cargo = cargo;
    }
    public override void MostrarInformacion()
    {
        base.MostrarInformacion(); // Llama al método de la clase base
        Console.WriteLine($"Cargo: {Cargo}");
    }
}
