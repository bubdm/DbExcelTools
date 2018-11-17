using ClosedXML.Excel;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tools
{
    public partial class Tools : Form
    {
        private string folderPath = string.Empty;

        private DataTable dbDt = new DataTable();

        private string fileName = string.Empty;

        public Tools()
        {
            InitializeComponent();
        }

        private void fd_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                Description = "フォルダ選択",
                ShowNewFolderButton = false
            };

            var dr = fbd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                folderPath = fbd.SelectedPath;
                path.Text = folderPath;
                if (folderPath != string.Empty && Directory.Exists(folderPath))
                {
                    var fileList = Directory.GetFiles(folderPath, "*.xlsx", SearchOption.AllDirectories);
                    if (fileList.Length == 0)
                    {
                        MessageBox.Show("指定したフォルダが存在しないか、\r\nまたは指定したフォルダ内にExcelファイルが存在しない");
                    }
                    else
                    {
                        sheet.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("指定したフォルダが存在しないか、\r\nまたは指定したフォルダ内にExcelファイルが存在しない");
                }
            }
        }

        private void sheet_Click(object sender, EventArgs e)
        {
            if (folderPath != string.Empty && Directory.Exists(folderPath))
            {
                var fileList = Directory.GetFiles(folderPath, "*.xlsx", SearchOption.AllDirectories);
                if (fileList.Length > 0)
                {
                    var dt = new DataTable();
                    var excelInfos = new List<ExcelInfo>();
                    fileList.ToList().ForEach(x =>
                    {
                        var excelInfo = new ExcelInfo
                        {
                            FileName = x
                        };
                        var wb = new XLWorkbook(x);
                        var sheetsName = new List<string>();
                        wb.Worksheets.ToList().ForEach(y => sheetsName.Add(y.Name));
                        excelInfo.SheetNames = sheetsName;
                        excelInfos.Add(excelInfo);
                    });

                    dt.Columns.Add("ファイル名");
                    var sheetMax = excelInfos.Select(x => x.SheetNames).ToList().Max(y => y.Count);
                    for (var idx = 1; idx <= sheetMax; idx++)
                    {
                        dt.Columns.Add("シート" + idx.ToString());
                    }

                    excelInfos.ForEach(x =>
                    {
                        var rows = x.SheetNames.ToList();
                        rows.Insert(0, x.FileName);
                        var nowRows = rows.Count;
                        for (var idx = 0; idx < sheetMax + 1 - nowRows; idx++)
                        {
                            rows.Add(string.Empty);
                        }
                        dt.Rows.Add(rows.ToArray());
                    });
                    dgv2.DataSource = dt;
                    dgv2.Columns[1].Frozen = true;
                    outExcel.Enabled = true;
                }
                else
                {
                    MessageBox.Show("指定したフォルダが存在しないか、\r\nまたは指定したフォルダ内にExcelファイルが存在しない");
                }
            }
            else
            {
                MessageBox.Show("指定したフォルダが存在しないか、\r\nまたは指定したフォルダ内にExcelファイルが存在しない");
            }
        }

        private void outExcel_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 0,
                RestoreDirectory = true,
                Title = "ファイル保存",
                FileName = "シート取得結果" + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != string.Empty && Directory.Exists(Path.GetDirectoryName(sfd.FileName)))
                {
                    using (var wb = new XLWorkbook())
                    {
                        var worksheet = wb.Worksheets.Add("結果");
                        worksheet.Cell("B2").InsertTable(((DataTable)dgv2.DataSource).Copy());
                        worksheet.RowsUsed().AdjustToContents();
                        worksheet.ColumnsUsed().AdjustToContents();
                        worksheet.Style.Font.FontName = "Meiryo UI";
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show(String.Concat("Excelファイル出力完了しました。\r\n\r\n【", sfd.FileName, "】"));
                    }
                }
                else
                {
                    MessageBox.Show("ファイルを入力してください。");
                }
            }
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    InitData();
                    break;

                case 1:
                    break;
            }
        }

        private void InitData()
        {
            using (OracleConnection oc = new OracleConnection())
            {
                try
                {
                    oc.ConnectionString = "User ID=" + ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["User"].Value + "; Password=" + ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["Password"].Value + "; Data Source=OracleDataSource;";
                    oc.Open();
                    var sql = "SELECT TABLES.TABLE_NAME AS TBL_PHYSICAL_NAME, TAB_COMMENTS.COMMENTS AS TBL_LOGICAL_NAME, COL_COMMENTS.COLUMN_NAME AS COL_PHYSICAL_NAME, COL_COMMENTS.COMMENTS AS COL_LOGICAL_NAME, COLUMNS.DATA_TYPE, COLUMNS.DATA_LENGTH, COLUMNS.DATA_PRECISION, COLUMNS.DATA_SCALE, COLUMNS.NULLABLE, COLUMNS.DATA_DEFAULT, COLUMNS.COLUMN_ID FROM USER_TAB_COLUMNS COLUMNS INNER JOIN USER_TABLES TABLES ON COLUMNS.TABLE_NAME = TABLES.TABLE_NAME INNER JOIN USER_TAB_COMMENTS TAB_COMMENTS ON COLUMNS.TABLE_NAME = TAB_COMMENTS.TABLE_NAME INNER JOIN USER_COL_COMMENTS COL_COMMENTS ON COLUMNS.TABLE_NAME = COL_COMMENTS.TABLE_NAME AND COLUMNS.COLUMN_NAME = COL_COMMENTS.COLUMN_NAME ORDER BY TABLES.TABLE_NAME, COLUMNS.COLUMN_ID";
                    var cmd = new OracleCommand(sql, oc);
                    var da = new OracleDataAdapter(cmd);
                    dbDt = new DataTable();
                    da.Fill(dbDt);
                    var tables = "'" + string.Join("','", dbDt.AsEnumerable().Select(x => x.Field<string>("TBL_PHYSICAL_NAME")).ToArray().Distinct()) + "'";
                    sql = "SELECT COLS.TABLE_NAME AS TBL_PHYSICAL_NAME, COLS.COLUMN_NAME AS COL_PHYSICAL_NAME FROM ALL_CONSTRAINTS CONS, ALL_CONS_COLUMNS COLS WHERE CONS.CONSTRAINT_TYPE = 'P' AND COLS.TABLE_NAME IN(" + tables + ") AND CONS.CONSTRAINT_NAME = COLS.CONSTRAINT_NAME ORDER BY COLS.POSITION";
                    cmd = new OracleCommand(sql, oc);
                    da = new OracleDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);

                    dbDt.Columns.Add("PK", typeof(string));
                    dbDt.Columns["PK"].SetOrdinal(4);
                    dt.AsEnumerable().ToList().ForEach(
                        x =>
                        {
                            dbDt.AsEnumerable().Where(y => y.Field<string>("TBL_PHYSICAL_NAME").Equals(x.Field<string>("TBL_PHYSICAL_NAME")) && y.Field<string>("COL_PHYSICAL_NAME").Equals(x.Field<string>("COL_PHYSICAL_NAME"))).FirstOrDefault().SetField<string>("PK", "●");
                        }
                    );

                    var tblTxtAutoCompList = new AutoCompleteStringCollection();
                    tblTxtAutoCompList.AddRange(dbDt.AsEnumerable().Select(x => x.Field<string>("TBL_PHYSICAL_NAME")).ToList().Union(dbDt.AsEnumerable().Select(x => x.Field<string>("TBL_LOGICAL_NAME")).ToList()).ToArray());
                    TblTxt.AutoCompleteCustomSource = tblTxtAutoCompList;

                    var colTxtAutoCompList = new AutoCompleteStringCollection();
                    colTxtAutoCompList.AddRange(dbDt.AsEnumerable().Select(x => x.Field<string>("COL_PHYSICAL_NAME")).ToList().Union(dbDt.AsEnumerable().Select(x => x.Field<string>("COL_LOGICAL_NAME")).ToList()).ToArray());
                    ColTxt.AutoCompleteCustomSource = colTxtAutoCompList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Tools_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void outDbExcel_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 0,
                RestoreDirectory = true,
                Title = "ファイル保存",
                FileName = fileName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName != string.Empty && Directory.Exists(Path.GetDirectoryName(sfd.FileName)))
                {
                    using (var wb = new XLWorkbook())
                    {
                        var worksheet = wb.Worksheets.Add(fileName);
                        worksheet.Cell("B2").InsertTable(((DataTable)dgv1.DataSource).Copy());
                        worksheet.RowsUsed().AdjustToContents();
                        worksheet.ColumnsUsed().AdjustToContents();
                        worksheet.Style.Font.FontName = "Meiryo UI";
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show(String.Concat("Excelファイル出力完了しました。\r\n\r\n【", sfd.FileName, "】"));
                    }
                }
                else
                {
                    MessageBox.Show("ファイルを入力してください。");
                }
            }
        }

        private void TblTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var inputTbl = TblTxt.Text.ToUpper();
                fileName = inputTbl;
                if (TblTxt.AutoCompleteCustomSource.Contains(inputTbl))
                {
                    dgv1.DataSource = dbDt.AsEnumerable().Where(x => x.Field<string>("TBL_PHYSICAL_NAME").ToString().Equals(inputTbl) || x.Field<string>("TBL_LOGICAL_NAME").ToString().Equals(inputTbl)).CopyToDataTable();
                    dgv1.Columns[1].Frozen = true;
                    outDbExcel.Enabled = true;
                }
                else
                {
                    outDbExcel.Enabled = false;
                    MessageBox.Show("リスト内に存在しない。");
                }
            }
        }

        private void ColTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var inputCol = ColTxt.Text.ToUpper();
                fileName = inputCol;
                if (ColTxt.AutoCompleteCustomSource.Contains(inputCol))
                {
                    dgv1.DataSource = dbDt.AsEnumerable().Where(x => x.Field<string>("COL_PHYSICAL_NAME").ToString().Equals(inputCol) || x.Field<string>("COL_LOGICAL_NAME").ToString().Equals(inputCol)).CopyToDataTable();
                    outDbExcel.Enabled = true;
                }
                else
                {
                    outDbExcel.Enabled = false;
                    MessageBox.Show("リスト内に存在しない。");
                }
            }
        }
    }
}