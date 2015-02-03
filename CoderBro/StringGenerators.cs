using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoderBro
{
    public partial class frmMain : Form
    {
 #region C# Section

        private string GenerateParameters()
        {
            if (clbFields.Items.Count == 0) return string.Empty;

            string methodParameters = string.Empty;
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    //methodParameters += "string " + clbFields.Items[i].ToString() + ",";
                    methodParameters += "@" + (clbFields.Items[i] as TableField).ClassField + ",\r\n";
                };
            };
            methodParameters = methodParameters.Remove(methodParameters.Length - 1, 1);
            return methodParameters;
        }

        public string GenerateSelectString()
        {
            string selectSQL = "\"SELECT ";
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    selectSQL +=  f + ",";
                };
            };
            selectSQL = selectSQL.Remove(selectSQL.Length - 1, 1);//remove last comma in selectSQL string
            selectSQL += " FROM " + clbTables.Text+"\"";
            return selectSQL;
        }

        public string GenerateUpdateString()
        {
            string updateSQL = "\"UPDATE " + clbTables.Text + " SET ";
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    updateSQL += f + "=@" + f + ",";
                };
            };
            updateSQL = updateSQL.Remove(updateSQL.Length - 1, 1);//remove last comma in updateSQL string
            updateSQL += " WHERE ID=\"";
            return updateSQL;
        }

        public string GenerateInsertString()
        {
            string insertSQL = "\"INSERT INTO " + clbTables.Text + "(";
            string values = " VALUES (";
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    insertSQL += f + ",";
                    values += "@" + f + ",";
                };
            };
            insertSQL = insertSQL.Remove(insertSQL.Length - 1, 1) + ")";//remove last comma in updateSQL string
            values = values.Remove(values.Length - 1, 1) + ")\"";

            return insertSQL + values;
        }

        public string GenerateDeleteString()
        {
            return  "\"DELETE FROM " + clbTables.Text + " WHERE ID=\"";
        }

        #endregion


        #region SQL Server Section

        private string GenerateSPName(string spType)
        {
            if (!string.IsNullOrEmpty(clbTables.Text))
            {
                string tableName = clbTables.Text;
                tableName = tableName.Insert(3, spType);
                return "sp" + tableName.Remove(tableName.Length - 1);
            }
            else return string.Empty;
        }

        private string GenerateSPParameters()
        {
            if (clbFields.Items.Count == 0) return string.Empty;

            string methodParameters = string.Empty;
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    methodParameters += "@"+(clbFields.Items[i] as TableField).FieldNameWithType  +",\r\n";
                };
            };
            methodParameters = methodParameters.Remove(methodParameters.Length - 1, 1);
            return methodParameters;
        }

        public string GenerateSPSelectString()
        {
            string selectSQL = "\"SELECT ";
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    selectSQL += f + ",";
                };
            };
            selectSQL = selectSQL.Remove(selectSQL.Length - 1, 1);//remove last comma in selectSQL string
            selectSQL += " FROM " + clbTables.Text + "\"";
            return selectSQL;
        }

        public string GenerateSPUpdateString()
        {
            string updateSQL = "UPDATE " + clbTables.Text + " SET ";
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    updateSQL += f + "=@" + f + ",";
                };
            };
            updateSQL = updateSQL.Remove(updateSQL.Length - 1, 1);//remove last comma in updateSQL string
            updateSQL += " WHERE ID=";
            return updateSQL;
        }

        public string GenerateSPInsertString()
        {
            string insertSQL = "INSERT INTO " + clbTables.Text + "(";
            string values = " VALUES (";
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    insertSQL += f + ",";
                    values += "@" + f + ",";
                };
            };
            insertSQL = insertSQL.Remove(insertSQL.Length - 1, 1) + ")";//remove last comma in updateSQL string
            values = values.Remove(values.Length - 1, 1) + ")";

            return insertSQL + values;
        }

        public string GenerateSPDeleteString()
        {
            return "DELETE FROM " + clbTables.Text + " WHERE ID=";
        }


        #endregion


        //public string GenerateUpdateString(List<string> fieldsList, string tableName)
        //{
        //    string updateSQL = "UPDATE " + tableName+ " SET ";
        //    for (int i = 0; i < fieldsList.Count; i++)
        //    {
        //            string f = fieldsList[i].ToString();
        //            updateSQL += f + "=@" + f + ",";
        //    };
        //    updateSQL = updateSQL.Remove(updateSQL.Length - 1, 1);//remove last comma in updateSQL string
        //    updateSQL += " WHERE ID=\"+ID";
        //    return updateSQL;
        //}

        public string GenerateCommandSection()
        {
            string commandString = string.Empty;
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    commandString += "cmd.Parameters.AddWithValue(\"@" + f + "\"," + f + ");\r";
                }
            }
            return commandString;
        }

        public string GenerateCommandSectionWithClass(string className)
        {
            string commandString = string.Empty;
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    commandString += "cmd.Parameters.AddWithValue(\"@" + f + "\"," + className+"."+f + ");\r";
                }
            }
            return commandString;
        }

        public string GenerateSqlParameters()
        {
            string parametersString = "SqlParameterCollection prm;\n\r";
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    parametersString += "prm.Add(new SqlParameter(\"@" + f + "," + f + "));\r";
                };
            };

            return parametersString;
        }

        private string GenerateClassProperties()
        {
            string propertiesString = string.Empty;
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                     propertiesString += (clbFields.Items[i] as TableField).ClassField;
                };
            };

            return propertiesString;
        }


    }
}
