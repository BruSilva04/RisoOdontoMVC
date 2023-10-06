using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoBLL
{
    public static class Session
    {
        //usuario
        private static string _Nome;

        public static string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
    }
}
