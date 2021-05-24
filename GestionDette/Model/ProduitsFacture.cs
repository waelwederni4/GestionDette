using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class ProduitsFacture
    {
        public string nomProduit { get; set; }
        public Nullable<double> prixProduit { get; set; }
        public Nullable<int> QteProduit { get; set; }
        public Nullable<double> prixTotal { get; set; }

        public Nullable<DateTime> dateVente { get; set; }

    }
}
