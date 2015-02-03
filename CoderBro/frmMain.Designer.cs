namespace CoderBro
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new ScintillaNet.Scintilla();
            this.btnTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLoadTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbGenerateCode = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAsCs = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnkGenerate = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtGeneratedCode = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkGenerateCustom = new System.Windows.Forms.LinkLabel();
            this.txtCustomText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDatabases = new System.Windows.Forms.DataGridView();
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.lnkSelectAllFields = new System.Windows.Forms.LinkLabel();
            this.clbFields = new System.Windows.Forms.CheckedListBox();
            this.lnkGetTables = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(382, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(744, 583);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(736, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Methods";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 88);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTest);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(730, 466);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ConfigurationManager.Language = "cs";
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Indentation.IndentWidth = 10;
            this.richTextBox1.Indentation.ShowGuides = true;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margins.FoldMarginColor = System.Drawing.Color.Black;
            this.richTextBox1.Margins.FoldMarginHighlightColor = System.Drawing.Color.DimGray;
            this.richTextBox1.Margins.Margin0.Width = 20;
            this.richTextBox1.Margins.Margin1.Width = 10;
            this.richTextBox1.Margins.Margin2.Width = 20;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Scrolling.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(495, 466);
            this.richTextBox1.Styles.BraceBad.FontName = "Verdana";
            this.richTextBox1.Styles.BraceLight.FontName = "Verdana";
            this.richTextBox1.Styles.ControlChar.FontName = "Verdana";
            this.richTextBox1.Styles.Default.FontName = "Verdana";
            this.richTextBox1.Styles.IndentGuide.FontName = "Verdana";
            this.richTextBox1.Styles.LastPredefined.FontName = "Verdana";
            this.richTextBox1.Styles.LineNumber.FontName = "Verdana";
            this.richTextBox1.Styles.Max.FontName = "Verdana";
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.Location = new System.Drawing.Point(0, 355);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(231, 23);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Value});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(231, 355);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Controls.Add(this.txtMethodName);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lnkGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 85);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadTemplate,
            this.tsbGenerateCode,
            this.tsbSaveAsCs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLoadTemplate
            // 
            this.tsbLoadTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadTemplate.Image")));
            this.tsbLoadTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadTemplate.Name = "tsbLoadTemplate";
            this.tsbLoadTemplate.Size = new System.Drawing.Size(97, 22);
            this.tsbLoadTemplate.Text = "Load Template";
            this.tsbLoadTemplate.Click += new System.EventHandler(this.tsbLoadTemplate_Click);
            // 
            // tsbGenerateCode
            // 
            this.tsbGenerateCode.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerateCode.Image")));
            this.tsbGenerateCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerateCode.Name = "tsbGenerateCode";
            this.tsbGenerateCode.Size = new System.Drawing.Size(100, 22);
            this.tsbGenerateCode.Text = "Generate Code";
            this.tsbGenerateCode.Click += new System.EventHandler(this.tsbGenerateCode_Click);
            // 
            // tsbSaveAsCs
            // 
            this.tsbSaveAsCs.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAsCs.Image")));
            this.tsbSaveAsCs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAsCs.Name = "tsbSaveAsCs";
            this.tsbSaveAsCs.Size = new System.Drawing.Size(92, 22);
            this.tsbSaveAsCs.Text = "Save As *.cs ";
            this.tsbSaveAsCs.Click += new System.EventHandler(this.tsbSaveAsCs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Class Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Method Name";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(87, 42);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(126, 20);
            this.txtClassName.TabIndex = 9;
            this.txtClassName.Text = "User";
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(550, 39);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(126, 20);
            this.txtMethodName.TabIndex = 9;
            this.txtMethodName.Text = "UpdateContent";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(470, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Generate Method";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkGenerate
            // 
            this.lnkGenerate.AutoSize = true;
            this.lnkGenerate.Location = new System.Drawing.Point(566, 62);
            this.lnkGenerate.Name = "lnkGenerate";
            this.lnkGenerate.Size = new System.Drawing.Size(90, 13);
            this.lnkGenerate.TabIndex = 8;
            this.lnkGenerate.TabStop = true;
            this.lnkGenerate.Text = "Generate Method";
            this.lnkGenerate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerateMethod_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtGeneratedCode);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(736, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom Text Creation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtGeneratedCode
            // 
            this.txtGeneratedCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGeneratedCode.Location = new System.Drawing.Point(3, 89);
            this.txtGeneratedCode.Multiline = true;
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.Size = new System.Drawing.Size(730, 465);
            this.txtGeneratedCode.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lnkGenerateCustom);
            this.panel2.Controls.Add(this.txtCustomText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 86);
            this.panel2.TabIndex = 0;
            // 
            // lnkGenerateCustom
            // 
            this.lnkGenerateCustom.AutoSize = true;
            this.lnkGenerateCustom.Location = new System.Drawing.Point(632, 29);
            this.lnkGenerateCustom.Name = "lnkGenerateCustom";
            this.lnkGenerateCustom.Size = new System.Drawing.Size(51, 13);
            this.lnkGenerateCustom.TabIndex = 11;
            this.lnkGenerateCustom.TabStop = true;
            this.lnkGenerateCustom.Text = "Generate";
            this.lnkGenerateCustom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerateCustom_LinkClicked);
            // 
            // txtCustomText
            // 
            this.txtCustomText.Location = new System.Drawing.Point(30, 26);
            this.txtCustomText.Name = "txtCustomText";
            this.txtCustomText.Size = new System.Drawing.Size(596, 20);
            this.txtCustomText.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDatabases);
            this.panel3.Controls.Add(this.clbTables);
            this.panel3.Controls.Add(this.lnkSelectAllFields);
            this.panel3.Controls.Add(this.clbFields);
            this.panel3.Controls.Add(this.lnkGetTables);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 605);
            this.panel3.TabIndex = 12;
            // 
            // dgvDatabases
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDatabases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatabases.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDatabases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatabases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatabases.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDatabases.Location = new System.Drawing.Point(0, 0);
            this.dgvDatabases.Name = "dgvDatabases";
            this.dgvDatabases.ReadOnly = true;
            this.dgvDatabases.RowHeadersVisible = false;
            this.dgvDatabases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatabases.Size = new System.Drawing.Size(382, 252);
            this.dgvDatabases.TabIndex = 7;
            this.dgvDatabases.SelectionChanged += new System.EventHandler(this.dgvDatabases_SelectionChanged);
            // 
            // clbTables
            // 
            this.clbTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbTables.CheckOnClick = true;
            this.clbTables.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(5, 286);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(191, 299);
            this.clbTables.TabIndex = 5;
            this.clbTables.SelectedIndexChanged += new System.EventHandler(this.clbTables_SelectedIndexChanged);
            // 
            // lnkSelectAllFields
            // 
            this.lnkSelectAllFields.AutoSize = true;
            this.lnkSelectAllFields.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSelectAllFields.Location = new System.Drawing.Point(202, 269);
            this.lnkSelectAllFields.Name = "lnkSelectAllFields";
            this.lnkSelectAllFields.Size = new System.Drawing.Size(51, 13);
            this.lnkSelectAllFields.TabIndex = 4;
            this.lnkSelectAllFields.TabStop = true;
            this.lnkSelectAllFields.Text = "Select All";
            this.lnkSelectAllFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerate_LinkClicked);
            // 
            // clbFields
            // 
            this.clbFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbFields.CheckOnClick = true;
            this.clbFields.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbFields.FormattingEnabled = true;
            this.clbFields.Location = new System.Drawing.Point(202, 286);
            this.clbFields.Name = "clbFields";
            this.clbFields.Size = new System.Drawing.Size(174, 304);
            this.clbFields.TabIndex = 6;
            // 
            // lnkGetTables
            // 
            this.lnkGetTables.AutoSize = true;
            this.lnkGetTables.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkGetTables.Location = new System.Drawing.Point(2, 269);
            this.lnkGetTables.Name = "lnkGetTables";
            this.lnkGetTables.Size = new System.Drawing.Size(59, 13);
            this.lnkGetTables.TabIndex = 3;
            this.lnkGetTables.TabStop = true;
            this.lnkGetTables.Text = "Get Tables";
            this.lnkGetTables.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGetTables_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(382, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 605);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoderBro : Simple Code Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.richTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.LinkLabel lnkGenerate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtGeneratedCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lnkGenerateCustom;
        private System.Windows.Forms.TextBox txtCustomText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.CheckedListBox clbFields;
        private System.Windows.Forms.LinkLabel lnkGetTables;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLoadTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dgvDatabases;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ToolStripButton tsbGenerateCode;
        private System.Windows.Forms.LinkLabel lnkSelectAllFields;
        private System.Windows.Forms.ToolStripButton tsbSaveAsCs;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ScintillaNet.Scintilla richTextBox1;
    }
}

