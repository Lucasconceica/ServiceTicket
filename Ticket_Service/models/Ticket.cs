using System.ComponentModel.DataAnnotations;
namespace Ticket_Service.models;

public class Ticket
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Problema { get; set; } 

    [Required]
    public string Descrissão { get; set; }
}
