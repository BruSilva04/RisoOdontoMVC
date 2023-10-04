using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RisoOdonto.Migrations
{
    /// <inheritdoc />
    public partial class seedAgendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Agendamento (Data_Consulta, Horario, Primeira_Consulta, Status_Consulta, PacienteId, DentistaId) VALUES ('2023-05-26','11:00:00', '1','Agendado','2', '1')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
