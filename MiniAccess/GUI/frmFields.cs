using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using ADODB;
using MetroFramework;
using DAO;

namespace MiniAccess.GUI
{
    public partial class frmFields : MetroForm
    {
        public frmFields()
        {
            InitializeComponent();
        }

        ADODB.Recordset recordSet;
        ADODB.Connection mycon;
        int r = 0;

        private void frmFields_Load(object sender, EventArgs e)
        {
            int y = 0;
            foreach (TableDef table in clsDataStorage.db.TableDefs) //loops through the tables
            {
                if (table.Attributes == 0) //excludes system tables
                {
                    cmbTableUn.Items.Add(table.Name); //adds the table to the combobox
                    y++;
                }
            }
            if (y == 0)
            {
                //if there isnt a table, display error and close form
                MetroMessageBox.Show(this, "There are no tables in the database.\nCreate a table before trying to create a relation.");
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void cmbTableUn_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdData.Rows.Clear();
            grdData.Columns.Clear();

            mycon = new ADODB.Connection();
            mycon.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + clsDataStorage.db.Name);
            recordSet = new ADODB.Recordset();
            recordSet.Open("SELECT * FROM " + cmbTableUn.Text, mycon, CursorTypeEnum.adOpenStatic);

            //clsDataStorage.db.OpenTable(cmbTableUn.Text);

            foreach (ADODB.Field field in recordSet.Fields)
            {

                grdData.Columns.Add("clm" + field.Name, field.Name);
            }

            while (!recordSet.EOF)
            {
                grdData.Rows.Add();

                for (int i = 0; i < recordSet.Fields.Count; i++)
                {
                    grdData.Rows[r].Cells[i].Value = recordSet.Fields[i].Value;
                }
                r++;
                recordSet.MoveNext();
            }
            r = 0;
            recordSet.Close();
        }
    }
}
