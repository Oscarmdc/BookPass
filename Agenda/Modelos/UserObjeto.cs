using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Modelos
{
    public class UserObjeto
    {
        public int Id_user { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Email_m { get; set; }
        public string Password_m { get; set; }
        public string Username_m { get; set; }
        public string Phone_m { get; set; }
        public bool Habilitado { get; set; }

    }
}
