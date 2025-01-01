using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.DBLayer
{
    public class DBHelper
    {
        public static AppUser CurrentUser { get; set; }
        public static bool Login(string username, string password)
        {
            SPEntities entities = new SPEntities();
            CurrentUser = entities.AppUser.FirstOrDefault(s => s.UserName == username && s.Password == password);
           
            if (CurrentUser == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static Product GetProductByBarcode(string barcode)
        {
            SPEntities entities = new SPEntities();
            var product = entities.Product.FirstOrDefault(s => s.Barcode == barcode);

            return product;
        }

        public static ProductCategory[] GetProductCategory()
        {
            SPEntities entities = new SPEntities();

            return entities.ProductCategory.ToArray();

        }

    }
}
