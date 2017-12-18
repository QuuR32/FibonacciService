namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.bComputeFibonancci = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvResult = new System.Windows.Forms.TreeView();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bComputeXmlToJson = new System.Windows.Forms.Button();
            this.tbEntryXml = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bComputeFibonancci
            // 
            this.bComputeFibonancci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bComputeFibonancci.Location = new System.Drawing.Point(292, 293);
            this.bComputeFibonancci.Name = "bComputeFibonancci";
            this.bComputeFibonancci.Size = new System.Drawing.Size(196, 23);
            this.bComputeFibonancci.TabIndex = 4;
            this.bComputeFibonancci.Text = "Compute Fibonancci >>";
            this.bComputeFibonancci.UseVisualStyleBackColor = true;
            this.bComputeFibonancci.Click += new System.EventHandler(this.bComputeFibonancci_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudNumber.Location = new System.Drawing.Point(328, 257);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 20);
            this.nudNumber.TabIndex = 5;
            this.nudNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 616);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudNumber);
            this.tabPage1.Controls.Add(this.bComputeFibonancci);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fibonacci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.bComputeXmlToJson);
            this.tabPage2.Controls.Add(this.tbEntryXml);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xml to Json";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 116);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbResult);
            this.splitContainer1.Size = new System.Drawing.Size(764, 471);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 6;
            // 
            // tvResult
            // 
            this.tvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResult.Location = new System.Drawing.Point(0, 0);
            this.tvResult.Name = "tvResult";
            this.tvResult.Size = new System.Drawing.Size(254, 471);
            this.tvResult.TabIndex = 9;
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Location = new System.Drawing.Point(0, 0);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(506, 471);
            this.tbResult.TabIndex = 8;
            // 
            // bComputeXmlToJson
            // 
            this.bComputeXmlToJson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bComputeXmlToJson.Location = new System.Drawing.Point(285, 87);
            this.bComputeXmlToJson.Name = "bComputeXmlToJson";
            this.bComputeXmlToJson.Size = new System.Drawing.Size(196, 23);
            this.bComputeXmlToJson.TabIndex = 5;
            this.bComputeXmlToJson.Text = "Compute Xml to Json >>";
            this.bComputeXmlToJson.UseVisualStyleBackColor = true;
            this.bComputeXmlToJson.Click += new System.EventHandler(this.bComputeXmlToJson_Click);
            // 
            // tbEntryXml
            // 
            this.tbEntryXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEntryXml.Location = new System.Drawing.Point(6, 6);
            this.tbEntryXml.Multiline = true;
            this.tbEntryXml.Name = "tbEntryXml";
            this.tbEntryXml.Size = new System.Drawing.Size(761, 75);
            this.tbEntryXml.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 640);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(430, 340);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Developer LemonWay Challenge  - Quentin Urlacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bComputeFibonancci;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bComputeXmlToJson;
        private System.Windows.Forms.TextBox tbEntryXml;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvResult;
        private System.Windows.Forms.TextBox tbResult;
    }
}

