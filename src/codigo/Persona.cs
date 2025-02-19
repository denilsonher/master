

public class Persona
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Direccion { get; set; }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
        Console.WriteLine($"Dirección: {Direccion}");
    }
}