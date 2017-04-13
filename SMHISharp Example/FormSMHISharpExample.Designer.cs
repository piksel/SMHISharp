namespace Piksel.SMHISharp.Example
{
    partial class FormSMHISharpExample
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
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.bPrevious = new System.Windows.Forms.Button();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListView2 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.bNext = new System.Windows.Forms.Button();
            this.wizard = new Piksel.Controls.TabWizard.TabWizardControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpParameters = new System.Windows.Forms.TabPage();
            this.tpStations = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView2)).BeginInit();
            this.wizard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpParameters.SuspendLayout();
            this.tpStations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListView1.Location = new System.Drawing.Point(6, 6);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(663, 352);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(12, 409);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(133, 43);
            this.bPrevious.TabIndex = 1;
            this.bPrevious.Text = "&Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Title";
            this.olvColumn1.Width = 200;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Summary";
            this.olvColumn2.FillsFreeSpace = true;
            // 
            // objectListView2
            // 
            this.objectListView2.AllColumns.Add(this.olvColumn3);
            this.objectListView2.AllColumns.Add(this.olvColumn4);
            this.objectListView2.AllColumns.Add(this.olvColumn5);
            this.objectListView2.CellEditUseWholeCell = false;
            this.objectListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.objectListView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView2.FullRowSelect = true;
            this.objectListView2.Location = new System.Drawing.Point(6, 6);
            this.objectListView2.Name = "objectListView2";
            this.objectListView2.ShowGroups = false;
            this.objectListView2.Size = new System.Drawing.Size(664, 352);
            this.objectListView2.TabIndex = 2;
            this.objectListView2.UseCompatibleStateImageBehavior = false;
            this.objectListView2.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Name";
            this.olvColumn3.FillsFreeSpace = true;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Summary";
            this.olvColumn4.Width = 280;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Updated";
            this.olvColumn5.Width = 180;
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(543, 409);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(133, 43);
            this.bNext.TabIndex = 3;
            this.bNext.Text = "&Next";
            this.bNext.UseVisualStyleBackColor = true;
            // 
            // wizard
            // 
            this.wizard.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.wizard.Controls.Add(this.tabPage1);
            this.wizard.Controls.Add(this.tpParameters);
            this.wizard.Controls.Add(this.tpStations);
            this.wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard.Location = new System.Drawing.Point(3, 16);
            this.wizard.Name = "wizard";
            this.wizard.NextButton = this.bNext;
            this.wizard.NextButtonLastText = "Close";
            this.wizard.PreviousButton = this.bPrevious;
            this.wizard.SelectedIndex = 0;
            this.wizard.Size = new System.Drawing.Size(684, 390);
            this.wizard.TabIndex = 4;
            this.wizard.Text = null;
            this.wizard.LastButtonClicked += new System.EventHandler(this.wizard_LastButtonClicked);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Intro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpParameters
            // 
            this.tpParameters.Controls.Add(this.objectListView1);
            this.tpParameters.Location = new System.Drawing.Point(4, 22);
            this.tpParameters.Name = "tpParameters";
            this.tpParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tpParameters.Size = new System.Drawing.Size(676, 364);
            this.tpParameters.TabIndex = 1;
            this.tpParameters.Text = "Parameters";
            this.tpParameters.UseVisualStyleBackColor = true;
            // 
            // tpStations
            // 
            this.tpStations.Controls.Add(this.objectListView2);
            this.tpStations.Location = new System.Drawing.Point(4, 22);
            this.tpStations.Name = "tpStations";
            this.tpStations.Padding = new System.Windows.Forms.Padding(3);
            this.tpStations.Size = new System.Drawing.Size(676, 364);
            this.tpStations.TabIndex = 2;
            this.tpStations.Text = "Stations";
            this.tpStations.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.wizard);
            this.groupBox1.Location = new System.Drawing.Point(0, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 409);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click \"Next\" to get parameters";
            // 
            // FormSMHISharpExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.Name = "FormSMHISharpExample";
            this.Text = "SMHISharp Example";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView2)).EndInit();
            this.wizard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpParameters.ResumeLayout(false);
            this.tpStations.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.Button bPrevious;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.ObjectListView objectListView2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.Button bNext;
        private Controls.TabWizard.TabWizardControl wizard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpParameters;
        private System.Windows.Forms.TabPage tpStations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

