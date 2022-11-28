using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    interface IProduct
    {
        public string GenerateQRCode();
        public string GetDiscount(double discountPercent);

        public string? GetShortName();
    }
}
