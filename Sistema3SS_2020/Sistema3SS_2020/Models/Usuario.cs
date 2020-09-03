using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Usuario
    {
        private  Usuario_repositorio usuario_Repositorio = new Usuario_repositorio();
        [Required]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno{ get; set; }
        [Required]
        public string contrasena { get; set; }
        [Required]
        public int id_tipo { get; set; }
        public string correo_electronico { get; set; }
        public string numero_celular { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        [Required]
        public bool activo { get; set; }

        public bool Iniciar_sesion(string nombre, string contrasena) 
        {
            
            Usuario usu = usuario_Repositorio.ConsultarPorNombre(nombre);
            
            if (usu != null)
            {
                if (usu.contrasena.Trim() == contrasena)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public List<Usuario> MostrarLista() 
        {
          var list = usuario_Repositorio.MostarLista();
            return list;
        }
        public Usuario ConsultarInfoPorId(int id)
        {
          var r = usuario_Repositorio.ConsultarPorId(id);
            if (r != null)
            {
                return r;
            }
            else
            {
                return null;
            }
        }
        public bool actualizar(Usuario usuario)
        {
            var res = usuario_Repositorio.Actualizar(usuario,this.id);
            return res;
        }
        public bool Insertar(Usuario usuario) 
        {
           var res = usuario_Repositorio.Insertar(usuario);
            return res;
        }

    }
}
