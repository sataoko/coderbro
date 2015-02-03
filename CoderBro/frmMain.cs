using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.OleDb;
using System.IO;

namespace CoderBro
{
    public partial class frmMain : Form
    {
        public string ConnectionStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LKSAnaliz.mdb";

        public DatabaseInfo databaseInfo = new DatabaseInfo();

        string name;
        public string Display()
        {
            return name;
        }

        public frmMain(string name)
        {
            this.name = name;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        public DataTable GetTablesOfDatabase()
        {
            string connectionString = string.Empty;
            DataTable dt;
            OleDbConnection MyOleDbConnection = new OleDbConnection();

            switch (databaseInfo.TypeOfDatabase)
            {
                case DatabaseType.MDB:
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + databaseInfo.ConnectionStringOfDatabase;
                    MyOleDbConnection.ConnectionString = connectionString;
                    MyOleDbConnection.Open();
                    dt = MyOleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    MyOleDbConnection.Close();
                    return dt;
                    break;
                case DatabaseType.SQL:
                    connectionString = databaseInfo.ConnectionStringOfDatabase;
                    return DAL.GetSQLDBTables(connectionString);
                    break;
                default:
                    return null;
                    ;
                    break;
            }
        }

        private DataTable GetFields(string tableName)
        {
            switch (databaseInfo.TypeOfDatabase)
            {
                case DatabaseType.MDB:
                    return DAL.GetTable("SELECT * FROM " + tableName, databaseInfo.ConnectionStringOfDatabase);
                    break;
                case DatabaseType.SQL:
                    return DAL.GetTable4SQLServer("select * from CASHREG.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" + tableName+"'", databaseInfo.ConnectionStringOfDatabase);
                    break;
                default:
                    return null;
                    break;
            }
        }

        private void lnkGetTables_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = GetTablesOfDatabase();
            clbTables.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                clbTables.Items.Add(dr[2].ToString());
            }
        }

        private void clbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = GetFields(clbTables.Text);
            clbFields.Items.Clear();
            //foreach (DataColumn c in dt.Columns)
            //{
            //  clbFields.Items.Add(c.ToString());
            //}

            foreach (DataRow dr in dt.Rows)
            {
                
                TableField tf = new TableField(dr["COLUMN_NAME"].ToString(),dr["DATA_TYPE"].ToString(), dr["IS_NULLABLE"].ToString(), dr["CHARACTER_MAXIMUM_LENGTH"].ToString());
                clbFields.Items.Add(tf);
            }

