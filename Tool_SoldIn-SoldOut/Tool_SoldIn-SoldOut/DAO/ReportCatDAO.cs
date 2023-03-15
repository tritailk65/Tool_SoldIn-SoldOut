using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tool_SoldIn_SoldOut.Code;
using Tool_SoldIn_SoldOut.DTO;

namespace Tool_SoldIn_SoldOut.DAO
{
    public class ReportCatDAO
    {
        public List<ReportCatDTO> GetReportCatBySNum()
        {
            try
            {
                string queryStoreInfo = @"SELECT * FROM DBA.REPORTCAT  where IsActive = 1 AND SNUM = 2047";
                DbConnect.getInstance().Open();

                OdbcCommand cmd = new OdbcCommand(queryStoreInfo, DbConnect.getInstance());
                OdbcDataReader reader = cmd.ExecuteReader();
                DataTable dtResult = new DataTable("ReportCat");
                dtResult.Load(reader);

                DbConnect.getInstance().Close();

                List<ReportCatDTO> rpList = new List<ReportCatDTO>();
                rpList = (from DataRow dr in dtResult.Rows
                          select new ReportCatDTO()
                          {
                              REPORTNO = Convert.ToInt32(dr["REPORTNO"]),
                              DESCRIPT = dr["DESCRIPT"].ToString()
                          }).ToList();
                return rpList;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
