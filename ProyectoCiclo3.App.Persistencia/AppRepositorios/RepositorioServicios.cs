using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicios
    {
        List<Servicio> servicios;
 
    public RepositorioServicios()
        {
            servicios= new List<Servicio>()
            {
                new Servicio{id=1,origen="Rionegro",destino= "Medellin",fecha= "04/12/2022",hora= "11:00",encomienda= "Caja"},
                new Servicio{id=2,origen="Pasto",destino= "Bogota",fecha= "05/11/2022",hora= "12:00",encomienda= "Caja"},
                new Servicio{id=3,origen="Sannta Marta",destino= "Bogota",fecha= "11/10/2022",hora= "12:10",encomienda= "Caja"}
                
               
            };
        }
 
        public IEnumerable<Servicio> GetAll()
        {
            return servicios;
        }
 
        public Servicio GetWithId(int id){
            return servicios.SingleOrDefault(e => e.id == id);
        }

         public Servicio Create(Servicio newServicio)
        {
           if(servicios.Count > 0){
             newServicio.id=servicios.Max(r => r.id) +1;
            }else{
               newServicio.id = 1;
            }
           servicios.Add(newServicio);
           return newServicio;
        }

        public Servicio Delete(int id)
        {
            var servicio = servicios.SingleOrDefault(e => e.id == id);
            servicios.Remove(servicio);
            return servicio;
        }
    }
}