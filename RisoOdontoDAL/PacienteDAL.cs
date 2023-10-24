using RisoOdontoDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisoOdontoDAL
{
    public class PacienteDAL:Conexao
    {

        //autenticacao
        public PacienteDTO AutenticarCliente(string Email, string Senha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Paciente WHERE Email=@Email AND Senha=@Senha;", conn);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Senha", Senha);
                dr = cmd.ExecuteReader();
                PacienteDTO obj = null; //ponteiro
                if (dr.Read())
                {
                    obj = new PacienteDTO();
                    obj.Email = dr["Email"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.TipoUsuarioId = dr["TipoUsuarioId"].ToString();
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw new Exception($"Paciente não cadastrado ! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }


        }


        //CRUD
        //Create
        public void CadastrarCliente(PacienteDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Paciente (Nome,Email, Telefone, DataNascimento, CPF,Cidade, Endereco,Senha,TipoUsuarioId) VALUES (@Nome,@Email,@Telefone,@DataNascimento,@CPF,@Cidade,@Endereco,@Senha,@TipoUsuarioId);", conn);
                cmd.Parameters.AddWithValue("@Nome", objCad.Nome);
                cmd.Parameters.AddWithValue("@Email", objCad.Email);
                cmd.Parameters.AddWithValue("@Telefone", objCad.Telefone);
                cmd.Parameters.AddWithValue("@DataNascimento", objCad.DataNascimento);
                cmd.Parameters.AddWithValue("@CPF", objCad.CPF);
                cmd.Parameters.AddWithValue("@Cidade", objCad.Cidade);
                cmd.Parameters.AddWithValue("@Endereco", objCad.Endereco);
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

        //Read
        public List<PacienteDTO> ListarPaciente()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdPaciente,Nome,CPF,DataNascimento,Email,Senha,Telefone,Cidade,Endereco,DescricaoTipoUsuario  FROM Paciente INNER JOIN TipoUsuario ON IdTipoUsuario = TipoUsuarioId ORDER BY IdPaciente ASC;", conn);
                dr = cmd.ExecuteReader();
                List<PacienteDTO> lista = new List<PacienteDTO>();
                while (dr.Read())
                {
                    PacienteDTO obj = new PacienteDTO();
                    obj.IdPaciente = Convert.ToInt32(dr["IdPaciente"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Telefone = Convert.ToInt32(dr["Telefone"]);
                    obj.DataNascimento = Convert.ToDateTime(dr["DataNascimento"]);
                    obj.CPF = dr["CPF"].ToString();
                    obj.Cidade = dr["Cidade"].ToString();
                    obj.Endereco = dr["Endereco"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.TipoUsuarioId = dr["DescricaoTipoUsuario"].ToString();
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

        //Update
        public void EditarPaciente(PacienteDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Paciente SET [Nome] = @Nome,[CPF]=@CPF,[DataNascimento]=@DataNascimento,[Email]=@Email,[Senha]=@Senha,[Telefone]=@Telefone,[Cidade]=@Cidade,[Endereco] = @Endereco,[TipoUsuarioId] = @TipoUsuarioId WHERE IdPaciente = @id;", conn);
                cmd.Parameters.AddWithValue("@Nome", objEdita.Nome);
                cmd.Parameters.AddWithValue("@Email", objEdita.Email);
                cmd.Parameters.AddWithValue("@Telefone", objEdita.Telefone);
                cmd.Parameters.AddWithValue("@DataNascimento", objEdita.DataNascimento);
                cmd.Parameters.AddWithValue("@CPF", objEdita.CPF);
                cmd.Parameters.AddWithValue("@Cidade ", objEdita.Cidade);
                cmd.Parameters.AddWithValue("@Endereco", objEdita.Endereco);
                cmd.Parameters.AddWithValue("@Senha", objEdita.Senha);
                cmd.Parameters.AddWithValue("@TipoUsuarioId", objEdita.TipoUsuarioId);
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
        public void ExcluirPaciente(int objDel)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Paciente WHERE IdPaciente = @Id;", conn);
                cmd.Parameters.AddWithValue("@Id", objDel);
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

        //BuscaPorId
        public PacienteDTO BuscaPorId(int objId)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Paciente WHERE id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", objId);
                dr = cmd.ExecuteReader();
                PacienteDTO obj = null;
                if (dr.Read())
                {
                    obj = new PacienteDTO();
                    obj.IdPaciente = Convert.ToInt32(dr["id"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Telefone = Convert.ToInt32(dr["Telefone"]);
                    obj.DataNascimento = Convert.ToDateTime(dr["DataNascimento"]);
                    obj.CPF = dr["CPF"].ToString();
                    obj.Cidade = dr["Cidade"].ToString();
                    obj.Endereco = dr["Endereco"].ToString();
                    obj.Senha = dr["Senha"].ToString();
                    obj.TipoUsuarioId = dr["TipoUsuarioId"].ToString();
                }
                return obj;

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

        //BuscaPorNome
        public PacienteDTO BuscaPorNome(string objNome)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Paciente WHERE Nome = @nome;", conn);
                cmd.Parameters.AddWithValue("@nome", objNome);
                dr = cmd.ExecuteReader();
                PacienteDTO obj = null;
                if (dr.Read())
                {
                    obj = new PacienteDTO();
                    obj.IdPaciente = Convert.ToInt32(dr["IdUsuario"]);
                    obj.Nome = dr["Nome"].ToString();
                    obj.Email = dr["Email"].ToString();
                    obj.Telefone = Convert.ToInt32(dr["Telefone"]);
                    obj.DataNascimento = Convert.ToDateTime(dr["DataNascimento"]);
                    obj.CPF = dr["CPF"].ToString();
                    obj.Cidade = dr["Cidade"].ToString();
                    obj.Endereco = dr["Endereco"].ToString();
                    obj.Senha = dr["SenhaUsuario"].ToString();
                    obj.TipoUsuarioId = dr["TipoUsuarioId"].ToString();
                }
                return obj;

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
