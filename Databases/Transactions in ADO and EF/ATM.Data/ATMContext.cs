using ATM.Model;
using ATM.Data.Migrations;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Data
{
    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("AtmDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());
        }

        public DbSet<CardAccounts> CardAccounts { get; set; }

        public DbSet<TransactionsHistory> TransactionsHistory { get; set; }
    }
}
