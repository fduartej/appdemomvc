using System.ComponentModel.DataAnnotations;

namespace appdemomvc.Models;

public class GameJamRegistration
{
    [Required(ErrorMessage = "El nombre del jugador es obligatorio")]
    [Display(Name = "Nombre del Jugador")]
    public string? NombreJugador { get; set; }

    [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
    [Display(Name = "Fecha de Nacimiento")]
    [DataType(DataType.Date)]
    public DateTime? FechaNacimiento { get; set; }

    [Required(ErrorMessage = "Los hobbies son obligatorios")]
    [Display(Name = "Hobbies")]
    public string? Hobbies { get; set; }

    [Display(Name = "¿Ha completado el pago de matrícula?")]
    public bool PagoMatricula { get; set; }
}
