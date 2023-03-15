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
    internal class StoreInfoDAO
    {
        public List<StoreInfoDTO> GetStoreInfoDTOs()
        {
            try
            {
                string queryStoreInfo = @"SELECT * FROM DBA.StoreInfo where IsActive = 1 AND SNUM <> 2047";
                DbConnect.getInstance().Open();

                OdbcCommand cmd = new OdbcCommand(queryStoreInfo, DbConnect.getInstance());
                OdbcDataReader reader = cmd.ExecuteReader();
                DataTable dtResult = new DataTable("StoreInfo");
                dtResult.Load(reader);

                DbConnect.getInstance().Close();

                List<StoreInfoDTO> siList = new List<StoreInfoDTO>();
                siList = (from DataRow dr in dtResult.Rows
                          select new StoreInfoDTO()
                          {
                              SNUM = Convert.ToInt32(dr["SNUM"]),
                              DESCRIPTION = dr["DESCRIPTION"].ToString()
                          }).ToList();
                return siList;

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
