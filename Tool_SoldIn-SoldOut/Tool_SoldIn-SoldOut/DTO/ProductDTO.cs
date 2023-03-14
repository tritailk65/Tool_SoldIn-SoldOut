using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tool_SoldIn_SoldOut.DTO
{
    class ProductDTO
    {
        public ProductDTO()
        {
        }

        public ProductDTO(int productID, string name, string reportCat, int currentInventory, int importNum, int lastInvetory)
        {
            ProductID = productID;
            Name = name;
            ReportCat = reportCat;
            CurrentInventory = currentInventory;
            ImportNum = importNum;
            LastInvetory = lastInvetory;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ReportCat { get; set; }
        public int CurrentInventory { get; set; }
        public int ImportNum { get; set; }
        public int LastInvetory { get; set; }

    }
}
