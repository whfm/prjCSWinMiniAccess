using System;
using MetroFramework.Forms;
using DAO;

/*This form displays the database structure in a treeview controller*/
namespace MiniAccess
{
    public partial class frmDisplay : MetroForm
    {
        public frmDisplay()
        {
            InitializeComponent();
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {
            treeView.ImageList = imageList; //loads the imagelist into the treeview

            treeView.Nodes.Add("Key","Path: " + clsDataStorage.db.Name,0,0); //displays the path to the database
            int tablecount = 0; //counts how manda tables are in the database

            foreach (TableDef oneTable in clsDataStorage.db.TableDefs)
            {
                if (oneTable.Attributes != 0)
                {
                    tablecount--;
                }
                tablecount++;
            }
            treeView.Nodes.Add("Key","Number of Tables: " + tablecount,1,1); //displays the number total of tables minus the system tables
            
            clsDataStorage.tableNames.Clear(); //clears the tablenames in the global variable
            foreach (TableDef oneTable in clsDataStorage.db.TableDefs)//loops through the table definitions
            {
                if (oneTable.Attributes == 0) //excludes system tables
                {
                    clsDataStorage.tableNames.Add(oneTable.Name); //adds the table to the global variable
                    treeView.Nodes.Add("Key","Table: " + oneTable.Name,5,5); //adds the table to the treeview
                    foreach (Field field in oneTable.Fields)
                    {
                        treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Add("Key", "Field: " + field.Name, 5, 5);
                        //adds the field related to that table in the treeview with specific icon
                    }
                    foreach (Index inx in oneTable.Indexes)
                    {
                        treeView.Nodes[treeView.Nodes.Count - 1].Nodes.Add("Key", "Index: " + inx.Name, 6, 6);
                        //adds the index related to that table in the treeview with specific icon
                    }
                }
            }

            foreach (Relation rel in clsDataStorage.db.Relations) //loops through the relations
            {
                int z = 0;
                if (rel.Attributes == 0)
                {
                    treeView.Nodes.Add("Key","Relation Name: " + rel.Name,2,2); //adds the name of the relation to the table
                    treeView.Nodes[treeView.Nodes.Count-1].Nodes.Add("Key","Primary Table: " + rel.Table,3,3); //adds the name of primary table
                    foreach (Field fd in rel.Fields) //loops through the fields
                    {
                        treeView.Nodes[treeView.Nodes.Count-1].Nodes[z].Nodes.Add("Key", "Primary Field: " + fd.Name, 3, 3); //adds the primary field
                    }
                    treeView.Nodes[treeView.Nodes.Count-1].Nodes.Add("Key","Foreign Table: " + rel.ForeignTable,4,4); //adds the foreign table
                    z++;
                    foreach (Field fd in rel.Fields) //loops through the fields again
                    {
                        treeView.Nodes[treeView.Nodes.Count-1].Nodes[z].Nodes.Add("Key","Foreign Field: " + fd.ForeignName,4,4); //adds the field to the foreign table
                    }
                }
            }
            treeView.ExpandAll(); //expands the treeview
        }
    }
}
