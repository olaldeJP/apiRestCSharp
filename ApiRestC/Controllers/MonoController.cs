using Microsoft.AspNetCore.Mvc;
using ApiRestC.Models;
using ApiRestC.Services;

namespace ApiRestC.Controllers;

[ApiController]
[Route("api/monos")]
public class MonoController: ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Mono>> GetMonos(){
        return Ok(MonoDataStore.Current.Monos);
    }

    [HttpGet("{monoId}")]
    public ActionResult<IEnumerable<Mono>> GetMono(int monoId){
        var mono = MonoDataStore.Current.Monos.FirstOrDefault(x =>x.Id ==monoId);
        if(mono == null){
            return NotFound("Mono No Encontrado");
      }
      return Ok(mono);
    }
    [HttpPost]
    public ActionResult<Mono> PostMono(MonoInsert monoInsert){

        var maxMono = MonoDataStore.Current.Monos.Max(x =>x.Id);
        var monoNuevo = new Mono(){
            Id = maxMono +1,
            Nombre = monoInsert.Nombre,
            Apellido = monoInsert.Apellido,

        };
    MonoDataStore.Current.Monos.Add(monoNuevo);
    return CreatedAtAction(nameof(GetMono),new {monoId = monoNuevo.Id},monoNuevo);
    }
    
}
