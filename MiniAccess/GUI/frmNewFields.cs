using System;
using MetroFramework;
using DAO;
using System.Windows.Forms;

namespace MiniAccess
{
    public partial class frmNewFields : MetroFramework.Forms.MetroForm
    {
        public frmNewFields()
        {
            InitializeComponent();
        }
        
        //global variables to this form
        Recordset recordSet;
        TableDef table;
        public int autoIncr;

        private void frmNewFields_Load(object sender, EventArgs e) //starts the newfields form
        {

            //loads the combo boxes
            cmbFieldType.Items.Add("Long");
            cmbFieldType.Items.Add("Double");
            cmbFieldType.Items.Add("Text");
            cmbFieldType.Items.Add("Currency");
            cmbFieldType.Items.Add("Boolean");
            cmbFieldType.Items.Add("Date Time");

            cmbFieldProperty.Items.Add("Primary");
            cmbFieldProperty.Items.Add("Unique");
            cmbFieldProperty.Items.Add("Index");
            cmbFieldProperty.Items.Add("Regular");

            int y = 0; 
            foreach (TableDef table in clsDataStorage.db.TableDefs) //loads the tables in the combobox
            {
                if (table.Attributes == 0)
                {
                    cmbListTable.Items.Add(table.Name);
                    y++;
                }
            }
            if (y == 0) { //if there isnt a table, display error and close form
                MetroMessageBox.Show(this, "There are no tables in the database.\nCreate a table before trying to add a field");
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) //triggers the creation of a new field
        {
            bool error = false;
            foreach (TableDef oneTable in clsDataStorage.db.TableDefs) //loops through the tabledefinitions
            {
                if (oneTable.Attributes == 0)
                {
                    foreach (Field abcd in oneTable.Fields)
                    {
                        if (abcd.Name == txtFieldName.Text) //check if table already contains a field with the same name
                        {
                            MetroMessageBox.Show(this, "This table already contains a field with the name " + abcd.Name + ".\nField names have to be unique!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            error = true;
                        }
                    }
                    if (cmbFieldProperty.Text == "Primary" || cmbFieldProperty.Text == "Unique") //check if table contains primary or unique elements
                    {
                        foreach (Index inx in oneTable.Indexes)
                        {
                            if (inx.Primary == true && !error)
                            {
                                MetroMessageBox.Show(this, "This table already contains a field with the property INDEX.\nA table can only contain one index.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                error = true;
                                break;
                            }
                            if (inx.Unique == true && !error)
                            {
                                MetroMessageBox.Show(this, "This table already contains a field with the property UNIQUE.\nA table can only contain one UNIQUE.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                error = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (!error) //if no primary or unique, then create a new field
            {
                table = clsDataStorage.db.TableDefs[cmbListTable.Text]; 
                string name;
                name = txtFieldName.Text;
                int size;
                Field field = new Field();
                //creates the field according to the type chosen by the user
                if (cmbFieldType.Text == "Long")
                {
                    size = Convert.ToInt32(txtFieldSize.Text);
                    field = table.CreateField(name, DAO.DataTypeEnum.dbLong, size);
                    if (chkAuto.Checked)
                    {
                        field.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                    }
                }

                else if (cmbFieldType.Text == "Double")
                {
                    size = Convert.ToInt32(txtFieldSize.Text);
                    field = table.CreateField(name, DAO.DataTypeEnum.dbDouble, size);
                }

                else if (cmbFieldType.Text == "Text")
                {
                    size = Convert.ToInt32(txtFieldSize.Text);
                    field = table.CreateField(name, DAO.DataTypeEnum.dbText, size);
                }
                else if (cmbFieldType.Text == "Currency")
                {
                    size = Convert.ToInt32(txtFieldSize.Text);
                    field = table.CreateField(name, DAO.DataTypeEnum.dbCurrency, size);
                }
                else if (cmbFieldType.Text == "Boolean")
                {
                    size = Convert.ToInt32(txtFieldSize.Text);
                    field = table.CreateField(name, DAO.DataTypeEnum.dbBoolean, size);
                }
                else
                {
                    field = table.CreateField(name, DAO.DataTypeEnum.dbDate);
                }

                table.Fields.Append(field); //appends the field to the table

                if (cmbFieldProperty.Text == "Primary") //check if field is primary, then append the property
                {
                    Index index = table.CreateIndex("pk_" + name);
                    field = index.CreateField(name);
                    index.Primary = true;
                    index.Required = true;
                    index.IgnoreNulls = false;
                    ((IndexFields)index.Fields).Append(field);
                    table.Indexes.Append(index);
                }

                else if (cmbFieldProperty.Text == "Unique") //check if field is unique, then append the property
                {
                    Index index = table.CreateIndex("unq_" + name);
                    field = index.CreateField(name);
                    index.Required = true;
                    index.Unique = true;
                    index.IgnoreNulls = false;
                    ((IndexFields)index.Fields).Append(field);
                    table.Indexes.Append(index);
                }
                else if (cmbFieldProperty.Text == "Index") //check if field is index, then append the property
                {
                    Index index = table.CreateIndex("idx_" + name);
                    field = index.CreateField(name);
                    index.Required = true;
                    index.Unique = true;
                    index.IgnoreNulls = false;
                    ((IndexFields)index.Fields).Append(field);
                    table.Indexes.Append(index);
                }
                MetroMessageBox.Show(this, "The new field was included successfully.", "New field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //after the field being added, closes the form
            }
        }

        private void cmbListTable_SelectedIndexChanged(object sender, EventArgs e) //triggers when user select table from combobox
        {
            bool check = false;
            recordSet = clsDataStorage.db.OpenTable(cmbListTable.Text);
            foreach (Field field in recordSet.Fields) //loops through the fields
            {
                if (field.Type == 4) //if field is auto increase, disables the checkbox as table can only contain one auto increaser
                {
                    check = true;
                    chkAuto.Enabled = false;
                }
            }
            if (!check) { chkAuto.Enabled = true; } //if there is no autoincrease field in the table, the autoincrease will be enabled
            recordSet.Close(); //closes the recordset
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }
    }
}
