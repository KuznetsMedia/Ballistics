namespace WindowsFormsApp3
{
    partial class MoveGraph
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.znach_g = new System.Windows.Forms.ComboBox();
            this.angle_box = new System.Windows.Forms.TextBox();
            this.v0_box = new System.Windows.Forms.TextBox();
            this.t_box = new System.Windows.Forms.TextBox();
            this.s_box = new System.Windows.Forms.TextBox();
            this.h_box = new System.Windows.Forms.TextBox();
            this.angle_text = new System.Windows.Forms.TextBox();
            this.s_text = new System.Windows.Forms.TextBox();
            this.h_text = new System.Windows.Forms.TextBox();
            this.v0_text = new System.Windows.Forms.TextBox();
            this.t_text = new System.Windows.Forms.TextBox();
            this.Izvest = new System.Windows.Forms.ComboBox();
            this.Znach1_text = new System.Windows.Forms.TextBox();
            this.Znach2_text = new System.Windows.Forms.TextBox();
            this.Znach2_box = new System.Windows.Forms.TextBox();
            this.Znach1_box = new System.Windows.Forms.TextBox();
            this.PointBar = new System.Windows.Forms.TrackBar();
            this.title_pointBar = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PointBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(1692, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запустить решение";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // znach_g
            // 
            this.znach_g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.znach_g.ForeColor = System.Drawing.SystemColors.Menu;
            this.znach_g.FormattingEnabled = true;
            this.znach_g.Location = new System.Drawing.Point(1575, 48);
            this.znach_g.Name = "znach_g";
            this.znach_g.Size = new System.Drawing.Size(199, 28);
            this.znach_g.TabIndex = 18;
            this.znach_g.Text = "Значение g";
            this.znach_g.SelectedIndexChanged += new System.EventHandler(this.znach_g_SelectedIndexChanged);
            // 
            // angle_box
            // 
            this.angle_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.angle_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.angle_box.Location = new System.Drawing.Point(1782, 375);
            this.angle_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.angle_box.Name = "angle_box";
            this.angle_box.ReadOnly = true;
            this.angle_box.Size = new System.Drawing.Size(129, 26);
            this.angle_box.TabIndex = 27;
            this.angle_box.TextChanged += new System.EventHandler(this.angle_box_TextChanged);
            // 
            // v0_box
            // 
            this.v0_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.v0_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.v0_box.Location = new System.Drawing.Point(1782, 411);
            this.v0_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.v0_box.Name = "v0_box";
            this.v0_box.ReadOnly = true;
            this.v0_box.Size = new System.Drawing.Size(129, 26);
            this.v0_box.TabIndex = 28;
            this.v0_box.TextChanged += new System.EventHandler(this.v0_box_TextChanged);
            // 
            // t_box
            // 
            this.t_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.t_box.Location = new System.Drawing.Point(1783, 447);
            this.t_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_box.Name = "t_box";
            this.t_box.ReadOnly = true;
            this.t_box.Size = new System.Drawing.Size(129, 26);
            this.t_box.TabIndex = 29;
            this.t_box.TextChanged += new System.EventHandler(this.t_box_TextChanged);
            // 
            // s_box
            // 
            this.s_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.s_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.s_box.Location = new System.Drawing.Point(1783, 519);
            this.s_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.s_box.Name = "s_box";
            this.s_box.ReadOnly = true;
            this.s_box.Size = new System.Drawing.Size(129, 26);
            this.s_box.TabIndex = 30;
            this.s_box.TextChanged += new System.EventHandler(this.s_box_TextChanged);
            // 
            // h_box
            // 
            this.h_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.h_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.h_box.Location = new System.Drawing.Point(1783, 483);
            this.h_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.h_box.Name = "h_box";
            this.h_box.ReadOnly = true;
            this.h_box.Size = new System.Drawing.Size(129, 26);
            this.h_box.TabIndex = 31;
            this.h_box.TextChanged += new System.EventHandler(this.h_box_TextChanged);
            // 
            // angle_text
            // 
            this.angle_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.angle_text.ForeColor = System.Drawing.SystemColors.Menu;
            this.angle_text.Location = new System.Drawing.Point(1575, 375);
            this.angle_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.angle_text.Name = "angle_text";
            this.angle_text.ReadOnly = true;
            this.angle_text.Size = new System.Drawing.Size(199, 26);
            this.angle_text.TabIndex = 32;
            this.angle_text.Text = "Угол запуска";
            this.angle_text.TextChanged += new System.EventHandler(this.angle_text_TextChanged);
            // 
            // s_text
            // 
            this.s_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.s_text.ForeColor = System.Drawing.SystemColors.Menu;
            this.s_text.Location = new System.Drawing.Point(1576, 519);
            this.s_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.s_text.Name = "s_text";
            this.s_text.ReadOnly = true;
            this.s_text.Size = new System.Drawing.Size(199, 26);
            this.s_text.TabIndex = 33;
            this.s_text.Text = "Пройденное расстояние";
            this.s_text.TextChanged += new System.EventHandler(this.s_text_TextChanged);
            // 
            // h_text
            // 
            this.h_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.h_text.ForeColor = System.Drawing.SystemColors.Menu;
            this.h_text.Location = new System.Drawing.Point(1576, 483);
            this.h_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.h_text.Name = "h_text";
            this.h_text.ReadOnly = true;
            this.h_text.Size = new System.Drawing.Size(199, 26);
            this.h_text.TabIndex = 34;
            this.h_text.Text = "Максимальная высота";
            this.h_text.TextChanged += new System.EventHandler(this.h_text_TextChanged);
            // 
            // v0_text
            // 
            this.v0_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.v0_text.ForeColor = System.Drawing.SystemColors.Menu;
            this.v0_text.Location = new System.Drawing.Point(1575, 411);
            this.v0_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.v0_text.Name = "v0_text";
            this.v0_text.ReadOnly = true;
            this.v0_text.Size = new System.Drawing.Size(199, 26);
            this.v0_text.TabIndex = 35;
            this.v0_text.Text = "Начальная скорость";
            this.v0_text.TextChanged += new System.EventHandler(this.v0_text_TextChanged);
            // 
            // t_text
            // 
            this.t_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.t_text.ForeColor = System.Drawing.SystemColors.Menu;
            this.t_text.Location = new System.Drawing.Point(1576, 447);
            this.t_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_text.Name = "t_text";
            this.t_text.ReadOnly = true;
            this.t_text.Size = new System.Drawing.Size(199, 26);
            this.t_text.TabIndex = 36;
            this.t_text.Text = "Время полёта";
            this.t_text.TextChanged += new System.EventHandler(this.t_text_TextChanged);
            // 
            // Izvest
            // 
            this.Izvest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Izvest.ForeColor = System.Drawing.SystemColors.Menu;
            this.Izvest.FormattingEnabled = true;
            this.Izvest.Location = new System.Drawing.Point(1575, 14);
            this.Izvest.Name = "Izvest";
            this.Izvest.Size = new System.Drawing.Size(336, 28);
            this.Izvest.TabIndex = 37;
            this.Izvest.Text = "Виды вычисления";
            this.Izvest.SelectedIndexChanged += new System.EventHandler(this.Izvest_SelectedIndexChanged);
            // 
            // Znach1_text
            // 
            this.Znach1_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Znach1_text.ForeColor = System.Drawing.SystemColors.Menu;
            this.Znach1_text.Location = new System.Drawing.Point(1575, 84);
            this.Znach1_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Znach1_text.Name = "Znach1_text";
            this.Znach1_text.ReadOnly = true;
            this.Znach1_text.Size = new System.Drawing.Size(199, 26);
            this.Znach1_text.TabIndex = 38;
            // 
            // Znach2_text
            // 
            this.Znach2_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Znach2_text.ForeColor = System.Drawing.SystemColors.Menu;
            this.Znach2_text.Location = new System.Drawing.Point(1575, 120);
            this.Znach2_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Znach2_text.Name = "Znach2_text";
            this.Znach2_text.ReadOnly = true;
            this.Znach2_text.Size = new System.Drawing.Size(199, 26);
            this.Znach2_text.TabIndex = 39;
            // 
            // Znach2_box
            // 
            this.Znach2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Znach2_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.Znach2_box.Location = new System.Drawing.Point(1782, 120);
            this.Znach2_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Znach2_box.Name = "Znach2_box";
            this.Znach2_box.Size = new System.Drawing.Size(129, 26);
            this.Znach2_box.TabIndex = 41;
            // 
            // Znach1_box
            // 
            this.Znach1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Znach1_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.Znach1_box.Location = new System.Drawing.Point(1782, 84);
            this.Znach1_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Znach1_box.Name = "Znach1_box";
            this.Znach1_box.Size = new System.Drawing.Size(129, 26);
            this.Znach1_box.TabIndex = 40;
            // 
            // PointBar
            // 
            this.PointBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PointBar.LargeChange = 1;
            this.PointBar.Location = new System.Drawing.Point(1575, 227);
            this.PointBar.Maximum = 7;
            this.PointBar.Name = "PointBar";
            this.PointBar.Size = new System.Drawing.Size(336, 69);
            this.PointBar.TabIndex = 42;
            this.PointBar.Scroll += new System.EventHandler(this.PointBar_Scroll);
            // 
            // title_pointBar
            // 
            this.title_pointBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.title_pointBar.ForeColor = System.Drawing.SystemColors.Menu;
            this.title_pointBar.Location = new System.Drawing.Point(1575, 195);
            this.title_pointBar.Name = "title_pointBar";
            this.title_pointBar.ReadOnly = true;
            this.title_pointBar.Size = new System.Drawing.Size(336, 26);
            this.title_pointBar.TabIndex = 43;
            this.title_pointBar.Text = "Количество знаков после запятой";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clear.ForeColor = System.Drawing.SystemColors.Menu;
            this.Clear.Location = new System.Drawing.Point(1574, 553);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(111, 60);
            this.Clear.TabIndex = 44;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.SystemColors.Menu;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Траектория\\nПолёта\\nТела";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1556, 906);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(1576, 619);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(336, 299);
            this.chart2.TabIndex = 45;
            this.chart2.Text = "chart2";
            // 
            // MoveGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1924, 962);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.title_pointBar);
            this.Controls.Add(this.PointBar);
            this.Controls.Add(this.Znach2_box);
            this.Controls.Add(this.Znach1_box);
            this.Controls.Add(this.Znach2_text);
            this.Controls.Add(this.Znach1_text);
            this.Controls.Add(this.Izvest);
            this.Controls.Add(this.t_text);
            this.Controls.Add(this.v0_text);
            this.Controls.Add(this.h_text);
            this.Controls.Add(this.s_text);
            this.Controls.Add(this.angle_text);
            this.Controls.Add(this.h_box);
            this.Controls.Add(this.s_box);
            this.Controls.Add(this.t_box);
            this.Controls.Add(this.v0_box);
            this.Controls.Add(this.angle_box);
            this.Controls.Add(this.znach_g);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(22, 1018);
            this.Name = "MoveGraph";
            this.Text = "График движения тела, брошенного под углом";
            this.Load += new System.EventHandler(this.Parabola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PointBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox znach_g;
        private System.Windows.Forms.TextBox angle_box;
        private System.Windows.Forms.TextBox v0_box;
        private System.Windows.Forms.TextBox t_box;
        private System.Windows.Forms.TextBox s_box;
        private System.Windows.Forms.TextBox h_box;
        private System.Windows.Forms.TextBox angle_text;
        private System.Windows.Forms.TextBox s_text;
        private System.Windows.Forms.TextBox h_text;
        private System.Windows.Forms.TextBox v0_text;
        private System.Windows.Forms.TextBox t_text;
        private System.Windows.Forms.ComboBox Izvest;
        private System.Windows.Forms.TextBox Znach1_text;
        private System.Windows.Forms.TextBox Znach2_text;
        private System.Windows.Forms.TextBox Znach2_box;
        private System.Windows.Forms.TextBox Znach1_box;
        private System.Windows.Forms.TrackBar PointBar;
        private System.Windows.Forms.TextBox title_pointBar;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

