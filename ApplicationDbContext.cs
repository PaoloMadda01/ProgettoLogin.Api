﻿using Microsoft.EntityFrameworkCore;
using ProgettoLogin.Models;

namespace ProgettoLogin.Api;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    //Metodo per leggere dal database e inviare i dati alla classe
    {

    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountXSite> AccountXSites { get; set; }
    public DbSet<Site> Sites { get; set; }

}
