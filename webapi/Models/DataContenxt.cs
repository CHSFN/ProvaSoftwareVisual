using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace API.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Funcionario> Funcionarios  { get; set; }
        public DbSet<FolhaPagamento> FolhaPagamentos  { get; set; }
    }
}