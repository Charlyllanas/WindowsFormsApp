using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public long? Tipo { get; set; }
        public string Password { get; set; }
        public string Matricula { get; set; }
    }
}
