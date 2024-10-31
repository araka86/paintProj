namespace paintProj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblColo = new System.Windows.Forms.Label();
            this.tbColor1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.tb14 = new System.Windows.Forms.TextBox();
            this.tb15 = new System.Windows.Forms.TextBox();
            this.tb16 = new System.Windows.Forms.TextBox();
            this.tb17 = new System.Windows.Forms.TextBox();
            this.tb18 = new System.Windows.Forms.TextBox();
            this.tb19 = new System.Windows.Forms.TextBox();
            this.tb20 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnColorDiag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1274, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 600);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1274, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblColo);
            this.panel2.Controls.Add(this.tbColor1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(494, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 51);
            this.panel2.TabIndex = 15;
            // 
            // lblColo
            // 
            this.lblColo.AutoSize = true;
            this.lblColo.Location = new System.Drawing.Point(196, 33);
            this.lblColo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColo.Name = "lblColo";
            this.lblColo.Size = new System.Drawing.Size(31, 13);
            this.lblColo.TabIndex = 14;
            this.lblColo.Text = "Color";
            // 
            // tbColor1
            // 
            this.tbColor1.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbColor1.Location = new System.Drawing.Point(194, 2);
            this.tbColor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbColor1.Multiline = true;
            this.tbColor1.Name = "tbColor1";
            this.tbColor1.Size = new System.Drawing.Size(32, 29);
            this.tbColor1.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tb1);
            this.flowLayoutPanel2.Controls.Add(this.tb2);
            this.flowLayoutPanel2.Controls.Add(this.tb3);
            this.flowLayoutPanel2.Controls.Add(this.tb4);
            this.flowLayoutPanel2.Controls.Add(this.tb5);
            this.flowLayoutPanel2.Controls.Add(this.tb6);
            this.flowLayoutPanel2.Controls.Add(this.tb7);
            this.flowLayoutPanel2.Controls.Add(this.tb8);
            this.flowLayoutPanel2.Controls.Add(this.tb9);
            this.flowLayoutPanel2.Controls.Add(this.tb10);
            this.flowLayoutPanel2.Controls.Add(this.tb11);
            this.flowLayoutPanel2.Controls.Add(this.tb12);
            this.flowLayoutPanel2.Controls.Add(this.tb13);
            this.flowLayoutPanel2.Controls.Add(this.tb14);
            this.flowLayoutPanel2.Controls.Add(this.tb15);
            this.flowLayoutPanel2.Controls.Add(this.tb16);
            this.flowLayoutPanel2.Controls.Add(this.tb17);
            this.flowLayoutPanel2.Controls.Add(this.tb18);
            this.flowLayoutPanel2.Controls.Add(this.tb19);
            this.flowLayoutPanel2.Controls.Add(this.tb20);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(721, 15);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(244, 51);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb1.Location = new System.Drawing.Point(2, 2);
            this.tb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(19, 19);
            this.tb1.TabIndex = 12;
            this.tb1.TabStop = false;
            this.tb1.WordWrap = false;
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb2.Location = new System.Drawing.Point(25, 2);
            this.tb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(19, 19);
            this.tb2.TabIndex = 10;
            // 
            // tb3
            // 
            this.tb3.BackColor = System.Drawing.Color.Brown;
            this.tb3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb3.Location = new System.Drawing.Point(48, 2);
            this.tb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(19, 19);
            this.tb3.TabIndex = 11;
            // 
            // tb4
            // 
            this.tb4.BackColor = System.Drawing.Color.Red;
            this.tb4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb4.Location = new System.Drawing.Point(71, 2);
            this.tb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(19, 19);
            this.tb4.TabIndex = 13;
            // 
            // tb5
            // 
            this.tb5.BackColor = System.Drawing.Color.DarkOrange;
            this.tb5.CausesValidation = false;
            this.tb5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb5.Location = new System.Drawing.Point(94, 2);
            this.tb5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(19, 19);
            this.tb5.TabIndex = 14;
            // 
            // tb6
            // 
            this.tb6.BackColor = System.Drawing.Color.Yellow;
            this.tb6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb6.Location = new System.Drawing.Point(117, 2);
            this.tb6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb6.Multiline = true;
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(19, 19);
            this.tb6.TabIndex = 15;
            // 
            // tb7
            // 
            this.tb7.BackColor = System.Drawing.Color.ForestGreen;
            this.tb7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb7.Location = new System.Drawing.Point(140, 2);
            this.tb7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb7.Multiline = true;
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(19, 19);
            this.tb7.TabIndex = 16;
            // 
            // tb8
            // 
            this.tb8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb8.Location = new System.Drawing.Point(163, 2);
            this.tb8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb8.Multiline = true;
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(19, 19);
            this.tb8.TabIndex = 17;
            // 
            // tb9
            // 
            this.tb9.BackColor = System.Drawing.Color.Blue;
            this.tb9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb9.Location = new System.Drawing.Point(186, 2);
            this.tb9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb9.Multiline = true;
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(19, 19);
            this.tb9.TabIndex = 18;
            // 
            // tb10
            // 
            this.tb10.BackColor = System.Drawing.Color.DarkOrchid;
            this.tb10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb10.Location = new System.Drawing.Point(209, 2);
            this.tb10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb10.Multiline = true;
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(19, 19);
            this.tb10.TabIndex = 19;
            // 
            // tb11
            // 
            this.tb11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb11.Location = new System.Drawing.Point(2, 25);
            this.tb11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb11.Multiline = true;
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(19, 19);
            this.tb11.TabIndex = 20;
            // 
            // tb12
            // 
            this.tb12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb12.Location = new System.Drawing.Point(25, 25);
            this.tb12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb12.Multiline = true;
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(19, 19);
            this.tb12.TabIndex = 21;
            // 
            // tb13
            // 
            this.tb13.BackColor = System.Drawing.Color.Peru;
            this.tb13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb13.Location = new System.Drawing.Point(48, 25);
            this.tb13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb13.Multiline = true;
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(19, 19);
            this.tb13.TabIndex = 22;
            // 
            // tb14
            // 
            this.tb14.BackColor = System.Drawing.Color.Pink;
            this.tb14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb14.Location = new System.Drawing.Point(71, 25);
            this.tb14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb14.Multiline = true;
            this.tb14.Name = "tb14";
            this.tb14.Size = new System.Drawing.Size(19, 19);
            this.tb14.TabIndex = 23;
            // 
            // tb15
            // 
            this.tb15.BackColor = System.Drawing.Color.Gold;
            this.tb15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb15.Location = new System.Drawing.Point(94, 25);
            this.tb15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb15.Multiline = true;
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(19, 19);
            this.tb15.TabIndex = 24;
            // 
            // tb16
            // 
            this.tb16.BackColor = System.Drawing.Color.Khaki;
            this.tb16.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb16.Location = new System.Drawing.Point(117, 25);
            this.tb16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb16.Multiline = true;
            this.tb16.Name = "tb16";
            this.tb16.Size = new System.Drawing.Size(19, 19);
            this.tb16.TabIndex = 25;
            // 
            // tb17
            // 
            this.tb17.BackColor = System.Drawing.Color.YellowGreen;
            this.tb17.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb17.Location = new System.Drawing.Point(140, 25);
            this.tb17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb17.Multiline = true;
            this.tb17.Name = "tb17";
            this.tb17.Size = new System.Drawing.Size(19, 19);
            this.tb17.TabIndex = 26;
            // 
            // tb18
            // 
            this.tb18.BackColor = System.Drawing.Color.SkyBlue;
            this.tb18.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb18.Location = new System.Drawing.Point(163, 25);
            this.tb18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb18.Multiline = true;
            this.tb18.Name = "tb18";
            this.tb18.Size = new System.Drawing.Size(19, 19);
            this.tb18.TabIndex = 27;
            // 
            // tb19
            // 
            this.tb19.BackColor = System.Drawing.Color.SteelBlue;
            this.tb19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb19.Location = new System.Drawing.Point(186, 25);
            this.tb19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb19.Multiline = true;
            this.tb19.Name = "tb19";
            this.tb19.Size = new System.Drawing.Size(19, 19);
            this.tb19.TabIndex = 28;
            // 
            // tb20
            // 
            this.tb20.BackColor = System.Drawing.Color.MediumPurple;
            this.tb20.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb20.Location = new System.Drawing.Point(209, 25);
            this.tb20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb20.Multiline = true;
            this.tb20.Name = "tb20";
            this.tb20.Size = new System.Drawing.Size(19, 19);
            this.tb20.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnElipse);
            this.flowLayoutPanel1.Controls.Add(this.btnCircle);
            this.flowLayoutPanel1.Controls.Add(this.btnLine);
            this.flowLayoutPanel1.Controls.Add(this.btnColorDiag);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(965, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 51);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.Location = new System.Drawing.Point(189, 7);
            this.btnElipse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(56, 42);
            this.btnElipse.TabIndex = 4;
            this.btnElipse.Text = "Elipse";
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(129, 7);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(56, 42);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(69, 7);
            this.btnLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(56, 42);
            this.btnLine.TabIndex = 7;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnColorDiag
            // 
            this.btnColorDiag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorDiag.BackgroundImage")));
            this.btnColorDiag.Location = new System.Drawing.Point(9, 7);
            this.btnColorDiag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnColorDiag.Name = "btnColorDiag";
            this.btnColorDiag.Size = new System.Drawing.Size(56, 42);
            this.btnColorDiag.TabIndex = 8;
            this.btnColorDiag.Text = "Color";
            this.btnColorDiag.UseVisualStyleBackColor = true;
            this.btnColorDiag.Click += new System.EventHandler(this.btnColorDiag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 600);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnColorDiag;
        private System.Windows.Forms.TextBox tbColor1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label lblColo;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb14;
        private System.Windows.Forms.TextBox tb15;
        private System.Windows.Forms.TextBox tb16;
        private System.Windows.Forms.TextBox tb17;
        private System.Windows.Forms.TextBox tb18;
        private System.Windows.Forms.TextBox tb19;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.Panel panel2;
    }
}

