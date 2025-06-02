using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCodeFirstAPP
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    public class DbContext
    {
    }

    public class DbSet<T>
    {
    }
}
