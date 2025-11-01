using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBankSystem.Models;

namespace MvcBankSystem.Data
{
    public class MvcBankSystemContext : DbContext
    {
        public MvcBankSystemContext(DbContextOptions<MvcBankSystemContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBankSystem.Models.Account> Account { get; set; } = default!;
        public DbSet<MvcBankSystem.Models.Branch> Branch { get; set; } = default!;
        public DbSet<MvcBankSystem.Models.Card> Card { get; set; } = default!;
        public DbSet<MvcBankSystem.Models.Customer> Customer { get; set; } = default!;
        public DbSet<MvcBankSystem.Models.Transaction> Transaction { get; set; } = default!;
        public DbSet<MvcBankSystem.Models.User> User { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.DebtorAccount)
                .WithMany(a => a.DebitTransactions)
                .HasForeignKey(t => t.DebtorAccountId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.CreditorAccount)
                .WithMany(a => a.CreditTransactions)
                .HasForeignKey(t => t.CreditorAccountId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Account>()
                .HasOne(a => a.Customer)
                .WithMany()
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
