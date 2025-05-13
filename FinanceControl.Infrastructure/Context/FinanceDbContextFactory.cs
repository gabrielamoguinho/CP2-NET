using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;

namespace FinanceControl.Infrastructure.Context
{
    public class FinanceDbContextFactory : IDesignTimeDbContextFactory<FinanceDbContext>
    {
        public FinanceDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../FinanceControl.API"))
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            var optionsBuilder = new DbContextOptionsBuilder<FinanceDbContext>();
            optionsBuilder.UseOracle(connectionString); // UseSqlServer / UseNpgsql conforme o provedor

            return new FinanceDbContext(optionsBuilder.Options);
        }
    }
}
