using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RisoOdonto.Models;

namespace RisoOdonto.Data
{
    public class RisoOdontoContext : DbContext
    {
        public RisoOdontoContext (DbContextOptions<RisoOdontoContext> options)
            : base(options)
        {
        }

        public DbSet<RisoOdonto.Models.Paciente> Paciente { get; set; } = default!;

        public DbSet<RisoOdonto.Models.Dentista>? Dentista { get; set; }

        public DbSet<RisoOdonto.Models.Agendamento>? Agendamento { get; set; }

        public DbSet<RisoOdonto.Models.Funcionario>? Funcionario { get; set; }
    }
}
