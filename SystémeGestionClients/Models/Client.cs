using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystémeGestionClients.Models
{
    public struct Adresse
    {
        public string rue;
        public string ville;
        public string pays;
        public Adresse(string rue, string ville, string pays)
        {
            this.rue = rue;
            this.ville = ville;
            this.pays = pays;
        }

    }

    public enum TypeC
    {
        Professionnel,
        Particulier
    }
    
    public class Client
    {
        public string ClientName { get; set; }
        public TypeC typeC { get; set; }
        public Adresse adresse  = new Adresse("20, Rue des orangers", "Ezzahra", "Ben Arous");


    }
}
