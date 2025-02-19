


public class Persona {
    public int Id { get; set; } 
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Direccion { get; set; }

    public Persona(int id, string nombres, string apellidos, DateTime fechaNacimiento, string direccion) {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        FechaNacimiento = fechaNacimiento;
        Direccion = direccion;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento}");
        Console.WriteLine($"Dirección: {Direccion}");
    }

}