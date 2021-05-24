using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RecuFacture")]
    public partial class RecuFacture
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idFacture { get; set; }
        public Nullable<int> IDVente { get; set; }
        public Nullable<double> Totale { get; set; }
        public virtual Vente Vente { get; set; }
    }
}
