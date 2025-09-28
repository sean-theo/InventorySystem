using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();
        
        public static void AddProduct(Product product)
        {
        }
        public static bool RemoveProduct(int productID)
        {
            return false;
        }
        public static Product LookupProduct(int productID)
        {
            return null;
        }
        public static void UpdateProduct(int productID, Product product)
        {
        }
        public static void AddPart(Part part)
        {
        }
        public static bool DeletePart(Part part)
        {
            return false;
        }
        public static Part LookUpPart(int PartID)
        {
            return null;
        }
        public static void UpdatePart(int partID, Part part)
        {
        }

    }
}
