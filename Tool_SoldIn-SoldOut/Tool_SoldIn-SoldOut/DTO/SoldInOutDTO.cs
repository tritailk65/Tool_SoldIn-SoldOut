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

        public SoldInOutDTO(int productID, string name, int reportNo, int currentUnits, int varianceUnits, int lastUnits)
        {
            ProductID = productID;
            Name = name;
            ReportNo = reportNo;
            CurrentUnits = currentUnits;
            VarianceUnits = varianceUnits;
            LastUnits = lastUnits;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ReportCat { get; set; }
        public int ReportNo { get; set; }
        public int CurrentUnits { get; set; }
        public int VarianceUnits { get; set; }
        public int LastUnits { get; set; }

    }
}
