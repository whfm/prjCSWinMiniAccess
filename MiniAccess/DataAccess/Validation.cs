using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MiniAccess
{
    /*
     Data Validation class
     */
    class Validation
    {

        /*Name validation - letters only*/
        public static bool isValidName(string name)
        {
            Match match = Regex.Match(name, @"([A-Za-z]+)$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Size validation - numbers only*/
        public static bool isValidSize(string size)
        {
            Match match = Regex.Match(size, @"([0-9]+)$", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Fields validation in the datagrid*/
        public static string isValidFields(DataGridView dataTable)
        {
            string err = "";
            int index = 0;
            List<string> columnTableNames = new List<string>();

            foreach (DataGridViewRow row in dataTable.Rows)
                if (row.Index != dataTable.RowCount-1)
                {
                    string error = "";
                    index = row.Index;
                    if (dataTable.Rows[index].Cells["clmName"].Value == null ||
                        !Validation.isValidName(dataTable.Rows[index].Cells["clmName"].Value.ToString()))
                    {
                        error += "A column name must be composed of letters only.";
                    }
                    else
                    {
                        columnTableNames.Add(dataTable.Rows[index].Cells["clmName"].Value.ToString());
                    }
                    if (dataTable.Rows[index].Cells["clmType"].Value == null ||
                        dataTable.Rows[index].Cells["clmType"].Value.ToString() == "")
                    {
                        error += "Select type.\n";
                    }
                    if ((dataTable.Rows[index].Cells["clmType"].Value == null ||
                        dataTable.Rows[index].Cells["clmType"].Value.ToString() == "Long"
                        || dataTable.Rows[index].Cells["clmType"].Value.ToString() == "Double"
                        || dataTable.Rows[index].Cells["clmType"].Value.ToString() == "Text") &&
                        (dataTable.Rows[index].Cells["clmSize"].Value == null || 
                        !isValidSize(dataTable.Rows[index].Cells["clmSize"].Value.ToString())))
                    {
                        error += "Size must not be left in blank.";
                    }
                    if (dataTable.Rows[index].Cells["clmAuto"].Value != null &&
                        dataTable.Rows[index].Cells["clmAuto"].Value.ToString() == "T" &&
                        dataTable.Rows[index].Cells["clmType"].Value.ToString() != "Long")
                    {
                        error += "The auto increment property works only with items of the type Long";
                    }
                    if (error != "")
                    {
                        err += "Row " + (index + 1).ToString() + " : \n" + error;
                    }
                }

            if (columnTableNames.Count != columnTableNames.Distinct().Count())
                err = "Table names have to be unique!" + err;
            return err;
        }
    }
}
