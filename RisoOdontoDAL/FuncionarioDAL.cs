using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoDAL
{
	public class FuncionarioDAL:Conexao
	{
        //autenticacao
        public FuncionarioDTO Autenticar(string email, string senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Funcionario WHERE Login_Funcionario=@Login_Funcionario AND Senha=@senha;", conn);
                cmd.Parameters.AddWithValue("@Login_Funcionario", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                dr = cmd.ExecuteReader();
                FuncionarioDTO obj = null;//ponteiro
                if (dr.Read())
                {
                    obj = new FuncionarioDTO();
                    obj.Login_Funcionario = dr["Login_Funcionario"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.TipoUsuarioId = dr["TipoUsuarioId"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Funcionario não cadastrado ! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }


        }

        //CRUD
        //Create
        public void Cadastrar(FuncionarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Funcionario (Nome,Email,DataNascimento,Cargo,Login_Funcionario,Senha,TipoUsuarioId) VALUES (@Nome,@Email,@Data,@Cargo,@Login_Funcionario,@Senha,@TipoUsuarioId);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@DataNascimento", objCad.DataNascimento);
                cmd.Parameters.AddWithValue("@Cargo", objCad.Cargo);
                cmd.Parameters.AddWithValue("@Login_Funcionario", objCad.Login_Funcionario);
                cmd.Parameters.AddWithValue("@Senha", objCad.Senha);
                cmd.Parameters.AddWithValue("@TipoUsuarioId", objCad.TipoUsuarioId);
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
                cmd = new SqlCommand("DELETE FROM Funcionario WHERE IdFuncionario = @IdFuncionario;", conn);
                cmd.Parameters.AddWithValue("@IdFuncionario", objDel);
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
        public void Editar(FuncionarioDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Funcionario SET [Nome] = @nome,[Email]=@email,[DataNascimento] = @data,[Cargo] = @Cargo,[Login_Funcionario] = @Login_Funcionario,[Seha]=@senha,[TipoUsuarioId] = @TipoUsuarioId WHERE IdFuncionario = @IdFuncionario;", conn);
                cmd.Parameters.AddWithValue("@nome", objEdita.Nome);
                cmd.Parameters.AddWithValue("@email", objEdita.Email);
                cmd.Parameters.AddWithValue("@data", objEdita.DataNascimento);
                cmd.Parameters.AddWithValue("@Cargo", objEdita.Cargo);
                cmd.Parameters.AddWithValue("@Login_Funcionario", objEdita.Login_Funcionario);
                cmd.Parameters.AddWithValue("@senha", objEdita.Senha);
                cmd.Parameters.AddWithValue("@TipoUsuarioId", objEdita.TipoUsuarioId);
                cmd.Parameters.AddWithValue("@IdFuncionario", objEdita.IdFuncionario);
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
