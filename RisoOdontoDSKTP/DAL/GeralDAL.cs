using RisoOdontoDSKTP.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoDSKTP.DAL
{
    public class GeralDAL:Conexao
    {
        public DentistaDTO Autenticar(string nome, string senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE NomeUsuario=@nome AND SenhaUsuario=@senha;", conn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                dr = cmd.ExecuteReader();
                DentistaDTO obj = null;//ponteiro
                if (dr.Read())
                {
                    obj = new DentistaDTO();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Senha = dr["SenhaUsuario"].ToString();
                    obj.Tp = dr["UsuarioTp"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Usuário não cadastrado ! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }


        }
    }
}
