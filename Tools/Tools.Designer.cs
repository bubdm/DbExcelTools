namespace Tools
{
    partial class Tools
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.outDbExcel = new System.Windows.Forms.Button();
            this.ColTxt = new System.Windows.Forms.TextBox();
            this.TblTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outExcel = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.sheet = new System.Windows.Forms.Button();
            this.fd = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            //
            // Tab
            //
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Font = new System.Drawing.Font("Meiryo UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1381, 861);
            this.Tab.TabIndex = 0;
            this.Tab.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.outDbExcel);
            this.tabPage1.Controls.Add(this.ColTxt);
            this.tabPage1.Controls.Add(this.TblTxt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Meiryo UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage1.Location = new System.Drawing.Point(8, 51);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1365, 802);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DB";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // panel1
            //
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Location = new System.Drawing.Point(23, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 648);
            this.panel1.TabIndex = 7;
            //
            // dgv1
            //
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Meiryo UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.RowTemplate.Height = 33;
            this.dgv1.Size = new System.Drawing.Size(1318, 648);
            this.dgv1.TabIndex = 6;
            //
            // outDbExcel
            //
            this.outDbExcel.Enabled = false;
            this.outDbExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outDbExcel.Location = new System.Drawing.Point(23, 81);
            this.outDbExcel.Name = "outDbExcel";
            this.outDbExcel.Size = new System.Drawing.Size(171, 45);
            this.outDbExcel.TabIndex = 5;
            this.outDbExcel.Text = "Excel出力";
            this.outDbExcel.UseVisualStyleBackColor = true;
            this.outDbExcel.Click += new System.EventHandler(this.outDbExcel_Click);
            //
            // ColTxt
            //
            this.ColTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ColTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ColTxt.Location = new System.Drawing.Point(779, 24);
            this.ColTxt.Name = "ColTxt";
            this.ColTxt.Size = new System.Drawing.Size(550, 34);
            this.ColTxt.TabIndex = 4;
            this.ColTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColTxt_KeyDown);
            //
            // TblTxt
            //
            this.TblTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TblTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TblTxt.Location = new System.Drawing.Point(123, 22);
            this.TblTxt.Name = "TblTxt";
            this.TblTxt.Size = new System.Drawing.Size(550, 34);
            this.TblTxt.TabIndex = 1;
            this.TblTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TblTxt_KeyDown);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(688, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "カラム名";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "テーブル名";
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.outExcel);
            this.tabPage2.Controls.Add(this.dgv2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.path);
            this.tabPage2.Controls.Add(this.sheet);
            this.tabPage2.Controls.Add(this.fd);
            this.tabPage2.Font = new System.Drawing.Font("Meiryo UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage2.Location = new System.Drawing.Point(8, 51);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1365, 802);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Excel";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // outExcel
            //
            this.outExcel.Enabled = false;
            this.outExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outExcel.Location = new System.Drawing.Point(374, 80);
            this.outExcel.Name = "outExcel";
            this.outExcel.Size = new System.Drawing.Size(171, 45);
            this.outExcel.TabIndex = 5;
            this.outExcel.Text = "Excel出力";
            this.outExcel.UseVisualStyleBackColor = true;
            this.outExcel.Click += new System.EventHandler(this.outExcel_Click);
            //
            // dgv2
            //
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv2.EnableHeadersVisualStyles = false;
            this.dgv2.Location = new System.Drawing.Point(3, 143);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv2.RowTemplate.Height = 33;
            this.dgv2.Size = new System.Drawing.Size(1359, 656);
            this.dgv2.TabIndex = 6;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "パス入力";
            //
            // path
            //
            this.path.Location = new System.Drawing.Point(145, 32);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(1193, 34);
            this.path.TabIndex = 2;
            //
            // sheet
            //
            this.sheet.Enabled = false;
            this.sheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sheet.Location = new System.Drawing.Point(197, 80);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(171, 45);
            this.sheet.TabIndex = 4;
            this.sheet.Text = "シート取得";
            this.sheet.UseVisualStyleBackColor = true;
            this.sheet.Click += new System.EventHandler(this.sheet_Click);
            //
            // fd
            //
            this.fd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fd.Location = new System.Drawing.Point(20, 79);
            this.fd.Name = "fd";
            this.fd.Size = new System.Drawing.Size(171, 47);
            this.fd.TabIndex = 3;
            this.fd.Text = "フォルダ選択";
            this.fd.UseVisualStyleBackColor = true;
            this.fd.Click += new System.EventHandler(this.fd_Click);
            //
            // Tools
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 861);
            this.Controls.Add(this.Tab);
            this.Name = "Tools";
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.Tools_Load);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button sheet;
        private System.Windows.Forms.Button fd;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button outExcel;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ColTxt;
        private System.Windows.Forms.TextBox TblTxt;
        private System.Windows.Forms.Button outDbExcel;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
    }
}

