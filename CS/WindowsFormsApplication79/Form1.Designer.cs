﻿namespace WindowsFormsApplication79 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint12 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(15.5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint13 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(8.7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint14 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(16.7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint15 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(14.3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint16 = new DevExpress.XtraCharts.SeriesPoint("E", new object[] {
            ((object)(12.1D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint17 = new DevExpress.XtraCharts.SeriesPoint("F", new object[] {
            ((object)(13.7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint18 = new DevExpress.XtraCharts.SeriesPoint("G", new object[] {
            ((object)(14.2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint19 = new DevExpress.XtraCharts.SeriesPoint("H", new object[] {
            ((object)(10.8D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint20 = new DevExpress.XtraCharts.SeriesPoint("I", new object[] {
            ((object)(15.2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint21 = new DevExpress.XtraCharts.SeriesPoint("J", new object[] {
            ((object)(12.3D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint22 = new DevExpress.XtraCharts.SeriesPoint("K", new object[] {
            ((object)(10.1D))});
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram2.AxisX.VisualRange.AutoSideMargins = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.WholeRange.AutoSideMargins = true;
            xyDiagram2.AxisY.VisualRange.AutoSideMargins = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visibility =  DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "In A Fog";
            sideBySideBarSeriesLabel3.LineVisibility =  DevExpress.Utils.DefaultBoolean.True;
            series2.Label = sideBySideBarSeriesLabel3;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Series 1";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint12,
            seriesPoint13,
            seriesPoint14,
            seriesPoint15,
            seriesPoint16,
            seriesPoint17,
            seriesPoint18,
            seriesPoint19,
            seriesPoint20,
            seriesPoint21,
            seriesPoint22});
            sideBySideBarSeriesView2.ColorEach = true;
            series2.View = sideBySideBarSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            sideBySideBarSeriesLabel4.LineVisibility =  DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel4;
            this.chartControl1.Size = new System.Drawing.Size(491, 307);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartControl1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 307);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}

