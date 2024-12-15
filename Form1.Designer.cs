namespace MVPAreaFinder
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
            label1 = new Label();
            labelWidth = new Label();
            labelHeight = new Label();
            buttonCalculate = new Button();
            labelResult = new Label();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            comboBoxShapes = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(47, 20);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 0;
            label1.Text = "AREA FINDER WITH MVP PATERN DESIGN";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(12, 96);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(48, 15);
            labelWidth.TabIndex = 1;
            labelWidth.Text = "Width  :";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(12, 128);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(49, 15);
            labelHeight.TabIndex = 2;
            labelHeight.Text = "Height :";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(192, 62);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(106, 23);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelResult.Location = new Point(138, 175);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 21);
            labelResult.TabIndex = 4;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(71, 93);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(227, 23);
            textBoxWidth.TabIndex = 5;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(71, 125);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(227, 23);
            textBoxHeight.TabIndex = 6;
            // 
            // comboBoxShapes
            // 
            comboBoxShapes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShapes.FormattingEnabled = true;
            comboBoxShapes.Items.AddRange(new object[] { "Rectangle", "Square" });
            comboBoxShapes.Location = new Point(71, 62);
            comboBoxShapes.Name = "comboBoxShapes";
            comboBoxShapes.Size = new Size(115, 23);
            comboBoxShapes.TabIndex = 7;
            comboBoxShapes.SelectedIndexChanged += comboBoxShapes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 8;
            label2.Text = "Shape  :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 217);
            Controls.Add(label2);
            Controls.Add(comboBoxShapes);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(labelHeight);
            Controls.Add(labelWidth);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelWidth;
        private Label labelHeight;
        private Button buttonCalculate;
        private Label labelResult;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private ComboBox comboBoxShapes;
        private Label label2;
    }
}
