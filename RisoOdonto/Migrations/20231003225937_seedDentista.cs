using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RisoOdonto.Migrations
{
    /// <inheritdoc />
    public partial class seedDentista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Dentista (Nome, Email, Login_Dentista, Senha,Especialidade) VALUES ('Fabio Neves Filho','fabio.odonto@gmail.com', 'fabio.filho','142536','Cirurgião')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
