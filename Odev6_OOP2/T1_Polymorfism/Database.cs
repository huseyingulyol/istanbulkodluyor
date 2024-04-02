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

        public abstract void SendToDatabase();

    }
    public class SQLite : BaseDatabase
    {
        public override string Name { get; } = "SQLite";
        public string SQLVersion { get; set; }

        public string Id { get; set; } = "25255256367D";
        public override void SendToDatabase()
        {
            Console.WriteLine("Veriler SQLite'a aktarıldı!"  + Id);
        }

    }

    public class MongoDB : BaseDatabase
    {
        public override string Name { get; } = "MongoDB";
        public override bool NoSQL { get; } = true;
        public override void SendToDatabase()
        {
            Console.WriteLine("Veriler MongoDB'ye aktarıldı!");
        }
    }
}
