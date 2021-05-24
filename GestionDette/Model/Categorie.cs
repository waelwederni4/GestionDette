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

    [Table("Categorie")]
    public partial class Categorie
    {
        public Categorie()
        {
            this.Produit = new HashSet<Produit>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDCategorie { get; set; }
        public string nomCategorie { get; set; }

        public virtual ICollection<Produit> Produit { get; set; }
    }
}
