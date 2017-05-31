using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Persistance.EntityModel
{
    public partial class tbSessions
    {

        public int Duree {
            get
            {
                

                var x = (DateFinCours - DateDebutCours).Days;

                return x;

    }
}
        public int DureeEcoulee
        {
            get
            {
                return (DateTime.Now - DateDebutCours).Days;
            }
        }



    }
}
