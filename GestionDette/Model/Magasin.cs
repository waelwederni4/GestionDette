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
    [Table("Magasin")]
    public partial class Magasin
    {
        public Magasin()
        {
            this.Client = new HashSet<Client>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDMagasin { get; set; }
        public Nullable<double> revenuTotal { get; set; }
        public Nullable<double> detteTotal { get; set; }
        public Nullable<int> nbClient { get; set; }
        public string nomMagasin { get; set; }

        public byte[] Image { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
