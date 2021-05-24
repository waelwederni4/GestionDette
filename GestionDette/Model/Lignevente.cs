using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    [Table("Lignevente")]
    public partial class Lignevente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDLignevente { get; set; }
        public Nullable<int> IDProduit { get; set; }
        public Nullable<int> IDVente { get; set; }
        public Nullable<int> QteProduit { get; set; }
        public Nullable<double> prixTotal { get; set; }

        public virtual Produit Produit { get; set; }
        public virtual Vente Vente { get; set; }

    }
}
