
using System.Drawing;

namespace Tool_SoldIn_SoldOut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.cbx_rc = new System.Windows.Forms.ComboBox();
            this.cbx_outlet = new System.Windows.Forms.ComboBox();
            this.label_rc = new System.Windows.Forms.Label();
            this.label_outlet = new System.Windows.Forms.Label();
            this.prodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentInven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastInven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(86)))), ((int)(((byte)(134)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.cbx_rc);
            this.panel1.Controls.Add(this.cbx_outlet);
            this.panel1.Controls.Add(this.label_rc);
            this.panel1.Controls.Add(this.label_outlet);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 680);
            this.panel1.TabIndex = 0;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(227)))));
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(11)))));
            this.btn_confirm.Location = new System.Drawing.Point(950, 607);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(268, 49);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "CONFIRM";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.AllowUserToAddRows = false;
            this.dataGridView_product.AllowUserToDeleteRows = false;
            this.dataGridView_product.AllowUserToResizeColumns = false;
            this.dataGridView_product.AllowUserToResizeRows = false;
            this.dataGridView_product.ColumnHeadersHeight = 29;
            this.dataGridView_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodId,
            this.name,
            this.rpCat,
            this.currentInven,
            this.importNum,
            this.lastInven});
            this.dataGridView_product.Location = new System.Drawing.Point(29, 151);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersWidth = 51;
            this.dataGridView_product.RowTemplate.Height = 24;
            this.dataGridView_product.Size = new System.Drawing.Size(1189, 433);
            this.dataGridView_product.TabIndex = 4;
            // 
            // cbx_rc
            // 
            this.cbx_rc.FormattingEnabled = true;
            this.cbx_rc.Location = new System.Drawing.Point(194, 82);
            this.cbx_rc.Name = "cbx_rc";
            this.cbx_rc.Size = new System.Drawing.Size(569, 33);
            this.cbx_rc.TabIndex = 3;
            this.cbx_rc.Text = "-- Select ReportCat --";
            this.cbx_rc.SelectedIndexChanged += new System.EventHandler(this.cbx_rc_SelectedIndexChanged);
            // 
            // cbx_outlet
            // 
            this.cbx_outlet.FormattingEnabled = true;
            this.cbx_outlet.Location = new System.Drawing.Point(194, 27);
            this.cbx_outlet.Name = "cbx_outlet";
            this.cbx_outlet.Size = new System.Drawing.Size(569, 33);
            this.cbx_outlet.TabIndex = 2;
            this.cbx_outlet.Text = "-- Select Outlet --";
            this.cbx_outlet.SelectedIndexChanged += new System.EventHandler(this.cbx_outlet_SelectedIndexChanged);
            // 
            // label_rc
            // 
            this.label_rc.AutoSize = true;
            this.label_rc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rc.ForeColor = System.Drawing.Color.White;
            this.label_rc.Location = new System.Drawing.Point(35, 82);
            this.label_rc.Name = "label_rc";
            this.label_rc.Size = new System.Drawing.Size(138, 29);
            this.label_rc.TabIndex = 1;
            this.label_rc.Text = "ReportCat:";
            // 
            // label_outlet
            // 
            this.label_outlet.AutoSize = true;
            this.label_outlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_outlet.ForeColor = System.Drawing.Color.White;
            this.label_outlet.Location = new System.Drawing.Point(35, 27);
            this.label_outlet.Name = "label_outlet";
            this.label_outlet.Size = new System.Drawing.Size(90, 29);
            this.label_outlet.TabIndex = 0;
            this.label_outlet.Text = "Outlet:";
            // 
            // prodId
            // 
            this.prodId.HeaderText = "ProductID";
            this.prodId.MinimumWidth = 6;
            this.prodId.Name = "prodId";
            this.prodId.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 270;
            // 
            // rpCat
            // 
            this.rpCat.HeaderText = "ReportCat";
            this.rpCat.MinimumWidth = 6;
            this.rpCat.Name = "rpCat";
            this.rpCat.Width = 235;
            // 
            // currentInven
            // 
            this.currentInven.HeaderText = "Tồn hiện tại";
            this.currentInven.MinimumWidth = 6;
            this.currentInven.Name = "currentInven";
            this.currentInven.Width = 160;
            // 
            // importNum
            // 
            this.importNum.HeaderText = "Nhập thêm";
            this.importNum.MinimumWidth = 6;
            this.importNum.Name = "importNum";
            this.importNum.Width = 160;
            // 
            // lastInven
            // 
            this.lastInven.HeaderText = "Tồn cuối";
            this.lastInven.MinimumWidth = 6;
            this.lastInven.Name = "lastInven";
            this.lastInven.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1258, 690);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sold In - Sold Out";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_outlet;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.ComboBox cbx_rc;
        private System.Windows.Forms.ComboBox cbx_outlet;
        private System.Windows.Forms.Label label_rc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rpCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentInven;
        private System.Windows.Forms.DataGridViewTextBoxColumn importNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastInven;
    }
}

