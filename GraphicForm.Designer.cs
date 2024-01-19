namespace practice_course_2
{
    partial class GraphicForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart2 = new LiveCharts.Wpf.CartesianChart();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "График населения административных округов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(125, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "График площадей административных округов";
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(12, 120);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(969, 405);
            this.elementHost2.TabIndex = 1;
            this.elementHost2.Text = "elementHost1";
            this.elementHost2.Child = this.cartesianChart1;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(1057, 120);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(976, 405);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart2;
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1024);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GraphicForm";
            this.Text = "GraphicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart2;
    }
}