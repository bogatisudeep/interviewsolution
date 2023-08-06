using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }

        public override string ToString()
        {
            string str = string.Empty;
            str += "Receipt:\n\tItems:";
            foreach (var item in Items) { 
                str += "\n\t\t"+item.Name +"\n\t\t";
                str += item.Quantity + "\t" + item.UnitPrice + "\t" + (item.UnitPrice * item.Quantity + item.TaxAmount).ToString("N2");
            }
            str += "\n\tTotal:" + this.Total.ToString("N2") + "\n\tGST:" + this.TaxTotal.ToString("N2");
            return str;
        }
    }
}
