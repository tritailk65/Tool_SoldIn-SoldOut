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
    class SoldInOutDAO
    {
        internal Boolean CheckTableSoldInOut()
        {
            try
            {
                string query = @"SELECT COUNT(1) FROM SYSOBJECTS WHERE NAME = 'SOLDINOUT' AND TYPE = 'U'";
                DbConnect.getInstance().Open();

                OdbcCommand cmd = new OdbcCommand(query, DbConnect.getInstance());

                if((int)cmd.ExecuteScalar() == 0)
                {
                    return true;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            finally
            {
                DbConnect.getInstance().Close();
            }
            return false;
        }

        internal void CreateTableSoldInOut()
        {
            try
            {
                string query = @"CREATE TABLE SOLDINOUT(
                                    SoldInOutNum INT IDENTITY PRIMARY KEY,
                                    ProdNum INT,
                                    ReportNo INT,
                                    CurrentUnits INT,
                                    VarianceUnits INT,
                                    LastUnits INT
                                )";
                DbConnect.getInstance().Open();
                OdbcCommand cmd = new OdbcCommand(query, DbConnect.getInstance());
                cmd.ExecuteNonQuery();              
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            finally
            {
                DbConnect.getInstance().Close();
            }
        }

        public List<SoldInOutDTO> GetProductByReportNum(int reportNum)
        {
            try
            {
                string queryProduct = @"SELECT P.DESCRIPT AS 'PROD_DESCRIPT', RC.DESCRIPT AS 'CAT_DESCRIPT',* 
                                        FROM DBA.Product P LEFT JOIN DBA.REPORTCAT RC ON P.ReportNO = RC.ReportNO 
                                        WHERE P.IsActive = 1 AND RC.SNUM = 2047 AND RC.ReportNO =" + reportNum;
                DbConnect.getInstance().Open();

                OdbcCommand cmd = new OdbcCommand(queryProduct, DbConnect.getInstance());
                OdbcDataReader reader = cmd.ExecuteReader();
                DataTable dtResult = new DataTable("Product");
                dtResult.Load(reader);

                DbConnect.getInstance().Close();

                List<SoldInOutDTO> productDTOs = new List<SoldInOutDTO>();
                productDTOs = (from DataRow dr in dtResult.Rows
                               select new SoldInOutDTO()
                               {
                                   ProductID = (int)dr["PRODNUM"],
                                   Name = dr["PROD_DESCRIPT"].ToString(),
                                   ReportCat = dr["CAT_DESCRIPT"].ToString(),
                                   ReportNo = reportNum,
                                   CurrentUnits = Convert.ToInt32(dr["COUNTDOWN"]),
                                   VarianceUnits = 0,
                                   LastUnits = 0
                               }).ToList();
                
                return productDTOs;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public Boolean InsertSoldInOut(List<SoldInOutDTO> soldInOutDTOs)
        {
            try
            {
                string query = @"INSERT INTO DBA.SOLDINOUT(ProdNum, ReportNo, CurrentUnits, VarianceUnits, LastUnits)
                                VALUES(?,?,?,?,?)";
                DbConnect.getInstance().Open();
                OdbcCommand cmd = new OdbcCommand(query, DbConnect.getInstance());
                for(int i = 0; i < soldInOutDTOs.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ProdNum", soldInOutDTOs[i].ProductID);
                    cmd.Parameters.AddWithValue("@ReportNo", soldInOutDTOs[i].ReportNo);
                    cmd.Parameters.AddWithValue("@CurrentUnits", soldInOutDTOs[i].CurrentUnits);
                    cmd.Parameters.AddWithValue("@VarianceUnits", soldInOutDTOs[i].VarianceUnits);
                    cmd.Parameters.AddWithValue("@LastUnits", soldInOutDTOs[i].LastUnits);
                    cmd.ExecuteNonQuery();
                }
                return true;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            finally
            {
                DbConnect.getInstance().Close();
            }
            return true;
        }
    }
}
