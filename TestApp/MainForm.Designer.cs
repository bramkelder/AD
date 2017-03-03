﻿namespace TestApp
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
            if(disposing && (components != null))
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
            this.logBox = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCollections = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.collectionsListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabSorting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sortingListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.sortingUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.sortingComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sortingIterations = new System.Windows.Forms.NumericUpDown();
            this.tabSearching = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.searchingListBox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.searchingUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.searchingDataMethod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.searchingIterations = new System.Windows.Forms.NumericUpDown();
            this.searchingLocation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testProgressBar = new System.Windows.Forms.ProgressBar();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabCollections.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabSorting.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortingIterations)).BeginInit();
            this.tabSearching.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchingIterations)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(18, 378);
            this.logBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(854, 296);
            this.logBox.TabIndex = 0;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(640, 334);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(112, 35);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run test";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabCollections);
            this.tabControl.Controls.Add(this.tabSorting);
            this.tabControl.Controls.Add(this.tabSearching);
            this.tabControl.Location = new System.Drawing.Point(18, 42);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.MinimumSize = new System.Drawing.Size(856, 288);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(856, 288);
            this.tabControl.TabIndex = 2;
            // 
            // tabCollections
            // 
            this.tabCollections.Controls.Add(this.tableLayoutPanel1);
            this.tabCollections.Location = new System.Drawing.Point(4, 29);
            this.tabCollections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCollections.Name = "tabCollections";
            this.tabCollections.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCollections.Size = new System.Drawing.Size(848, 255);
            this.tabCollections.TabIndex = 0;
            this.tabCollections.Text = "Collections";
            this.tabCollections.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54407F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45593F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Controls.Add(this.collectionsListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 235);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // collectionsListBox
            // 
            this.collectionsListBox.CheckOnClick = true;
            this.collectionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionsListBox.FormattingEnabled = true;
            this.collectionsListBox.Location = new System.Drawing.Point(4, 25);
            this.collectionsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.collectionsListBox.Name = "collectionsListBox";
            this.collectionsListBox.Size = new System.Drawing.Size(272, 207);
            this.collectionsListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Collections";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // tabSorting
            // 
            this.tabSorting.Controls.Add(this.tableLayoutPanel2);
            this.tabSorting.Location = new System.Drawing.Point(4, 29);
            this.tabSorting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSorting.Name = "tabSorting";
            this.tabSorting.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSorting.Size = new System.Drawing.Size(848, 255);
            this.tabSorting.TabIndex = 1;
            this.tabSorting.Text = "Sorting";
            this.tabSorting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54407F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45593F));
            this.tableLayoutPanel2.Controls.Add(this.sortingListBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(840, 245);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // sortingListBox
            // 
            this.sortingListBox.CheckOnClick = true;
            this.sortingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortingListBox.FormattingEnabled = true;
            this.sortingListBox.Location = new System.Drawing.Point(4, 25);
            this.sortingListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortingListBox.Name = "sortingListBox";
            this.sortingListBox.Size = new System.Drawing.Size(408, 215);
            this.sortingListBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sorting algorithms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Test data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.sortingUpDown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.sortingComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.sortingIterations, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(420, 25);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(416, 215);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // sortingUpDown
            // 
            this.sortingUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortingUpDown.Location = new System.Drawing.Point(137, 5);
            this.sortingUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortingUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.sortingUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sortingUpDown.Name = "sortingUpDown";
            this.sortingUpDown.Size = new System.Drawing.Size(275, 26);
            this.sortingUpDown.TabIndex = 0;
            this.sortingUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount of items";
            // 
            // sortingComboBox
            // 
            this.sortingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortingComboBox.FormattingEnabled = true;
            this.sortingComboBox.Items.AddRange(new object[] {
            "Random",
            "Ascending",
            "Descending"});
            this.sortingComboBox.Location = new System.Drawing.Point(137, 41);
            this.sortingComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortingComboBox.Name = "sortingComboBox";
            this.sortingComboBox.Size = new System.Drawing.Size(275, 28);
            this.sortingComboBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Iterations";
            // 
            // sortingIterations
            // 
            this.sortingIterations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortingIterations.Location = new System.Drawing.Point(137, 79);
            this.sortingIterations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortingIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sortingIterations.Name = "sortingIterations";
            this.sortingIterations.Size = new System.Drawing.Size(275, 26);
            this.sortingIterations.TabIndex = 5;
            this.sortingIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabSearching
            // 
            this.tabSearching.Controls.Add(this.tableLayoutPanel4);
            this.tabSearching.Location = new System.Drawing.Point(4, 29);
            this.tabSearching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearching.Name = "tabSearching";
            this.tabSearching.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSearching.Size = new System.Drawing.Size(848, 255);
            this.tabSearching.TabIndex = 2;
            this.tabSearching.Text = "Searching";
            this.tabSearching.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54407F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45593F));
            this.tableLayoutPanel4.Controls.Add(this.searchingListBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(840, 245);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // searchingListBox
            // 
            this.searchingListBox.CheckOnClick = true;
            this.searchingListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchingListBox.FormattingEnabled = true;
            this.searchingListBox.Location = new System.Drawing.Point(4, 25);
            this.searchingListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchingListBox.Name = "searchingListBox";
            this.searchingListBox.Size = new System.Drawing.Size(408, 215);
            this.searchingListBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Search algorithms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Test data";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.searchingUpDown, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.searchingDataMethod, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.searchingIterations, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.searchingLocation, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(420, 25);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(416, 215);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // searchingUpDown
            // 
            this.searchingUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchingUpDown.Location = new System.Drawing.Point(137, 5);
            this.searchingUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchingUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.searchingUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.searchingUpDown.Name = "searchingUpDown";
            this.searchingUpDown.Size = new System.Drawing.Size(275, 26);
            this.searchingUpDown.TabIndex = 0;
            this.searchingUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Amount of items";
            // 
            // searchingDataMethod
            // 
            this.searchingDataMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchingDataMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchingDataMethod.FormattingEnabled = true;
            this.searchingDataMethod.Items.AddRange(new object[] {
            "Random",
            "Ascending",
            "Descending"});
            this.searchingDataMethod.Location = new System.Drawing.Point(137, 41);
            this.searchingDataMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchingDataMethod.Name = "searchingDataMethod";
            this.searchingDataMethod.Size = new System.Drawing.Size(275, 28);
            this.searchingDataMethod.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Method";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Iterations";
            // 
            // searchingIterations
            // 
            this.searchingIterations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchingIterations.Location = new System.Drawing.Point(137, 79);
            this.searchingIterations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchingIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchingIterations.Name = "searchingIterations";
            this.searchingIterations.Size = new System.Drawing.Size(275, 26);
            this.searchingIterations.TabIndex = 5;
            this.searchingIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // searchingLocation
            // 
            this.searchingLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchingLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchingLocation.FormattingEnabled = true;
            this.searchingLocation.Items.AddRange(new object[] {
            "Start",
            "Middle",
            "End",
            "Random"});
            this.searchingLocation.Location = new System.Drawing.Point(137, 115);
            this.searchingLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchingLocation.Name = "searchingLocation";
            this.searchingLocation.Size = new System.Drawing.Size(275, 28);
            this.searchingLocation.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 118);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 8, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Item location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(894, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLogToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveLogToolStripMenuItem
            // 
            this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
            this.saveLogToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.saveLogToolStripMenuItem.Text = "Save log";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testProgressBar
            // 
            this.testProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testProgressBar.Location = new System.Drawing.Point(18, 334);
            this.testProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testProgressBar.Name = "testProgressBar";
            this.testProgressBar.Size = new System.Drawing.Size(614, 35);
            this.testProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.testProgressBar.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(760, 334);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 35);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 694);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.testProgressBar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(817, 533);
            this.Name = "MainForm";
            this.Text = "AD Library Testing - Unregistered version";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabCollections.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabSorting.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortingIterations)).EndInit();
            this.tabSearching.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchingIterations)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCollections;
        private System.Windows.Forms.TabPage tabSorting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox collectionsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox sortingListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown sortingUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sortingComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar testProgressBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown sortingIterations;
        private System.Windows.Forms.TabPage tabSearching;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckedListBox searchingListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown searchingUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox searchingDataMethod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown searchingIterations;
        private System.Windows.Forms.ComboBox searchingLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonClear;
    }
}

