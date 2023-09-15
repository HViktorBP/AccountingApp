namespace AccountingApp.View
{
    partial class WorkersData
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            accountingDALBindingSource = new BindingSource(components);
            DataGrid = new DataGridView();
            UsersDataPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)accountingDALBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            UsersDataPanel.SuspendLayout();
            SuspendLayout();
            // 
            // accountingDALBindingSource
            // 
            accountingDALBindingSource.DataSource = typeof(DAL.AccountingDAL);
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGrid.BackgroundColor = Color.FromArgb(135, 187, 162);
            DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(135, 187, 162);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(135, 187, 162);
            dataGridViewCellStyle4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(59, 96, 100);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(135, 187, 162);
            dataGridViewCellStyle4.SelectionForeColor = Color.Wheat;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            DataGrid.GridColor = Color.FromArgb(135, 187, 162);
            DataGrid.Location = new Point(0, 0);
            DataGrid.Margin = new Padding(3, 4, 3, 4);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowHeadersWidth = 51;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.Size = new Size(893, 600);
            DataGrid.TabIndex = 0;
            // 
            // UsersDataPanel
            // 
            UsersDataPanel.BackColor = Color.FromArgb(135, 187, 162);
            UsersDataPanel.Controls.Add(DataGrid);
            UsersDataPanel.Dock = DockStyle.Fill;
            UsersDataPanel.Location = new Point(0, 0);
            UsersDataPanel.Margin = new Padding(3, 4, 3, 4);
            UsersDataPanel.Name = "UsersDataPanel";
            UsersDataPanel.Size = new Size(893, 600);
            UsersDataPanel.TabIndex = 0;
            // 
            // WorkersData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 600);
            Controls.Add(UsersDataPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "WorkersData";
            Text = "Workers data";
            Load += UsersData_Load;
            ((System.ComponentModel.ISupportInitialize)accountingDALBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            UsersDataPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource accountingDALBindingSource;
        private DataGridView DataGrid;
        private Panel UsersDataPanel;
    }
}