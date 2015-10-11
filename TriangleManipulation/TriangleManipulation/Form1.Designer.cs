namespace TriangleManipulation
{
    partial class Form1
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
            this.bLeftMoving = new System.Windows.Forms.Button();
            this.bRightMoving = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bClockRotation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMovX = new System.Windows.Forms.TextBox();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.bDownMoving = new System.Windows.Forms.Button();
            this.bUpMoving = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bStretch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStrX = new System.Windows.Forms.TextBox();
            this.tbRotY = new System.Windows.Forms.TextBox();
            this.tbRotZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStrZ = new System.Windows.Forms.TextBox();
            this.tbStrY = new System.Windows.Forms.TextBox();
            this.tbRotX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bMover = new System.Windows.Forms.Button();
            this.tbMovY = new System.Windows.Forms.TextBox();
            this.tbMovZ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbRefresh = new System.Windows.Forms.CheckBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbPurple = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bLeftMoving
            // 
            this.bLeftMoving.Location = new System.Drawing.Point(632, 32);
            this.bLeftMoving.Name = "bLeftMoving";
            this.bLeftMoving.Size = new System.Drawing.Size(52, 46);
            this.bLeftMoving.TabIndex = 0;
            this.bLeftMoving.Text = "LEFT";
            this.bLeftMoving.UseVisualStyleBackColor = true;
            this.bLeftMoving.Click += new System.EventHandler(this.bLeftMoving_Click);
            // 
            // bRightMoving
            // 
            this.bRightMoving.Location = new System.Drawing.Point(748, 31);
            this.bRightMoving.Name = "bRightMoving";
            this.bRightMoving.Size = new System.Drawing.Size(71, 46);
            this.bRightMoving.TabIndex = 1;
            this.bRightMoving.Text = "RIGHT";
            this.bRightMoving.UseVisualStyleBackColor = true;
            this.bRightMoving.Click += new System.EventHandler(this.bRightMoving_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "STRETCH";
            // 
            // bClockRotation
            // 
            this.bClockRotation.Location = new System.Drawing.Point(748, 80);
            this.bClockRotation.Name = "bClockRotation";
            this.bClockRotation.Size = new System.Drawing.Size(71, 104);
            this.bClockRotation.TabIndex = 4;
            this.bClockRotation.Text = "CLOCK";
            this.bClockRotation.UseVisualStyleBackColor = true;
            this.bClockRotation.Click += new System.EventHandler(this.bClockRotation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MOVE";
            // 
            // tbMovX
            // 
            this.tbMovX.Location = new System.Drawing.Point(670, 6);
            this.tbMovX.Name = "tbMovX";
            this.tbMovX.Size = new System.Drawing.Size(27, 20);
            this.tbMovX.TabIndex = 5;
            this.tbMovX.Text = "20";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(690, 80);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(52, 20);
            this.tbAngle.TabIndex = 6;
            this.tbAngle.Text = "23";
            // 
            // bDownMoving
            // 
            this.bDownMoving.Location = new System.Drawing.Point(690, 57);
            this.bDownMoving.Name = "bDownMoving";
            this.bDownMoving.Size = new System.Drawing.Size(52, 20);
            this.bDownMoving.TabIndex = 0;
            this.bDownMoving.Text = "DOWN";
            this.bDownMoving.UseVisualStyleBackColor = true;
            this.bDownMoving.Click += new System.EventHandler(this.bDownMoving_Click);
            // 
            // bUpMoving
            // 
            this.bUpMoving.Location = new System.Drawing.Point(690, 32);
            this.bUpMoving.Name = "bUpMoving";
            this.bUpMoving.Size = new System.Drawing.Size(52, 20);
            this.bUpMoving.TabIndex = 0;
            this.bUpMoving.Text = "UP";
            this.bUpMoving.UseVisualStyleBackColor = true;
            this.bUpMoving.Click += new System.EventHandler(this.bUpMoving_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(744, 292);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 7;
            this.bClear.Text = "CLEAR";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bStretch
            // 
            this.bStretch.Location = new System.Drawing.Point(748, 190);
            this.bStretch.Name = "bStretch";
            this.bStretch.Size = new System.Drawing.Size(71, 96);
            this.bStretch.TabIndex = 4;
            this.bStretch.Text = "STRETCH";
            this.bStretch.UseVisualStyleBackColor = true;
            this.bStretch.Click += new System.EventHandler(this.bStretch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ROTATE";
            // 
            // tbStrX
            // 
            this.tbStrX.Location = new System.Drawing.Point(703, 214);
            this.tbStrX.Name = "tbStrX";
            this.tbStrX.Size = new System.Drawing.Size(39, 20);
            this.tbStrX.TabIndex = 5;
            this.tbStrX.Text = "2";
            // 
            // tbRotY
            // 
            this.tbRotY.Location = new System.Drawing.Point(703, 129);
            this.tbRotY.Name = "tbRotY";
            this.tbRotY.Size = new System.Drawing.Size(39, 20);
            this.tbRotY.TabIndex = 5;
            this.tbRotY.Text = "100";
            // 
            // tbRotZ
            // 
            this.tbRotZ.Location = new System.Drawing.Point(703, 155);
            this.tbRotZ.Name = "tbRotZ";
            this.tbRotZ.Size = new System.Drawing.Size(39, 20);
            this.tbRotZ.TabIndex = 5;
            this.tbRotZ.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Z=";
            // 
            // tbStrZ
            // 
            this.tbStrZ.Location = new System.Drawing.Point(703, 266);
            this.tbStrZ.Name = "tbStrZ";
            this.tbStrZ.Size = new System.Drawing.Size(39, 20);
            this.tbStrZ.TabIndex = 5;
            this.tbStrZ.Text = "1";
            // 
            // tbStrY
            // 
            this.tbStrY.Location = new System.Drawing.Point(703, 240);
            this.tbStrY.Name = "tbStrY";
            this.tbStrY.Size = new System.Drawing.Size(39, 20);
            this.tbStrY.TabIndex = 5;
            this.tbStrY.Text = "2,2";
            // 
            // tbRotX
            // 
            this.tbRotX.Location = new System.Drawing.Point(703, 106);
            this.tbRotX.Name = "tbRotX";
            this.tbRotX.Size = new System.Drawing.Size(39, 20);
            this.tbRotX.TabIndex = 5;
            this.tbRotX.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "X=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Y=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Z=";
            // 
            // bMover
            // 
            this.bMover.Location = new System.Drawing.Point(769, 7);
            this.bMover.Name = "bMover";
            this.bMover.Size = new System.Drawing.Size(50, 18);
            this.bMover.TabIndex = 8;
            this.bMover.UseVisualStyleBackColor = true;
            this.bMover.Click += new System.EventHandler(this.bMover_Click);
            // 
            // tbMovY
            // 
            this.tbMovY.Location = new System.Drawing.Point(703, 6);
            this.tbMovY.Name = "tbMovY";
            this.tbMovY.Size = new System.Drawing.Size(27, 20);
            this.tbMovY.TabIndex = 5;
            this.tbMovY.Text = "20";
            // 
            // tbMovZ
            // 
            this.tbMovZ.Location = new System.Drawing.Point(736, 6);
            this.tbMovZ.Name = "tbMovZ";
            this.tbMovZ.Size = new System.Drawing.Size(27, 20);
            this.tbMovZ.TabIndex = 5;
            this.tbMovZ.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 83);
            this.button1.TabIndex = 9;
            this.button1.Text = "centre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbRefresh
            // 
            this.cbRefresh.AutoSize = true;
            this.cbRefresh.Location = new System.Drawing.Point(742, 332);
            this.cbRefresh.Name = "cbRefresh";
            this.cbRefresh.Size = new System.Drawing.Size(77, 17);
            this.cbRefresh.TabIndex = 10;
            this.cbRefresh.Text = "REFRESH";
            this.cbRefresh.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Checked = true;
            this.rbRed.Location = new System.Drawing.Point(612, 361);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(48, 17);
            this.rbRed.TabIndex = 11;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "RED";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(612, 384);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(70, 17);
            this.rbYellow.TabIndex = 11;
            this.rbYellow.Text = "YELLOW";
            this.rbYellow.UseVisualStyleBackColor = true;
            this.rbYellow.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(612, 430);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(63, 17);
            this.rbGreen.TabIndex = 11;
            this.rbGreen.Text = "GREEN";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(612, 407);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(53, 17);
            this.rbBlue.TabIndex = 11;
            this.rbBlue.Text = "BLUE";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // rbPurple
            // 
            this.rbPurple.AutoSize = true;
            this.rbPurple.Location = new System.Drawing.Point(690, 384);
            this.rbPurple.Name = "rbPurple";
            this.rbPurple.Size = new System.Drawing.Size(68, 17);
            this.rbPurple.TabIndex = 11;
            this.rbPurple.Text = "PURPLE";
            this.rbPurple.UseVisualStyleBackColor = true;
            this.rbPurple.CheckedChanged += new System.EventHandler(this.ColorChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 459);
            this.Controls.Add(this.rbPurple);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbYellow);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.cbRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bMover);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tbAngle);
            this.Controls.Add(this.tbRotZ);
            this.Controls.Add(this.tbRotY);
            this.Controls.Add(this.tbStrZ);
            this.Controls.Add(this.tbRotX);
            this.Controls.Add(this.tbStrY);
            this.Controls.Add(this.tbStrX);
            this.Controls.Add(this.tbMovZ);
            this.Controls.Add(this.tbMovY);
            this.Controls.Add(this.tbMovX);
            this.Controls.Add(this.bStretch);
            this.Controls.Add(this.bClockRotation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bRightMoving);
            this.Controls.Add(this.bUpMoving);
            this.Controls.Add(this.bDownMoving);
            this.Controls.Add(this.bLeftMoving);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLeftMoving;
        private System.Windows.Forms.Button bRightMoving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bClockRotation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMovX;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.Button bDownMoving;
        private System.Windows.Forms.Button bUpMoving;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bStretch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStrX;
        private System.Windows.Forms.TextBox tbRotY;
        private System.Windows.Forms.TextBox tbRotZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStrZ;
        private System.Windows.Forms.TextBox tbStrY;
        private System.Windows.Forms.TextBox tbRotX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bMover;
        private System.Windows.Forms.TextBox tbMovY;
        private System.Windows.Forms.TextBox tbMovZ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbRefresh;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbPurple;
    }
}

