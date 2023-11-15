﻿namespace CapaPresentacion
{
    partial class frmGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOkCustomDate = new FontAwesome.Sharp.IconButton();
            this.btnThisMonth = new FontAwesome.Sharp.IconButton();
            this.btnLast30Days = new FontAwesome.Sharp.IconButton();
            this.btnLast7Days = new FontAwesome.Sharp.IconButton();
            this.btnToday = new FontAwesome.Sharp.IconButton();
            this.btnCustomDate = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(879, 128);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(144, 22);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(1041, 128);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(144, 22);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(13, 20);
            this.lblTotalProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(83, 29);
            this.lblTotalProfit.TabIndex = 9;
            this.lblTotalProfit.Text = "10000";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.DimGray;
            this.chartGrossRevenue.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea3.BackColor = System.Drawing.Color.DimGray;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.IndianRed;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.CursorX.LineColor = System.Drawing.Color.White;
            chartArea3.CursorX.SelectionColor = System.Drawing.Color.White;
            chartArea3.CursorY.LineColor = System.Drawing.Color.White;
            chartArea3.CursorY.SelectionColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.IndianRed;
            this.chartGrossRevenue.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.DimGray;
            legend3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            legend3.BackSecondaryColor = System.Drawing.Color.IndianRed;
            legend3.BorderColor = System.Drawing.Color.IndianRed;
            legend3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.InterlacedRowsColor = System.Drawing.Color.DimGray;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.Gray;
            legend3.TitleAlignment = System.Drawing.StringAlignment.Far;
            legend3.TitleBackColor = System.Drawing.Color.White;
            legend3.TitleForeColor = System.Drawing.Color.White;
            legend3.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartGrossRevenue.Legends.Add(legend3);
            this.chartGrossRevenue.Location = new System.Drawing.Point(7, 22);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series3.BackImageTransparentColor = System.Drawing.Color.White;
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea1";
            series3.LabelBackColor = System.Drawing.Color.DimGray;
            series3.LabelBorderColor = System.Drawing.Color.Gray;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.DimGray;
            series3.MarkerColor = System.Drawing.Color.Gray;
            series3.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series3);
            this.chartGrossRevenue.Size = new System.Drawing.Size(817, 230);
            this.chartGrossRevenue.TabIndex = 12;
            this.chartGrossRevenue.Text = "chart1";
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.BackColor = System.Drawing.Color.DimGray;
            this.chartTopProducts.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartTopProducts.BackSecondaryColor = System.Drawing.Color.White;
            this.chartTopProducts.BorderlineColor = System.Drawing.SystemColors.ControlDarkDark;
            chartArea4.BackColor = System.Drawing.Color.DimGray;
            chartArea4.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.BorderColor = System.Drawing.Color.White;
            chartArea4.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.DimGray;
            legend4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            legend4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            legend4.BackImageTransparentColor = System.Drawing.Color.Gray;
            legend4.BackSecondaryColor = System.Drawing.Color.DimGray;
            legend4.BorderColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.HeaderSeparatorColor = System.Drawing.Color.White;
            legend4.InterlacedRowsColor = System.Drawing.Color.White;
            legend4.IsEquallySpacedItems = true;
            legend4.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            legend4.TitleBackColor = System.Drawing.Color.WhiteSmoke;
            legend4.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.TitleForeColor = System.Drawing.Color.White;
            legend4.TitleSeparatorColor = System.Drawing.Color.White;
            this.chartTopProducts.Legends.Add(legend4);
            this.chartTopProducts.Location = new System.Drawing.Point(7, 18);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartTopProducts.Name = "chartTopProducts";
            series4.BackImageTransparentColor = System.Drawing.Color.Gray;
            series4.BackSecondaryColor = System.Drawing.Color.DimGray;
            series4.BorderColor = System.Drawing.Color.Transparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.DimGray;
            series4.CustomProperties = "PieLineColor=DimGray, CollectedColor=64\\, 64\\, 64";
            series4.EmptyPointStyle.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.CustomProperties = "PieLineColor=64\\, 64\\, 64";
            series4.EmptyPointStyle.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.EmptyPointStyle.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series4.IsValueShownAsLabel = true;
            series4.LabelBackColor = System.Drawing.Color.Transparent;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.Black;
            series4.MarkerColor = System.Drawing.Color.Black;
            series4.MarkerImageTransparentColor = System.Drawing.Color.White;
            series4.Name = "Series1";
            series4.ShadowColor = System.Drawing.Color.White;
            this.chartTopProducts.Series.Add(series4);
            this.chartTopProducts.Size = new System.Drawing.Size(521, 512);
            this.chartTopProducts.TabIndex = 13;
            this.chartTopProducts.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Top 5 Productos";
            this.chartTopProducts.Titles.Add(title2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 128);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Productos Diferentes";
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.ForeColor = System.Drawing.Color.White;
            this.lblNumProducts.Location = new System.Drawing.Point(28, 155);
            this.lblNumProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(83, 29);
            this.lblNumProducts.TabIndex = 11;
            this.lblNumProducts.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Numero de Clientes";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.ForeColor = System.Drawing.Color.White;
            this.lblNumCustomers.Location = new System.Drawing.Point(28, 79);
            this.lblNumCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(83, 29);
            this.lblNumCustomers.TabIndex = 9;
            this.lblNumCustomers.Text = "10000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(39, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 36);
            this.label14.TabIndex = 14;
            this.label14.Text = "Estadisticas";
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(7, 22);
            this.dgvUnderstock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.Size = new System.Drawing.Size(580, 231);
            this.dgvUnderstock.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.groupBox7);
            this.panel6.Controls.Add(this.dtpEndDate);
            this.panel6.Controls.Add(this.dtpStartDate);
            this.panel6.Controls.Add(this.groupBox6);
            this.panel6.Controls.Add(this.groupBox5);
            this.panel6.Controls.Add(this.groupBox4);
            this.panel6.Controls.Add(this.btnOkCustomDate);
            this.panel6.Controls.Add(this.btnThisMonth);
            this.panel6.Controls.Add(this.btnLast30Days);
            this.panel6.Controls.Add(this.btnLast7Days);
            this.panel6.Controls.Add(this.btnToday);
            this.panel6.Controls.Add(this.btnCustomDate);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Location = new System.Drawing.Point(25, 14);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1473, 736);
            this.panel6.TabIndex = 18;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chartTopProducts);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(909, 172);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(537, 542);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblNumOrders);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(39, 89);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(221, 60);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cantidad de Ventas";
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(13, 20);
            this.lblNumOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(83, 29);
            this.lblNumOrders.TabIndex = 9;
            this.lblNumOrders.Text = "10000";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalRevenue);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(288, 89);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(240, 60);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ingresos Totales";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(13, 20);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(83, 29);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "10000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalProfit);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(549, 89);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(251, 60);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ganancias Totales";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkCustomDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOkCustomDate.IconColor = System.Drawing.Color.Black;
            this.btnOkCustomDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOkCustomDate.Location = new System.Drawing.Point(1215, 123);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(67, 34);
            this.btnOkCustomDate.TabIndex = 24;
            this.btnOkCustomDate.Text = "OK";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click_1);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThisMonth.IconColor = System.Drawing.Color.Black;
            this.btnThisMonth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThisMonth.Location = new System.Drawing.Point(1304, 55);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(143, 34);
            this.btnThisMonth.TabIndex = 23;
            this.btnThisMonth.Text = "Meses";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Days.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLast30Days.IconColor = System.Drawing.Color.Black;
            this.btnLast30Days.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLast30Days.Location = new System.Drawing.Point(1153, 57);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(143, 34);
            this.btnLast30Days.TabIndex = 22;
            this.btnLast30Days.Text = "Ultimos 30 dias";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click_1);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLast7Days.IconColor = System.Drawing.Color.Black;
            this.btnLast7Days.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLast7Days.Location = new System.Drawing.Point(1000, 57);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(143, 34);
            this.btnLast7Days.TabIndex = 21;
            this.btnLast7Days.Text = "Ultimos 7 dias";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click_1);
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnToday.IconColor = System.Drawing.Color.Black;
            this.btnToday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToday.Location = new System.Drawing.Point(847, 57);
            this.btnToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(143, 34);
            this.btnToday.TabIndex = 20;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click_1);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCustomDate.IconColor = System.Drawing.Color.Black;
            this.btnCustomDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomDate.Location = new System.Drawing.Point(1296, 123);
            this.btnCustomDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(143, 34);
            this.btnCustomDate.TabIndex = 19;
            this.btnCustomDate.Text = "Periodos";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblNumCustomers);
            this.groupBox3.Controls.Add(this.lblNumProducts);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(39, 453);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(221, 261);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contador Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUnderstock);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(288, 453);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(595, 261);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos de bajo stock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartGrossRevenue);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(39, 172);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(844, 261);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingresos brutos";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(85, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1525, 761);
            this.panel2.TabIndex = 19;
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 770);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGraficos";
            this.Text = "frmGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnOkCustomDate;
        private FontAwesome.Sharp.IconButton btnThisMonth;
        private FontAwesome.Sharp.IconButton btnLast30Days;
        private FontAwesome.Sharp.IconButton btnLast7Days;
        private FontAwesome.Sharp.IconButton btnToday;
        private FontAwesome.Sharp.IconButton btnCustomDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel2;
    }
}