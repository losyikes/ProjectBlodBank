using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank.Business
{
    [Table(Name = "BloodBus")]
    class BloodBus
    {
        [Column]
        public string Location { get; set; }
        [Column]
        public DateTime Date { get; set; }
    }
}
