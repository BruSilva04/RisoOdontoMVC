using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RisoOdonto.Migrations
{
    /// <inheritdoc />
    public partial class seedTipoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TipoUsuario(DescricaoTipoUsuario) VALUES ('Administrador'), ('Paciente')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
