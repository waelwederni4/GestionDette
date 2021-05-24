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
    [Table("Vente")]
    public partial class Vente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDVente { get; set; }
        public Nullable<System.DateTime> dateVente { get; set; }
        public Nullable<int> IDClient { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<Lignevente> Lignevente { get; set; }

    }
}
