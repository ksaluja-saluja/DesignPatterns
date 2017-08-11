using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public abstract class ConnectionManager
    {
        public string name { get; set; }
        public void Connect()
        {
            MakeConnectionString();
            BuildQueries();
            ProduceOutput();
        }
        protected void MakeConnectionString()
        {
            Console.WriteLine("Connection String Managed");
        }
        protected abstract void BuildQueries();
        

        protected void ProduceOutput()
        {
            Console.WriteLine("Output delivered!!");
        }
    }

    public class SqlServerConnectionManager:ConnectionManager
    {
        public SqlServerConnectionManager()
        {
            this.name = "SQL Server Manager";
        }

        protected override void BuildQueries()
        {
            Console.WriteLine(this.name + " has executed queries");
        }

    }

    public class OracleConnectionManager : ConnectionManager
    {
        public OracleConnectionManager()
        {
            this.name = "Oracle Manager";
        }

        protected override void BuildQueries()
        {
            Console.WriteLine(this.name + " has executed queries");
        }

    }

    class TemplateMethod
    {
    }
}
