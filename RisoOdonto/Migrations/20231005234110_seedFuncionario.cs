using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RisoOdonto.Migrations
{
    /// <inheritdoc />
    public partial class seedFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Funcionario (Nome, Email, DataNascimento,Cargo,Login_Funcionario, Senha, TipoUsuarioId) VALUES ('Bernado','Teste@teste.com', '2003-03-02','Recepcionista','Bernado.filho','123456','1')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
