namespace FinalProjectClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(403, 45);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Прогноз";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(9, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(189, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 27);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Широта:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 27);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Довгота:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 76);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данні для введеня";
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(21, 99);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(435, 100);
            cartesianChart1.TabIndex = 6;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(21, 235);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(435, 100);
            cartesianChart2.TabIndex = 7;
            cartesianChart2.Text = "cartesianChart2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 217);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 8;
            label3.Text = "Температура";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 356);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Вологість";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 393);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cartesianChart2);
            Controls.Add(cartesianChart1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Прогноз погоди";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private Label label3;
        private Label label4;
    }
}
