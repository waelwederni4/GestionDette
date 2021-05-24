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

    [Table("Client")]
    public partial class Client
    {
        public Client()
        {
            this.Vente = new HashSet<Vente>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IDClient { get; set; }
        public string nomClient { get; set; }
        public string prenomClient { get; set; }
        public string adresseClient { get; set; }
        public string numTelClient { get; set; }
        public Nullable<double> detteClient { get; set; }
        public Nullable<int> IDMagasin { get; set; }

        public virtual Magasin Magasin { get; set; }
        public virtual ICollection<Vente> Vente { get; set; }
    }
}
