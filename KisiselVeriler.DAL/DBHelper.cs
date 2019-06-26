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
        private static KisiselVerilerDBContext1 _dbContext;
        public static KisiselVerilerDBContext1 Context {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new KisiselVerilerDBContext1();
                }
                return _dbContext;
            }
        }

    }
}
