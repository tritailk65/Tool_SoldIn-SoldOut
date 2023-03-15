using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tool_SoldIn_SoldOut.DTO
{
    class SoldInOutDTO
    {
        public SoldInOutDTO()
        {
        }

        public SoldInOutDTO(int productID, string name, int reportNo, int systemUnits, int variance, int currentUnits)
        {
            ProductID = productID;
            Name = name;
            ReportNo = reportNo;
            SystemUnits = systemUnits;
            Variance = variance;
            CurrentUnits = currentUnits;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ReportCat { get; set; }
        public int ReportNo { get; set; }
        public int SystemUnits { get; set; }
        public int Variance { get; set; }
        public int CurrentUnits { get; set; }

    }
}
