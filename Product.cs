using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Product
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();


        public void AddAssociatedPart(Part part)
        {
        }
        public bool RemoveAssociatedPart(int partID)
        {
            return false;
        }
        public Part LookupAssociatedPart(int partID)
        {
            return null;
        }
    }
}
