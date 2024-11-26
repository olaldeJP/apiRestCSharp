using ApiRestC.Models;
namespace ApiRestC.Services;

public class  MonoDataStore{
    public List<Mono> Monos {get;set;}

    public static MonoDataStore Current {get;} = new MonoDataStore();

    public MonoDataStore()
    {
        Monos = new List<Mono>(){
            new Mono(){
                Id =1,
                Nombre = "Juan",
                Apellido = "Olalde",
                Habilidades = new List<Habilidad>(){
                    new Habilidad(){
                        Id=1,
                        Nombre="Saltar",
                        Potencia=Habilidad.EPotencia.saltar
                    }
                }
            },     
            new Mono(){
                Id =2,
                Nombre = "Fede",
                Apellido = "Castro",
                Habilidades = new List<Habilidad>(){
                    new Habilidad(){
                        Id=1,
                        Nombre="Golpear",
                        Potencia=Habilidad.EPotencia.golpea
                    },  
                    new Habilidad(){
                        Id=2,
                        Nombre="Correr",
                        Potencia=Habilidad.EPotencia.correr
                    }
                }
            }
        };
    }
}