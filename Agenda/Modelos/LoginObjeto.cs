using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Modelos
{
    public class LoginObjeto
    {
        public int Id_login { get; set; }
        public int Id_usuario { get; set; }
        public int Id_correo { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Web { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Habilitado { get; set; }

    }
}
