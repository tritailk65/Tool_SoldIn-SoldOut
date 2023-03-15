using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tool_SoldIn_SoldOut.DTO;
using Tool_SoldIn_SoldOut.DAO;

namespace Tool_SoldIn_SoldOut
{
    public partial class App : Form
    {
        public App()
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
            ReportCatDAO rpDao = new ReportCatDAO();
            List<ReportCatDTO> reportCats = rpDao.GetReportCatBySNum();
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
            SoldInOutDAO prodDao = new SoldInOutDAO();
            List<SoldInOutDTO> productDTOs = prodDao.GetProductByReportNum(reportNum);

            if (productDTOs != null)
            {
                for(int i = 0; i < productDTOs.Count; i++)
                {
                    dataGridView_product.Rows.Add(productDTOs[i].ProductID, 
                                                  productDTOs[i].Name,
                                                  productDTOs[i].ReportCat,
                                                  productDTOs[i].CurrentUnits,
                                                  productDTOs[i].VarianceUnits,
                                                  productDTOs[i].LastUnits);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close ?", "Close this app ?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ComboboxValueDTO tmpComboboxValue = (ComboboxValueDTO)cbx_rc.SelectedItem;
            int reportNo = tmpComboboxValue.ID;

            SoldInOutDAO sDao = new SoldInOutDAO();

            if (sDao.CheckTableSoldInOut())
            {
                sDao.CreateTableSoldInOut();    //Create table if it doesn't exsist
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to confirm ?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool FlagError = false;
                List<SoldInOutDTO> soldInOutDTOs = new List<SoldInOutDTO>();
                foreach (DataGridViewRow rw in dataGridView_product.Rows)
                {
                    if (rw.Cells[5].Value == null || rw.Cells[5].Value == DBNull.Value || string.IsNullOrWhiteSpace(rw.Cells[5].Value.ToString()) || !int.TryParse(rw.Cells[5].Value.ToString(), out int rs)) //Check if value is emty
                    {
                        FlagError = true;
                    }
                }
                if (FlagError)
                {
                    MessageBox.Show("Input is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else
                {
                    foreach (DataGridViewRow rw in dataGridView_product.Rows)
                    {
                        soldInOutDTOs.Add(new SoldInOutDTO(Convert.ToInt32(rw.Cells[0].Value), rw.Cells[1].Value.ToString(), reportNo, Convert.ToInt32(rw.Cells[3].Value), Convert.ToInt32(rw.Cells[4].Value), Convert.ToInt32(rw.Cells[5].Value)));
                    }

                    if(soldInOutDTOs.Count == dataGridView_product.Rows.Count)
                    {
                        bool confirm = sDao.InsertSoldInOut(soldInOutDTOs);

                        if (confirm)
                        {
                            MessageBox.Show("Confirm success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }
        }
    }
}
