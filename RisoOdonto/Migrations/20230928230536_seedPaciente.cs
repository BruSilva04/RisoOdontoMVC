using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RisoOdonto.Migrations
{
    /// <inheritdoc />
    public partial class seedPaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Paciente (Nome, Email, Telefone, DataNascimento,CPF,Cidade,Endereco, Senha, TipoUsuarioId) VALUES ('Astolfo','Teste@teste.com', 1197968-2022, '2003-03-02', '23956314858', 'São Paulo','Rua Caldeira','123456','1')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
