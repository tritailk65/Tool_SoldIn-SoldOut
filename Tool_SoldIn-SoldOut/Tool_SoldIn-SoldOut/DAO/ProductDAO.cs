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
    class ProductDAO
    {
        public List<ProductDTO> GetProductByReportNum(int reportNum)
        {
            try
            {
                Console.WriteLine(reportNum);
                string queryProduct = @"SELECT P.PRODNUM,P.DESCRIPT AS 'PROD_DESCRIPT', P.DESCRIPT, P.REPORTNO, R.DESCRIPT AS 'CAT_DESCRIPT'
                                        FROM DBA.Product P, DBA.ReportCat R
                                        WHERE P.REPORTNO = R.REPORTNO AND P.ReportNo =" + reportNum;
                DbConnect.getInstance().Open();

                OdbcCommand cmd = new OdbcCommand(queryProduct, DbConnect.getInstance());
                OdbcDataReader reader = cmd.ExecuteReader();
                DataTable dtResult = new DataTable("Product");
                dtResult.Load(reader);

                DbConnect.getInstance().Close();

                List<ProductDTO> productDTOs = new List<ProductDTO>();
                productDTOs = (from DataRow dr in dtResult.Rows
                               select new ProductDTO()
                               {
                                   ProductID = (int)dr["PRODNUM"],
                                   Name = dr["PROD_DESCRIPT"].ToString(),
                                   ReportCat = dr["CAT_DESCRIPT"].ToString(),
                                   CurrentInventory = 0,
                                   ImportNum = 0,
                                   LastInvetory = 0
                               }).ToList();
                
                return productDTOs;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
