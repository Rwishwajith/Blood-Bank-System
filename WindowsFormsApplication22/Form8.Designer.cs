namespace WindowsFormsApplication22
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.insertdataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bloodmanagementDataSet = new WindowsFormsApplication22.bloodmanagementDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.insertdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insert_dataTableAdapter = new WindowsFormsApplication22.bloodmanagementDataSetTableAdapters.insert_dataTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertdataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodmanagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertdataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.insertdataBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 63);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "A+";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "A_";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(634, 332);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // insertdataBindingSource1
            // 
            this.insertdataBindingSource1.DataMember = "insert_data";
            this.insertdataBindingSource1.DataSource = this.bloodmanagementDataSet;
            // 
            // bloodmanagementDataSet
            // 
            this.bloodmanagementDataSet.DataSetName = "bloodmanagementDataSet";
            this.bloodmanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertdataBindingSource
            // 
            this.insertdataBindingSource.DataMember = "insert_data";
            this.insertdataBindingSource.DataSource = this.bloodmanagementDataSet;
            // 
            // insert_dataTableAdapter
            // 
            this.insert_dataTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Send Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(68, 401);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertdataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodmanagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertdataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private bloodmanagementDataSet bloodmanagementDataSet;
        private System.Windows.Forms.BindingSource insertdataBindingSource;
        private bloodmanagementDataSetTableAdapters.insert_dataTableAdapter insert_dataTableAdapter;
        private System.Windows.Forms.BindingSource insertdataBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnback;
    }
}