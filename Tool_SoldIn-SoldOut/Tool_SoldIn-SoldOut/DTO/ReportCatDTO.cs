using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tool_SoldIn_SoldOut.DTO
{
    public class ReportCatDTO
    {
        public int UpdateStatus { get; set; }
        public double Tax5Quan { get; set; }
        public double Tax4Quan { get; set; }
        public double Tax3Quan { get; set; }
        public double Tax2Quan { get; set; }
        public double Tax1Quan { get; set; }
        public int TAX1 { get; set;}
        public int SUMMARYNUM { get; set; }
        public int SNUM { get; set; }
        public string SCHEDULE { get; set; }
        public int RevCenter { get; set; }
        public int REPORTNO { get; set; }
        public int REPGROUP { get; set; }
        public int PrintPriority { get; set; }
        public double PRINTLOC { get; set; }
        public string PLink { get; set; }
        public int MODIFYSCR5 { get; set; }
        public int MODIFYSCR4 { get; set; }
        public int MODIFYSCR3 { get; set; }
        public int MODIFYSCR2 { get; set; }
        public int MODIFYSCR1 { get; set; }
        public int LASTUPDATE { get; set; }
        public int LASTSTORE { get; set; }
        public int ISACTIVE { get; set; }
        public string HoRepGroups { get; set; }
        public string DESCRIPT { get; set; }
        public int ConfigNum { get; set; }
    }
}
