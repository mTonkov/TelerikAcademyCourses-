using BugLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugLogger.Data.Contracts
{
    public interface IBugLoggerData
    {
        IRepository<Bug> Bugs { get; }

        void SaveChanges();

    }
}
