using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Polymorfism
{
    public abstract class BaseDatabase
    {
        public abstract string Name { get; }
        public virtual bool NoSQL { get; } = false;
        public string? ConnectionString { get; set; }

    }
    public class SQLite : BaseDatabase
    {
        public override string Name { get; } = "SQLite";
    }

    public class MongoDB : BaseDatabase
    {
        public override string Name { get; } = "MongoDB";
        public override bool NoSQL { get; } = true;
    }
}
