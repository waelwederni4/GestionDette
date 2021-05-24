using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    [Table("Produit")]
    public partial class Produit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDProduit { get; set; }
        public string nomProduit { get; set; }
        public Nullable<double> prixProduit { get; set; }
        public Nullable<int> IDCategorie { get; set; }
        public string StrCategorie { get; set; }
        public byte[] Image { get; set; }
        public virtual Categorie Categorie { get; set; }
        public virtual ICollection<Lignevente> Lignevente { get; set; }

    }
}
