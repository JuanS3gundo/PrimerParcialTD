using DAL.Contracts;
using DAL.Implementations.Memory;
using DAL.Implementations.SQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    public static class FactoryDao
    {
        private static int backendType;

        static FactoryDao()
        {
            backendType = int.Parse(ConfigurationManager.AppSettings["BackendType"]); ;
        }
        internal enum BackendType
        {
            Memory = 1,
            SqlServer = 2,
        }
        public static IMision MisionDao
        {
            get
            {
                switch ((BackendType)backendType)
                {
                    case BackendType.Memory:
                        return MisionMemory.Current;
                    case BackendType.SqlServer:
                        return MisionSqlServer.Current;
                    default:
                        throw new ArgumentException("Tipo de persistencia no soportado.");
                }
            }
        }
    }
}
