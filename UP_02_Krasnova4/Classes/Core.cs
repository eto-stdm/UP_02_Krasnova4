using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_02_Krasnova4
{
    internal class Core
    {
        public static DBEntities Context = new DBEntities();
        public static User CurrentUser;
    }
}
