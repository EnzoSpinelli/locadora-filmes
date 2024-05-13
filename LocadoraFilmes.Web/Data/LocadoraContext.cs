
using LocadoraFilmes.Web.Models;
using System.Collections.Generic;
using System.Data.Entity;

public class LocadoraContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Locacao> Locacoes { get; set; }

    public LocadoraContext() : base("name=ConnectionStringHere") { }
}
