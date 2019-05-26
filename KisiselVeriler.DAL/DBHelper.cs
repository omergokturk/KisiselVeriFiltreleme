using KisiselVeriler.DAL.KisiselVerilerDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DAL
{
    class DBHelper
    {
        private DBHelper() { }
        private static KisiselVerilerDBContext _dbContext;
        public static KisiselVerilerDBContext Context {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new KisiselVerilerDBContext();
                }
                return _dbContext;
            }
        }

    }
}
