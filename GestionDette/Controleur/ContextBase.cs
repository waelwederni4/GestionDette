using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Controleur
{
    public class ContextBase : DbContext
    {
        public ContextBase()
            : base("name=ContextBase")
        {
            
        }
        public void ClearID(string tableName,int index)
        { 
            this.Database.ExecuteSqlCommand("DBCC CHECKIDENT('"+tableName+"', RESEED,"+index+")");
        }
        public virtual DbSet<Client> Clients{ get; set; }
        public virtual DbSet<Magasin> Magasin { get; set; }
        public virtual DbSet<Lignevente> Ligneventes { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Vente> Ventes { get; set; }
        public virtual DbSet<RecuFacture> RecuFactures { get; set; }
        public virtual DbSet<Categorie> Categories { get; set; }

    }
}