            for (int i = 0; i < clbFields.Items.Count; i++)
            {
              clbFields.SetItemChecked(i,true);
            }
        }

        private void lnkGenerateMethod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<string> fields = new List<string>();
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    fields.Add(clbFields.Items[i].ToString());
                };
            };
            txtGeneratedCode.Text = DAL.GenerateUpdateMethod("Update", clbTables.Text, fields);
        }

        private void lnkGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                clbFields.SetSelected(i,true);
            }
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            List<string> vars = new List<string>();
            vars.Add("Method Name");
            vars.Add("Method Parameters");
            vars.Add("Update String");
            vars.Add("Insert String");
            vars.Add("Command Parameters");
            vars.Add("Class Name");
            vars.Add("Class Properties");
            //vars.Add("Entity Name");
            //vars.Add("Entity Properties");
            vars.Add("Sql Parameters");
            foreach (string s in vars)
            {
                dataGridView1.Rows.Add(s, "");
            }


            dgvDatabases.DataSource = DAL.GetTable("SELECT Type,Title,ConnectionString FROM Databases");

        }

        private void lnkLoadTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //richTextBox1.LoadFile("Templates\\SqlUpdate.txt", RichTextBoxStreamType.PlainText);

        }

        private void lnkGenerateCustom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < clbFields.Items.Count; i++)
            {
                if (clbFields.GetItemChecked(i))
                {
                    string f = clbFields.Items[i].ToString();
                    string s = txtCustomText.Text;
                    s = s.Replace("@FieldName", f);
                    txtGeneratedCode.Text += s + "\r";
                };
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate this class
            frmMain cmbn = new frmMain("CSO");

            // Get the desired method by name: DisplayName
            MethodInfo methodInfo = typeof(frmMain).GetMethod("GenerateUpdateString");

            string[] args = { "Jitesh", "patil" };

            // Use the instance to call the method without arguments
            //MessageBox.Show((string)methodInfo.Invoke(cmbn, args));
            //  MessageBox.Show((string) methodInfo.Invoke(cmbn, null));

            MessageBox.Show(GenerateInsertString());


        }

        private void tsbLoadTemplate_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.TXT|*.txt";
            openFileDialog1.InitialDirectory = Application.ExecutablePath;

            Stream myStream;
            richTextBox1.Text = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    using (myStream = openFileDialog1.OpenFile())
                    {
                        string file = openFileDialog1.FileName;
                        string path = Path.GetFullPath(file); //when i did it like this it's work fine but all the time give me same path whatever where my "*.txt" file is
                        //Insert code to read the stream here. 
                        //fileName = openFileDialog1.FileName; 
                        StreamReader reader = new StreamReader(file);
                        //MessageBox.Show(file, "fileName");
                        //MessageBox.Show(path, "Directory");

                        string s = string.Empty;
                        while ((s = reader.ReadLine()) != null)
                        {
                            richTextBox1.Text += s + Environment.NewLine; ;
                        }
                    }
                }
                // Exception thrown: Empty path name is not legal
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. " +
                                    "Original error: " + ex.Message);
                } 
        }


        private string GetTypeValueInGrid(string typeName)
        {
            // foreach (DataGridViewRow dr in dataGridView1.Rows)
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow dr = dataGridView1.Rows[i];
                if (dr.Cells["Type"].Value != null)
                    if (dr.Cells["Type"].Value.ToString() == typeName) return dr.Cells["Value"].Value.ToString();
            }
            return "yok";
        }

        private void dgvDatabases_SelectionChanged(object sender, EventArgs e)
        {
            databaseInfo.ConnectionStringOfDatabase = dgvDatabases.CurrentRow.Cells["ConnectionString"].Value.ToString();
            switch (dgvDatabases.CurrentRow.Cells["Type"].Value.ToString())
            {
                case "MDB": databaseInfo.TypeOfDatabase = DatabaseType.MDB; break;
                case "SQL": databaseInfo.TypeOfDatabase = DatabaseType.SQL; break;
                default: databaseInfo.TypeOfDatabase = DatabaseType.MDB;
                    break;
            }
        }

        private void tsbGenerateCode_Click(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;

            string className = txtClassName.Text;

            //s = s.Replace("@MethodName", GetTypeValueInGrid("Method Name"));
            s = s.Replace("@MethodName", GetTypeValueInGrid("Method Name"));
            s = s.Replace("@MethodParameters", GenerateParameters());
            s = s.Replace("@SelectString", GenerateSelectString());
            s = s.Replace("@UpdateString", GenerateUpdateString());
            s = s.Replace("@InsertString", GenerateInsertString());
            s = s.Replace("@DeleteString", GenerateDeleteString());
            s = s.Replace("@SqlParameters", GenerateSqlParameters());

            s = s.Replace("@SPNameInsert", GenerateSPName("Insert"));
            s = s.Replace("@SPNameUpdate", GenerateSPName("Update"));
            s = s.Replace("@SPNameDelete", GenerateSPName("Delete"));
            s = s.Replace("@SPParameters", GenerateSPParameters());
            s = s.Replace("@SPSelectString", GenerateSPSelectString());
            s = s.Replace("@SPUpdateString", GenerateSPUpdateString());
            s = s.Replace("@SPInsertString", GenerateSPInsertString());
            s = s.Replace("@SPDeleteString", GenerateSPDeleteString());

            //s = s.Replace("@ClassName", GetTypeValueInGrid("Class Name"));
            s = s.Replace("@ClassName", className );
            s = s.Replace("@ClassProperties", GenerateClassProperties());
            //s = s.Replace("@EntityName", GetTypeValueInGrid("Entity Name"));
            //s = s.Replace("@EntityProperties", GenerateEntityProperties());

            string entityName = GetTypeValueInGrid("Entity Name");
            entityName = entityName.ToLower();

            richTextBox1.Text = s.Replace("@CommandParameters", GenerateCommandSection());
            richTextBox1.Text = s.Replace("@CommandParametersWithClass", GenerateCommandSectionWithClass(className));
        }

        private void tsbSaveAsCs_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(GetTypeValueInGrid("Class Name"));
            //string className = GetTypeValueInGrid("Class Name");
            string className = txtClassName.Text;

            //richTextBox1.SaveFile(targetFile, RichTextBoxStreamType.PlainText);

            char c='|';
            string[] bllDALText = richTextBox1.Text.Split(c);

           
                SaveTextFile(Environment.CurrentDirectory+"\\GeneratedFiles\\" + className + ".cs", bllDALText[0]);
                SaveTextFile(Environment.CurrentDirectory + "\\GeneratedFiles\\DAL" + className + ".cs", bllDALText[1]);
        }

        private void SaveTextFile(string targetFile, string p)
        {
             FileInfo t = new FileInfo(targetFile);
            StreamWriter Tex = t.CreateText();
            Tex.WriteLine(p);
            Tex.Close();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(GetTypeValueInGrid("Class Name"));   
        }

    }
}
