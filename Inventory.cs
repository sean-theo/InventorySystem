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
            Products.Add(product);
        }

        public static bool RemoveProduct(int productID)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }

        public static Product LookupProduct(int productID)
        {
            return Products.FirstOrDefault(p => p.ProductID == productID);
        }

        public static void UpdateProduct(int productID, Product product)
        {
           
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            foreach (var product in Products)
            {
                foreach (var associatedPart in product.AssociatedParts)
                {
                    if (associatedPart == part)
                    {
                        return false;
                    }
                }
            }
            return AllParts.Remove(part);
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
