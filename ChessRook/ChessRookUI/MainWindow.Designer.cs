
namespace ChessRookUI
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullHeightTextBox = new System.Windows.Forms.TextBox();
            this.lowerDiameterTextBox = new System.Windows.Forms.TextBox();
            this.upperDiameterTextBox = new System.Windows.Forms.TextBox();
            this.upperHeightTextBox = new System.Windows.Forms.TextBox();
            this.lowerHeightTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.newFeaturesCheckBox = new System.Windows.Forms.CheckBox();
            this.featuresCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChessRookUI.Properties.Resources.rook1;
            this.pictureBox1.Location = new System.Drawing.Point(14, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота фигуры (A)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Диаметр нижнего основания (B)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Диаметр верхнего основания (C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Высота нижнего основания (D)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Высота верхнего основания (E)";
            // 
            // fullHeightTextBox
            // 
            this.fullHeightTextBox.Location = new System.Drawing.Point(271, 235);
            this.fullHeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullHeightTextBox.Name = "fullHeightTextBox";
            this.fullHeightTextBox.Size = new System.Drawing.Size(62, 27);
            this.fullHeightTextBox.TabIndex = 6;
            // 
            // lowerDiameterTextBox
            // 
            this.lowerDiameterTextBox.Location = new System.Drawing.Point(271, 277);
            this.lowerDiameterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lowerDiameterTextBox.Name = "lowerDiameterTextBox";
            this.lowerDiameterTextBox.Size = new System.Drawing.Size(62, 27);
            this.lowerDiameterTextBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.lowerDiameterTextBox, "Эта величина должна быть меньше величины С");
            // 
            // upperDiameterTextBox
            // 
            this.upperDiameterTextBox.Location = new System.Drawing.Point(271, 320);
            this.upperDiameterTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upperDiameterTextBox.Name = "upperDiameterTextBox";
            this.upperDiameterTextBox.Size = new System.Drawing.Size(62, 27);
            this.upperDiameterTextBox.TabIndex = 8;
            // 
            // upperHeightTextBox
            // 
            this.upperHeightTextBox.Location = new System.Drawing.Point(271, 411);
            this.upperHeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.upperHeightTextBox.Name = "upperHeightTextBox";
            this.upperHeightTextBox.Size = new System.Drawing.Size(62, 27);
            this.upperHeightTextBox.TabIndex = 9;
            // 
            // lowerHeightTextBox
            // 
            this.lowerHeightTextBox.Location = new System.Drawing.Point(271, 368);
            this.lowerHeightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lowerHeightTextBox.Name = "lowerHeightTextBox";
            this.lowerHeightTextBox.Size = new System.Drawing.Size(62, 27);
            this.lowerHeightTextBox.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChessRookUI.Properties.Resources.rook2;
            this.pictureBox2.Location = new System.Drawing.Point(194, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChessRookUI.Properties.Resources.rook3;
            this.pictureBox3.Location = new System.Drawing.Point(375, 39);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(70 мм - 600 мм)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "(20 мм - 200 мм)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "(15 мм - 100 мм)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "(15 мм - 100 мм)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "(14 мм - 90 мм )";
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(400, 457);
            this.buildButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(114, 31);
            this.buildButton.TabIndex = 18;
            this.buildButton.Text = "Построить";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 1;
            this.toolTip.ReshowDelay = 100;
            // 
            // newFeaturesCheckBox
            // 
            this.newFeaturesCheckBox.AutoSize = true;
            this.newFeaturesCheckBox.Location = new System.Drawing.Point(13, 460);
            this.newFeaturesCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newFeaturesCheckBox.Name = "newFeaturesCheckBox";
            this.newFeaturesCheckBox.Size = new System.Drawing.Size(255, 24);
            this.newFeaturesCheckBox.TabIndex = 19;
            this.newFeaturesCheckBox.Text = "Сделать основание квадратным";
            this.newFeaturesCheckBox.UseVisualStyleBackColor = true;
            // 
            // featuresCheckBox
            // 
            this.featuresCheckBox.AutoSize = true;
            this.featuresCheckBox.Location = new System.Drawing.Point(271, 460);
            this.featuresCheckBox.Name = "featuresCheckBox";
            this.featuresCheckBox.Size = new System.Drawing.Size(93, 24);
            this.featuresCheckBox.TabIndex = 20;
            this.featuresCheckBox.Text = "Прорези";
            this.featuresCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(528, 496);
            this.Controls.Add(this.featuresCheckBox);
            this.Controls.Add(this.newFeaturesCheckBox);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lowerHeightTextBox);
            this.Controls.Add(this.upperHeightTextBox);
            this.Controls.Add(this.upperDiameterTextBox);
            this.Controls.Add(this.lowerDiameterTextBox);
            this.Controls.Add(this.fullHeightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(546, 543);
            this.MinimumSize = new System.Drawing.Size(546, 543);
            this.Name = "MainWindow";
            this.Text = "Ладья";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullHeightTextBox;
        private System.Windows.Forms.TextBox lowerDiameterTextBox;
        private System.Windows.Forms.TextBox upperDiameterTextBox;
        private System.Windows.Forms.TextBox upperHeightTextBox;
        private System.Windows.Forms.TextBox lowerHeightTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox newFeaturesCheckBox;
        private System.Windows.Forms.CheckBox featuresCheckBox;
    }
}

