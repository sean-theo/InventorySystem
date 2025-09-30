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
        private static int productCounter = 1;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public Product()
        {
            ProductID = productCounter;
            productCounter++;
        }

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
