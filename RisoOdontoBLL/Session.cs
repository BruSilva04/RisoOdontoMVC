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
        private static string _Login_Funcionario;

        public static string Login_Funcionario
        {
            get { return _Login_Funcionario; }
            set { _Login_Funcionario = value; }
        }
    }
}
