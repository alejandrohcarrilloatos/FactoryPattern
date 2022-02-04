using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class User
    {
        public abstract string UserType { get; }
        public abstract int Id { get; set; }
        public abstract string UserName { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string ApellidoPaterno { get; set; }
        public abstract string ApellidoMaterno { get; set; }    }
}
