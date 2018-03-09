using DAO;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Windows.Forms;
using System;
using MetroFramework;

namespace MiniAccess
{
    public partial class frmTable : MetroForm
    {
        public frmTable()
        {
            InitializeComponent();
        }

        //declaration of global variables
        TableDef table;

        public int autoIncr;
        public int inxcount;
        public int unqcount;
        public int pricount;

        //function to create the table
        private void createTable(MetroGrid dgv)
        {
            bool error = false; //check variable
            if (autoIncr < 2) //check if there is more than one auto increment field
            {
                foreach (DataGridViewRow row in dgv.Rows) //loops through the datagridview rows
                {
                    if (row.Index != dgv.RowCount - 1)
                    {
                        createField(dgv, row.Index); //creates a field
                    }
                }
                if (unqcount > 1) //if there are more than one unique value, display error
                {
                    MetroMessageBox.Show(this, "This table already contains a field with the property UNIQUE.\nA table can only contain one UNIQUE field.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
                if (pricount > 1) //if there are more than one primary value, display error
                {
                    MetroMessageBox.Show(this, "This table already contains a field with the property PRIMARY.\nA table can only contain one PRIMARY field.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
                if (!error) //if no error found, then append table
                {
                    clsDataStorage.tableNames.Add(txtTableName.Text);
                    MetroMessageBox.Show(this, "Table : " + txtTableName.Text + " successfully created.");
                    clsDataStorage.db.TableDefs.Append(table);
                    MiniAccess.disableMenu();
                    MiniAccess.enableAdd();
                    MiniAccess.tsMenuOpen.Enabled = false;
                    autoIncr = 0;
                    this.Close();                    
                }
            }
            else
            {
                MessageBox.Show("A table can only contain ONE auto increment value.");
            }
        }

        private void frmTable_Load(object sender, System.EventArgs e)
        {
            //loads items to the combobox type
            clmType.Items.Add("Long");
            clmType.Items.Add("Double");
            clmType.Items.Add("Text");
            clmType.Items.Add("Currency");
            clmType.Items.Add("Boolean");
            clmType.Items.Add("Date Time");

            //loads items to the combobox property
            clmFieldProperty.Items.Add("Primary");
            clmFieldProperty.Items.Add("Unique");
            clmFieldProperty.Items.Add("Index");
            clmFieldProperty.Items.Add("Regular");
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            //checker variables
            inxcount = 0;
            unqcount = 0;
            pricount = 0;
            if (!Validation.isValidName(txtTableName.Text)) //check if table name is composed by letters only
            {
                MetroMessageBox.Show(this,"Table name must be composed of letters only.");
            }
            if (clsDataStorage.tableNames.Contains(txtTableName.Text)) //check if there isnt a table with the chosen name already
            {
                MetroMessageBox.Show(this, "The database already contains a table with the entered name.");
            }
            else
            {
                table = clsDataStorage.db.CreateTableDef(txtTableName.Text); //creates the tabledef
                if (dataTable.RowCount > 1) //if there is more than 1 row in the gradeview
                {
                    if (Validation.isValidFields(dataTable) == "" && autoIncr < 2)
                    {
                        createTable(dataTable); //creates table
                    }
                    else if (autoIncr > 1) //if there is more than 1 auto increment, return error
                    {
                        MetroMessageBox.Show(this, "A table can only contain ONE auto increment value.");
                    }
                    else
                    {
                        MessageBox.Show(Validation.isValidFields(dataTable)); //check for validation in the table
                    }
                }
                else
                {
                    MetroMessageBox.Show(this,"Your table must contain at least one field."); //checks if there is at leaste one field in the table
                }

            }
        }
        private void createField(DataGridView dgv, int indexRow) //function to create a new field
        {            
            string name;
            name = dgv.Rows[indexRow].Cells["clmName"].Value.ToString();
            int size;
            Field field = new Field();

            //creates the field according to the type chosen by the user
            if (dgv.Rows[indexRow].Cells["clmType"].Value.ToString() == "Long" && autoIncr < 2)
            {
                size = Convert.ToInt16(dgv.Rows[indexRow].Cells["clmSize"].Value.ToString());
                field = table.CreateField(name, DAO.DataTypeEnum.dbLong, size);
                if (dgv.Rows[indexRow].Cells["clmAuto"].Value != null && dgv.Rows[indexRow].Cells["clmAuto"].Value.ToString() == "True")
                {
                    field.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                }
            }

            else if (dgv.Rows[indexRow].Cells["clmType"].Value.ToString() == "Double")
            {
                size = Convert.ToInt16(dgv.Rows[indexRow].Cells["clmSize"].Value.ToString());
                field = table.CreateField(name, DAO.DataTypeEnum.dbDouble, size);
            }

            else if (dgv.Rows[indexRow].Cells["clmType"].Value.ToString() == "Text")
            {
                size = Convert.ToInt16(dgv.Rows[indexRow].Cells["clmSize"].Value.ToString());
                field = table.CreateField(name, DAO.DataTypeEnum.dbText, size);
            }
            else if (dgv.Rows[indexRow].Cells["clmType"].Value.ToString() == "Currency")
            {
                size = Convert.ToInt16(dgv.Rows[indexRow].Cells["clmSize"].Value.ToString());
                field = table.CreateField(name, DAO.DataTypeEnum.dbCurrency, size);
            }
            else if (dgv.Rows[indexRow].Cells["clmType"].Value.ToString() == "Boolean")
            {
                size = Convert.ToInt16(dgv.Rows[indexRow].Cells["clmSize"].Value.ToString());
                field = table.CreateField(name, DAO.DataTypeEnum.dbBoolean, size);
            }
            else
            {
                field = table.CreateField(name, DAO.DataTypeEnum.dbDate);
            }

            table.Fields.Append(field); //appends the field to the table

            if (dgv.Rows[indexRow].Cells["clmFieldProperty"].Value != null && 
                dgv.Rows[indexRow].Cells["clmFieldProperty"].Value.ToString() == "Primary")
            //check if field is primary, then append the property
            {
                pricount++;
                Index index = table.CreateIndex("pk_" + name);
                field = index.CreateField(name);
                index.Primary = true;
                index.Required = true;
                index.IgnoreNulls = false;
                ((IndexFields)index.Fields).Append(field);
                table.Indexes.Append(index);
            }

            else if (dgv.Rows[indexRow].Cells["clmFieldProperty"].Value != null && 
                dgv.Rows[indexRow].Cells["clmFieldProperty"].Value.ToString() == "Unique")
            //check if field is unique, then append the property
            {
                unqcount++;
                Index index = table.CreateIndex("unq_" + name);
                field = index.CreateField(name);
                index.Required = true;
                index.Unique = true;
                index.IgnoreNulls = false;
                ((IndexFields)index.Fields).Append(field);
                table.Indexes.Append(index);
            }
            else if (dgv.Rows[indexRow].Cells["clmFieldProperty"].Value != null && 
                dgv.Rows[indexRow].Cells["clmFieldProperty"].Value.ToString() == "Index")
            //check if field is index, then append the property
            {
                Index index = table.CreateIndex("idx_" + name);
                field = index.CreateField(name);
                index.Required = true;
                index.Unique = true;
                index.IgnoreNulls = false;
                ((IndexFields)index.Fields).Append(field);
                table.Indexes.Append(index);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //checker for multiple autoincrement choices
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dataTable.Rows[e.RowIndex].Cells[0].EditedFormattedValue) == true)
                {
                    autoIncr++;
                }
                else
                {
                    autoIncr--;
                }
            }
        }
    }
}
