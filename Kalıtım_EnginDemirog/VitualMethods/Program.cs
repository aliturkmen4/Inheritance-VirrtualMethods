using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlserver = new SqlServer();
            sqlserver.Add();
            MySql mysql = new MySql();
            mysql.Add();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add() 
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }
    class MySql : Database
    {

    }
}
