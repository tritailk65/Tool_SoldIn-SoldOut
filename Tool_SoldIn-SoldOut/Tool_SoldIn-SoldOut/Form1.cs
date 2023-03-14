using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tool_SoldIn_SoldOut.DTO;
using Tool_SoldIn_SoldOut.DAO;
using Tool_SoldIn_SoldOut.Code;
using System.Data.Odbc;

namespace Tool_SoldIn_SoldOut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StoreInfoDAO siDao = new StoreInfoDAO();
            List<StoreInfoDTO> storeInfos = siDao.GetStoreInfoDTOs();
            if (storeInfos != null)
            {
                for (int i = 0; i < storeInfos.Count; i++)
                {
                    cbx_outlet.Items.Add(new ComboboxValueDTO( storeInfos[i].SNUM, storeInfos[i].DESCRIPTION));
                }
            }
        }

        private void cbx_outlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxValueDTO tmpComboboxValue = (ComboboxValueDTO)cbx_outlet.SelectedItem;
            int snum = tmpComboboxValue.ID;
            ReportCatDAO rpDao = new ReportCatDAO();
            List<ReportCatDTO> reportCats = rpDao.GetReportCatBySNum(snum);
            if(reportCats != null)
            {
                if (reportCats.Count == 0)
                {
                    cbx_rc.Text = "No item found";
                } else
                {
                    cbx_rc.Items.Clear();
                    cbx_rc.Text = "-- Select ReportCat -";
                    for (int i = 0; i < reportCats.Count; i++)
                    {
                        cbx_rc.Items.Add(new ComboboxValueDTO(reportCats[i].REPORTNO, reportCats[i].DESCRIPT));
                    }
                }
            }
        }

        private void cbx_rc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_product.Rows.Clear();
            dataGridView_product.Refresh();
            ComboboxValueDTO tmpComboboxValue = (ComboboxValueDTO)cbx_rc.SelectedItem;
            int reportNum = tmpComboboxValue.ID;
            ProductDAO prodDao = new ProductDAO();
            List<ProductDTO> productDTOs = prodDao.GetProductByReportNum(reportNum);

            if (productDTOs != null)
            {
                for(int i = 0; i < productDTOs.Count; i++)
                {
                    dataGridView_product.Rows.Add(productDTOs[i].ProductID, 
                                                  productDTOs[i].Name,
                                                  productDTOs[i].ReportCat,
                                                  productDTOs[i].CurrentInventory,
                                                  productDTOs[i].ImportNum,
                                                  productDTOs[i].LastInvetory);
                }
            }
        }
    }
}
