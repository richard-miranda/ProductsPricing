using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsPricing.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
    }
}
