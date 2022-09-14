using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuarios
    {
        List<Usuario> usuarios;
 
    public RepositorioUsuarios()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Anderson",apellidos= "Sanchez",direccion= "calle 55 # 34-22",telefono= "320914543", ciudad="Rionegro"},
                new Usuario{id=2,nombre="Carlos",apellidos= "Higuera",direccion= "calle 23 # 48-10",telefono= "300545122", ciudad="Manizales"},
                new Usuario{id=3,nombre="Luis",apellidos= "Ramirez",direccion= "carrera 82 # 55-45",telefono= "4545454545", ciudad="Bogota"}
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetWithId(int id){
            return usuarios.SingleOrDefault(e => e.id == id);
        }
        
        public Usuario Update(Usuario newUsuario){
            var usuario = usuarios.SingleOrDefault(e => e.id == newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
                usuario.ciudad = newUsuario.ciudad;
            }
        return usuario;
        }

        public Usuario Create(Usuario newUsuario)
        {
           if(usuarios.Count > 0){
             newUsuario.id=usuarios.Max(r => r.id) +1;
            }else{
               newUsuario.id = 1;
            }
           usuarios.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Delete(int id)
        {
            var usuario = usuarios.SingleOrDefault(e => e.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }
    }
}