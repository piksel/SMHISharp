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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wizard = new Piksel.Controls.TabWizard.TabWizardControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tpParameters = new System.Windows.Forms.TabPage();
            this.olvParameters = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tpStations = new System.Windows.Forms.TabPage();
            this.tpPeriods = new System.Windows.Forms.TabPage();
            this.olvPeriods = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tpData = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pLoadParameters = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pLoadStations = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pLoadPeriods = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.pLoadData = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.scStations = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.bFindNearest = new System.Windows.Forms.Button();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.olvStations = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cbExcludeOld = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.wizard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvParameters)).BeginInit();
            this.tpStations.SuspendLayout();
            this.tpPeriods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPeriods)).BeginInit();
            this.tpData.SuspendLayout();
            this.pLoadParameters.SuspendLayout();
            this.pLoadStations.SuspendLayout();
            this.pLoadPeriods.SuspendLayout();
            this.pLoadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scStations)).BeginInit();
            this.scStations.Panel1.SuspendLayout();
            this.scStations.Panel2.SuspendLayout();
            this.scStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvStations)).BeginInit();
            this.SuspendLayout();
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrevious.Location = new System.Drawing.Point(12, 406);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(133, 43);
            this.bPrevious.TabIndex = 1;
            this.bPrevious.Text = "&Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.Location = new System.Drawing.Point(539, 406);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(133, 43);
            this.bNext.TabIndex = 3;
            this.bNext.Text = "&Next";
            this.bNext.UseVisualStyleBackColor = true;
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
            this.groupBox1.Size = new System.Drawing.Size(686, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // wizard
            // 
            this.wizard.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.wizard.Controls.Add(this.tabPage1);
            this.wizard.Controls.Add(this.tpParameters);
            this.wizard.Controls.Add(this.tpStations);
            this.wizard.Controls.Add(this.tpPeriods);
            this.wizard.Controls.Add(this.tpData);
            this.wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard.Location = new System.Drawing.Point(3, 16);
            this.wizard.Name = "wizard";
            this.wizard.NextButton = this.bNext;
            this.wizard.NextButtonLastText = "Close";
            this.wizard.PreviousButton = this.bPrevious;
            this.wizard.SelectedIndex = 0;
            this.wizard.Size = new System.Drawing.Size(680, 387);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click \"Next\" to get parameters";
            // 
            // tpParameters
            // 
            this.tpParameters.Controls.Add(this.olvParameters);
            this.tpParameters.Controls.Add(this.pLoadParameters);
            this.tpParameters.Location = new System.Drawing.Point(4, 22);
            this.tpParameters.Name = "tpParameters";
            this.tpParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tpParameters.Size = new System.Drawing.Size(672, 361);
            this.tpParameters.TabIndex = 1;
            this.tpParameters.Text = "Parameters";
            this.tpParameters.UseVisualStyleBackColor = true;
            // 
            // olvParameters
            // 
            this.olvParameters.AllColumns.Add(this.olvColumn1);
            this.olvParameters.AllColumns.Add(this.olvColumn2);
            this.olvParameters.CellEditUseWholeCell = false;
            this.olvParameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.olvParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvParameters.FullRowSelect = true;
            this.olvParameters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvParameters.Location = new System.Drawing.Point(3, 3);
            this.olvParameters.Name = "olvParameters";
            this.olvParameters.Size = new System.Drawing.Size(666, 355);
            this.olvParameters.TabIndex = 0;
            this.olvParameters.UseCompatibleStateImageBehavior = false;
            this.olvParameters.View = System.Windows.Forms.View.Details;
            this.olvParameters.SelectedIndexChanged += new System.EventHandler(this.StateControlChanged);
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
            // tpStations
            // 
            this.tpStations.Controls.Add(this.scStations);
            this.tpStations.Controls.Add(this.pLoadStations);
            this.tpStations.Location = new System.Drawing.Point(4, 22);
            this.tpStations.Name = "tpStations";
            this.tpStations.Padding = new System.Windows.Forms.Padding(3);
            this.tpStations.Size = new System.Drawing.Size(672, 361);
            this.tpStations.TabIndex = 2;
            this.tpStations.Text = "Stations";
            this.tpStations.UseVisualStyleBackColor = true;
            // 
            // tpPeriods
            // 
            this.tpPeriods.Controls.Add(this.olvPeriods);
            this.tpPeriods.Controls.Add(this.pLoadPeriods);
            this.tpPeriods.Location = new System.Drawing.Point(4, 22);
            this.tpPeriods.Name = "tpPeriods";
            this.tpPeriods.Padding = new System.Windows.Forms.Padding(3);
            this.tpPeriods.Size = new System.Drawing.Size(672, 361);
            this.tpPeriods.TabIndex = 3;
            this.tpPeriods.Text = "Periods";
            this.tpPeriods.UseVisualStyleBackColor = true;
            // 
            // olvPeriods
            // 
            this.olvPeriods.AllColumns.Add(this.olvColumn6);
            this.olvPeriods.AllColumns.Add(this.olvColumn8);
            this.olvPeriods.CellEditUseWholeCell = false;
            this.olvPeriods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn6,
            this.olvColumn8});
            this.olvPeriods.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPeriods.FullRowSelect = true;
            this.olvPeriods.Location = new System.Drawing.Point(3, 3);
            this.olvPeriods.Name = "olvPeriods";
            this.olvPeriods.ShowGroups = false;
            this.olvPeriods.Size = new System.Drawing.Size(666, 355);
            this.olvPeriods.TabIndex = 3;
            this.olvPeriods.UseCompatibleStateImageBehavior = false;
            this.olvPeriods.View = System.Windows.Forms.View.Details;
            this.olvPeriods.SelectedIndexChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Title";
            this.olvColumn6.FillsFreeSpace = true;
            this.olvColumn6.Text = "Description";
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Updated";
            this.olvColumn8.Text = "Updated";
            this.olvColumn8.Width = 180;
            // 
            // tpData
            // 
            this.tpData.BackColor = System.Drawing.SystemColors.Window;
            this.tpData.Controls.Add(this.chartData);
            this.tpData.Controls.Add(this.pLoadData);
            this.tpData.Location = new System.Drawing.Point(4, 22);
            this.tpData.Name = "tpData";
            this.tpData.Padding = new System.Windows.Forms.Padding(3);
            this.tpData.Size = new System.Drawing.Size(672, 361);
            this.tpData.TabIndex = 4;
            this.tpData.Text = "Data";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(227, 144);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 36);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // pLoadParameters
            // 
            this.pLoadParameters.Controls.Add(this.label2);
            this.pLoadParameters.Controls.Add(this.progressBar1);
            this.pLoadParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadParameters.Location = new System.Drawing.Point(3, 3);
            this.pLoadParameters.Name = "pLoadParameters";
            this.pLoadParameters.Size = new System.Drawing.Size(666, 355);
            this.pLoadParameters.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(4, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Getting parameters...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pLoadStations
            // 
            this.pLoadStations.Controls.Add(this.label3);
            this.pLoadStations.Controls.Add(this.progressBar2);
            this.pLoadStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadStations.Location = new System.Drawing.Point(3, 3);
            this.pLoadStations.Name = "pLoadStations";
            this.pLoadStations.Size = new System.Drawing.Size(666, 355);
            this.pLoadStations.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(4, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Getting stations...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar2.Location = new System.Drawing.Point(227, 144);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(213, 36);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar2.TabIndex = 1;
            // 
            // pLoadPeriods
            // 
            this.pLoadPeriods.Controls.Add(this.label4);
            this.pLoadPeriods.Controls.Add(this.progressBar3);
            this.pLoadPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadPeriods.Location = new System.Drawing.Point(3, 3);
            this.pLoadPeriods.Name = "pLoadPeriods";
            this.pLoadPeriods.Size = new System.Drawing.Size(666, 355);
            this.pLoadPeriods.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(4, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(659, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Getting periods...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar3.Location = new System.Drawing.Point(227, 144);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(213, 36);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar3.TabIndex = 1;
            // 
            // pLoadData
            // 
            this.pLoadData.Controls.Add(this.label5);
            this.pLoadData.Controls.Add(this.progressBar4);
            this.pLoadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadData.Location = new System.Drawing.Point(3, 3);
            this.pLoadData.Name = "pLoadData";
            this.pLoadData.Size = new System.Drawing.Size(666, 355);
            this.pLoadData.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(4, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(659, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Getting data...";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar4
            // 
            this.progressBar4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar4.Location = new System.Drawing.Point(227, 144);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(213, 36);
            this.progressBar4.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar4.TabIndex = 1;
            // 
            // chartData
            // 
            this.chartData.BackColor = System.Drawing.SystemColors.Window;
            chartArea5.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea5);
            this.chartData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartData.Location = new System.Drawing.Point(3, 3);
            this.chartData.Name = "chartData";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series5.BackSecondaryColor = System.Drawing.SystemColors.GradientActiveCaption;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.SystemColors.HotTrack;
            series5.IsVisibleInLegend = false;
            series5.MarkerBorderColor = System.Drawing.SystemColors.HotTrack;
            series5.MarkerColor = System.Drawing.SystemColors.Highlight;
            series5.Name = "Series1";
            this.chartData.Series.Add(series5);
            this.chartData.Size = new System.Drawing.Size(666, 355);
            this.chartData.TabIndex = 6;
            this.chartData.Text = "chart1";
            // 
            // scStations
            // 
            this.scStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scStations.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scStations.IsSplitterFixed = true;
            this.scStations.Location = new System.Drawing.Point(3, 3);
            this.scStations.Name = "scStations";
            this.scStations.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scStations.Panel1
            // 
            this.scStations.Panel1.Controls.Add(this.cbExcludeOld);
            this.scStations.Panel1.Controls.Add(this.label7);
            this.scStations.Panel1.Controls.Add(this.label6);
            this.scStations.Panel1.Controls.Add(this.tbLatitude);
            this.scStations.Panel1.Controls.Add(this.bFindNearest);
            this.scStations.Panel1.Controls.Add(this.tbLongitude);
            // 
            // scStations.Panel2
            // 
            this.scStations.Panel2.Controls.Add(this.olvStations);
            this.scStations.Size = new System.Drawing.Size(666, 355);
            this.scStations.SplitterDistance = 36;
            this.scStations.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Latitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Longitude:";
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(247, 4);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(100, 20);
            this.tbLatitude.TabIndex = 1;
            // 
            // bFindNearest
            // 
            this.bFindNearest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFindNearest.Location = new System.Drawing.Point(529, 2);
            this.bFindNearest.Name = "bFindNearest";
            this.bFindNearest.Size = new System.Drawing.Size(132, 25);
            this.bFindNearest.TabIndex = 3;
            this.bFindNearest.Text = "Find closest station";
            this.bFindNearest.UseVisualStyleBackColor = true;
            this.bFindNearest.Click += new System.EventHandler(this.bFindNearest_Click);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(76, 4);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(100, 20);
            this.tbLongitude.TabIndex = 0;
            // 
            // olvStations
            // 
            this.olvStations.AllColumns.Add(this.olvColumn3);
            this.olvStations.AllColumns.Add(this.olvColumn4);
            this.olvStations.AllColumns.Add(this.olvColumn5);
            this.olvStations.CellEditUseWholeCell = false;
            this.olvStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.olvStations.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvStations.FullRowSelect = true;
            this.olvStations.HideSelection = false;
            this.olvStations.Location = new System.Drawing.Point(0, 0);
            this.olvStations.Name = "olvStations";
            this.olvStations.ShowGroups = false;
            this.olvStations.Size = new System.Drawing.Size(666, 315);
            this.olvStations.TabIndex = 2;
            this.olvStations.UseCompatibleStateImageBehavior = false;
            this.olvStations.View = System.Windows.Forms.View.Details;
            this.olvStations.SelectedIndexChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Name";
            this.olvColumn3.FillsFreeSpace = true;
            this.olvColumn3.Text = "Name";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Summary";
            this.olvColumn4.Text = "Summary";
            this.olvColumn4.Width = 280;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Updated";
            this.olvColumn5.Text = "Updated";
            this.olvColumn5.Width = 180;
            // 
            // cbExcludeOld
            // 
            this.cbExcludeOld.AutoSize = true;
            this.cbExcludeOld.Location = new System.Drawing.Point(359, 6);
            this.cbExcludeOld.Name = "cbExcludeOld";
            this.cbExcludeOld.Size = new System.Drawing.Size(81, 17);
            this.cbExcludeOld.TabIndex = 2;
            this.cbExcludeOld.Text = "Exclude old";
            this.cbExcludeOld.UseVisualStyleBackColor = true;
            // 
            // FormSMHISharpExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormSMHISharpExample";
            this.Text = "SMHISharp Example";
            this.groupBox1.ResumeLayout(false);
            this.wizard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvParameters)).EndInit();
            this.tpStations.ResumeLayout(false);
            this.tpPeriods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPeriods)).EndInit();
            this.tpData.ResumeLayout(false);
            this.pLoadParameters.ResumeLayout(false);
            this.pLoadStations.ResumeLayout(false);
            this.pLoadPeriods.ResumeLayout(false);
            this.pLoadData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.scStations.Panel1.ResumeLayout(false);
            this.scStations.Panel1.PerformLayout();
            this.scStations.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scStations)).EndInit();
            this.scStations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvStations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvParameters;
        private System.Windows.Forms.Button bPrevious;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Button bNext;
        private Controls.TabWizard.TabWizardControl wizard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpParameters;
        private System.Windows.Forms.TabPage tpStations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpPeriods;
        private System.Windows.Forms.TabPage tpData;
        private BrightIdeasSoftware.ObjectListView olvPeriods;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private System.Windows.Forms.Panel pLoadParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pLoadStations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel pLoadPeriods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Panel pLoadData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.SplitContainer scStations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Button bFindNearest;
        private System.Windows.Forms.TextBox tbLongitude;
        private BrightIdeasSoftware.ObjectListView olvStations;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.CheckBox cbExcludeOld;
    }
}

