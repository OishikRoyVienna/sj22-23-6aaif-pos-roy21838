using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPG_Fachtheorie.Aufgabe1.Infrastructure
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
            : base(options)
        { }
    }
}
