using System;
using System.Collections.Generic;
using System.Text;

namespace CoderBro
{
    class Utility
    {
    }

    public enum DatabaseType { MDB, SQL };

    public class DatabaseInfo
    {
        public DatabaseType TypeOfDatabase;
        public string ConnectionStringOfDatabase;
    }

}
