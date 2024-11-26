using System.ComponentModel.DataAnnotations;

namespace ApiRestC.Models;

public class Mono{
  
    public int Id{get;set;}  
      [Required]
     public string Nombre{get;set;}=String.Empty;
    public string Apellido{get;set;}=String.Empty;

    public List<Habilidad>? Habilidades {get;set;}
}