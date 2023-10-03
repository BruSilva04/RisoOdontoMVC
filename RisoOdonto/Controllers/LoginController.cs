using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RisoOdonto.Models;
using System.Data.SqlClient;

namespace RisoOdonto.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "Server=tcp:risoodonto.database.windows.net,1433;Initial Catalog=RisoOdonto;Persist Security Info=False;User ID=adm;Password=Risoodonto10;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" ;
        }
        [HttpPost]
        public IActionResult Verifica(Paciente acc)
        {
            connectionString();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Paciente WHERE Email='"+acc.Email+"' AND Senha='"+acc.Senha+"' ";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
            
            
        }
    }
}
