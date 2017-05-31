using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Persistance.EntityModel
{
    public partial class tbEnseignants
    {
        public tbEnseignants(string nom, string prenom) : this()
        {
            Nom = nom;
            Prenom = prenom;
            Titre = "Titre";
            Bio = "Bio";
            Rue = "Rue";
            Npa = "Npa";
            Localité = "Localité";
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }

        public string Localite { get { return Localité; } set { Localité = value; } }
    }
}
