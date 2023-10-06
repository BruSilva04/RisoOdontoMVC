using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoDAL
{
	public class DentistaDAL:Conexao
	{
        //autenticacao
        public DentistaDTO Autenticar(string Login_Dentista, string senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Dentista WHERE Login_Dentista=@Login_Dentista AND Senha=@senha;", conn);
                cmd.Parameters.AddWithValue("@Login_Dentista", Login_Dentista);
                cmd.Parameters.AddWithValue("@senha", senha);
                dr = cmd.ExecuteReader();
                DentistaDTO obj = null;//ponteiro
                if (dr.Read())
                {
                    obj = new DentistaDTO();
                    obj.Nome = dr["Nome"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Dentista não cadastrado ! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }


        }

        //CRUD
        //Create
        public void Cadastrar(DentistaDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Dentista (Nome,Email,Login_Dentista,Senha,Especialidade) VALUES (@Nome,@Email,@Login_Dentista,@Senha,@Especialidade);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Login_Dentista", objCad.Login_Dentista);;
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
                cmd.Parameters.AddWithValue("@Especialidade", objCad.Especialidade);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        //Delete
        public void Excluir(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Dentista WHERE IdDentista = @IdDentista;", conn);
                cmd.Parameters.AddWithValue("@IdDentista", objDel);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Update
        public void Editar(DentistaDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Funcionario SET [Nome] = @nome,[Email]=@email,[Login_Dentista] = @Login_Dentista,[Seha]=@senha,[Especialidade] = @Especialidade WHERE IdDentista = @IdDentista;", conn);
                cmd.Parameters.AddWithValue("@nome", objEdita.Nome);
                cmd.Parameters.AddWithValue("@email", objEdita.Email);
                cmd.Parameters.AddWithValue("@Login_Dentista", objEdita.Login_Dentista);
                cmd.Parameters.AddWithValue("@senha", objEdita.Senha);
                cmd.Parameters.AddWithValue("@Especialidade", objEdita.Especialidade);
                cmd.Parameters.AddWithValue("@IdDentista", objEdita.IdDentista);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }


        //CarregaDDL
        public List<TipoUsuarioDTO> CarregaDDL()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM TipoUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<TipoUsuarioDTO> lista = new List<TipoUsuarioDTO>();
                while (dr.Read())
                {
                    TipoUsuarioDTO obj = new TipoUsuarioDTO();
                    obj.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
                    obj.DescricaoTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
                    lista.Add(obj);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
