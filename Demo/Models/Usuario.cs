using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Usuario
    {
      public  string nombres { get; set; }
      public string apellidos { get; set; }
        public Usuario()
        {

        }
        public Usuario(string nombres,string apellidos)
        {
            this.nombres = nombres;
        }
    }
}