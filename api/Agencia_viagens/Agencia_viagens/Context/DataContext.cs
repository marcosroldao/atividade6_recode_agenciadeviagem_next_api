
using Agencia_viagens.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;


namespace Agencia_viagens.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
            var culture = CultureInfo.InvariantCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

        }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Passagem> Passagem { get; set; }

        public DbSet<Reserva> Reserva { get; set; }

    }


}