using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_exam
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class EFContext : DbContext
    {
        public EFContext() : base("server=server-bpt; user=sa; port=3306; password=Qw123456; database=110")
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Database.CreateIfNotExists();
        }
    }
}
