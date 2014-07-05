namespace glWinForm
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
            this.fbFill = new System.Windows.Forms.Button();
            this.fbLines = new System.Windows.Forms.Button();
            this.fbPoints = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fnudY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.fnudX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.fbReset = new System.Windows.Forms.Button();
            this.fbApply = new System.Windows.Forms.Button();
            this.view = new OpenGL.ViewGL();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // fbFill
            // 
            this.fbFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fbFill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fbFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fbFill.Location = new System.Drawing.Point(0, 652);
            this.fbFill.Name = "fbFill";
            this.fbFill.Size = new System.Drawing.Size(971, 36);
            this.fbFill.TabIndex = 1;
            this.fbFill.Text = "Fill";
            this.fbFill.UseVisualStyleBackColor = true;
            this.fbFill.Click += new System.EventHandler(this.fbFill_Click);
            // 
            // fbLines
            // 
            this.fbLines.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fbLines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fbLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fbLines.Location = new System.Drawing.Point(0, 616);
            this.fbLines.Name = "fbLines";
            this.fbLines.Size = new System.Drawing.Size(971, 36);
            this.fbLines.TabIndex = 2;
            this.fbLines.Text = "Lines";
            this.fbLines.UseVisualStyleBackColor = true;
            this.fbLines.Click += new System.EventHandler(this.fbLines_Click);
            // 
            // fbPoints
            // 
            this.fbPoints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fbPoints.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fbPoints.Location = new System.Drawing.Point(0, 580);
            this.fbPoints.Name = "fbPoints";
            this.fbPoints.Size = new System.Drawing.Size(971, 36);
            this.fbPoints.TabIndex = 3;
            this.fbPoints.Text = "Points";
            this.fbPoints.UseVisualStyleBackColor = true;
            this.fbPoints.Click += new System.EventHandler(this.fbPoints_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(743, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Масштабирование по высоте";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "В столько раз:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(16, 70);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(743, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 179);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поворот по часовой стрелке";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.fnudY);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.fnudX);
            this.groupBox4.Location = new System.Drawing.Point(19, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 84);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Координаты центра вращения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Y:";
            // 
            // fnudY
            // 
            this.fnudY.DecimalPlaces = 2;
            this.fnudY.Location = new System.Drawing.Point(111, 56);
            this.fnudY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fnudY.Name = "fnudY";
            this.fnudY.Size = new System.Drawing.Size(57, 22);
            this.fnudY.TabIndex = 5;
            this.fnudY.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.fnudY.ValueChanged += new System.EventHandler(this.fnudY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "X:";
            // 
            // fnudX
            // 
            this.fnudX.DecimalPlaces = 2;
            this.fnudX.Location = new System.Drawing.Point(20, 56);
            this.fnudX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fnudX.Name = "fnudX";
            this.fnudX.Size = new System.Drawing.Size(57, 22);
            this.fnudX.TabIndex = 3;
            this.fnudX.ValueChanged += new System.EventHandler(this.fnudX_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Угол:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(743, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перенос по вертикали";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "На величину:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 1;
            this.numericUpDown3.Location = new System.Drawing.Point(19, 54);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(743, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 117);
            this.button1.TabIndex = 7;
            this.button1.Text = "Перейти к следующему преобразованию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbReset
            // 
            this.fbReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fbReset.Location = new System.Drawing.Point(743, 428);
            this.fbReset.Name = "fbReset";
            this.fbReset.Size = new System.Drawing.Size(211, 23);
            this.fbReset.TabIndex = 8;
            this.fbReset.Text = "Сброс";
            this.fbReset.UseVisualStyleBackColor = true;
            this.fbReset.Click += new System.EventHandler(this.fbReset_Click);
            // 
            // fbApply
            // 
            this.fbApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fbApply.Location = new System.Drawing.Point(743, 399);
            this.fbApply.Name = "fbApply";
            this.fbApply.Size = new System.Drawing.Size(211, 23);
            this.fbApply.TabIndex = 9;
            this.fbApply.Text = "Применить";
            this.fbApply.UseVisualStyleBackColor = true;
            this.fbApply.Click += new System.EventHandler(this.fbApply_Click);
            // 
            // view
            // 
            this.view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.view.Location = new System.Drawing.Point(12, 12);
            this.view.Name = "view";
            this.view.RotateAngle = 0;
            this.view.RotateX = 0;
            this.view.RotateY = 0;
            this.view.ScaleFactor = 1;
            this.view.Size = new System.Drawing.Size(725, 562);
            this.view.TabIndex = 0;
            this.view.TransferValue = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(971, 688);
            this.Controls.Add(this.fbApply);
            this.Controls.Add(this.fbReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fbPoints);
            this.Controls.Add(this.fbLines);
            this.Controls.Add(this.fbFill);
            this.Controls.Add(this.view);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "OpenGL Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fnudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenGL.ViewGL view;
        private System.Windows.Forms.Button fbFill;
        private System.Windows.Forms.Button fbLines;
        private System.Windows.Forms.Button fbPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button fbReset;
        private System.Windows.Forms.Button fbApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown fnudX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown fnudY;
    }
}

