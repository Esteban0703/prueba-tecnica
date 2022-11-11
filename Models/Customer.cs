using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Models;

public class Customer
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Telefono { get; set; }
    public string? Email { get; set; }

    public string? Gender { get; set; }

    public string? Motivo { get; set; }

}