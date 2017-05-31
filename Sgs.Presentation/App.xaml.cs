using Sgs.Persistance.EntityModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Sgs.Presentation
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static SGSEntities _DBContext;

        public static SGSEntities GetDBContext()
        {
            if (_DBContext == null) { _DBContext = new SGSEntities(); }
            return _DBContext;
        }

    }
}
