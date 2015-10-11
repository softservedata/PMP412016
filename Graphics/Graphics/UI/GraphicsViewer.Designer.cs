namespace Graphics.UI
{
    partial class GraphicsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsViewer));
            this.panelScreen = new System.Windows.Forms.Panel();
            this.labelPolygon = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxZ1 = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxZ2 = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonYLeft = new System.Windows.Forms.Button();
            this.buttonYRight = new System.Windows.Forms.Button();
            this.buttonZRight = new System.Windows.Forms.Button();
            this.buttonZLeft = new System.Windows.Forms.Button();
            this.labelRhomb = new System.Windows.Forms.Label();
            this.labelXR = new System.Windows.Forms.Label();
            this.labelYR = new System.Windows.Forms.Label();
            this.labelZR = new System.Windows.Forms.Label();
            this.textBoxRhombX1 = new System.Windows.Forms.TextBox();
            this.textBoxRhombX2 = new System.Windows.Forms.TextBox();
            this.textBoxRhombY1 = new System.Windows.Forms.TextBox();
            this.textBoxRhombY2 = new System.Windows.Forms.TextBox();
            this.textBoxRhombZ1 = new System.Windows.Forms.TextBox();
            this.textBoxRhombZ2 = new System.Windows.Forms.TextBox();
            this.labelNormal = new System.Windows.Forms.Label();
            this.textBoxNormalX = new System.Windows.Forms.TextBox();
            this.textBoxNormalY = new System.Windows.Forms.TextBox();
            this.textBoxNormalZ = new System.Windows.Forms.TextBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.buttonCreateRhomb = new System.Windows.Forms.Button();
            this.buttonXUp = new System.Windows.Forms.Button();
            this.buttonXDown = new System.Windows.Forms.Button();
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // panelScreen
            // 
            this.panelScreen.BackColor = System.Drawing.SystemColors.Window;
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelScreen.Location = new System.Drawing.Point(0, 0);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(364, 362);
            this.panelScreen.TabIndex = 0;
            this.panelScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelScreen_MouseClick);
            this.panelScreen.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GraphicsViewer_PreviewKeyDown);
            // 
            // labelPolygon
            // 
            this.labelPolygon.AutoSize = true;
            this.labelPolygon.Location = new System.Drawing.Point(370, 9);
            this.labelPolygon.Name = "labelPolygon";
            this.labelPolygon.Size = new System.Drawing.Size(45, 13);
            this.labelPolygon.TabIndex = 10;
            this.labelPolygon.Text = "Polygon";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(397, 31);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(55, 20);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.Text = "10";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(397, 57);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(55, 20);
            this.textBoxY1.TabIndex = 2;
            this.textBoxY1.Text = "10";
            // 
            // textBoxZ1
            // 
            this.textBoxZ1.Location = new System.Drawing.Point(397, 86);
            this.textBoxZ1.Name = "textBoxZ1";
            this.textBoxZ1.Size = new System.Drawing.Size(55, 20);
            this.textBoxZ1.TabIndex = 3;
            this.textBoxZ1.Text = "10";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(369, 33);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(369, 59);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAdd.Location = new System.Drawing.Point(386, 111);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add line";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(478, 30);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(55, 20);
            this.textBoxX2.TabIndex = 4;
            this.textBoxX2.Text = "50";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(478, 56);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(55, 20);
            this.textBoxY2.TabIndex = 5;
            this.textBoxY2.Text = "50";
            // 
            // textBoxZ2
            // 
            this.textBoxZ2.Location = new System.Drawing.Point(478, 86);
            this.textBoxZ2.Name = "textBoxZ2";
            this.textBoxZ2.Size = new System.Drawing.Size(55, 20);
            this.textBoxZ2.TabIndex = 6;
            this.textBoxZ2.Text = "10";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonReset.Location = new System.Drawing.Point(478, 202);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(148, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset ";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonYLeft
            // 
            this.buttonYLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonYLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonYLeft.BackgroundImage")));
            this.buttonYLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonYLeft.Location = new System.Drawing.Point(454, 271);
            this.buttonYLeft.Name = "buttonYLeft";
            this.buttonYLeft.Size = new System.Drawing.Size(44, 42);
            this.buttonYLeft.TabIndex = 11;
            this.buttonYLeft.UseVisualStyleBackColor = false;
            this.buttonYLeft.Click += new System.EventHandler(this.buttonYLeft_Click);
            // 
            // buttonYRight
            // 
            this.buttonYRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonYRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonYRight.BackgroundImage")));
            this.buttonYRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonYRight.Location = new System.Drawing.Point(454, 319);
            this.buttonYRight.Name = "buttonYRight";
            this.buttonYRight.Size = new System.Drawing.Size(44, 45);
            this.buttonYRight.TabIndex = 11;
            this.buttonYRight.UseVisualStyleBackColor = false;
            this.buttonYRight.Click += new System.EventHandler(this.buttonYRight_Click);
            // 
            // buttonZRight
            // 
            this.buttonZRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonZRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZRight.BackgroundImage")));
            this.buttonZRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonZRight.Location = new System.Drawing.Point(504, 295);
            this.buttonZRight.Name = "buttonZRight";
            this.buttonZRight.Size = new System.Drawing.Size(39, 42);
            this.buttonZRight.TabIndex = 11;
            this.buttonZRight.UseVisualStyleBackColor = false;
            this.buttonZRight.Click += new System.EventHandler(this.buttonZRight_Click);
            // 
            // buttonZLeft
            // 
            this.buttonZLeft.BackColor = System.Drawing.SystemColors.Control;
            this.buttonZLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonZLeft.BackgroundImage")));
            this.buttonZLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonZLeft.Location = new System.Drawing.Point(549, 295);
            this.buttonZLeft.Name = "buttonZLeft";
            this.buttonZLeft.Size = new System.Drawing.Size(42, 42);
            this.buttonZLeft.TabIndex = 11;
            this.buttonZLeft.UseVisualStyleBackColor = false;
            this.buttonZLeft.Click += new System.EventHandler(this.buttonZLeft_Click);
            // 
            // labelRhomb
            // 
            this.labelRhomb.AutoSize = true;
            this.labelRhomb.Location = new System.Drawing.Point(593, 9);
            this.labelRhomb.Name = "labelRhomb";
            this.labelRhomb.Size = new System.Drawing.Size(41, 13);
            this.labelRhomb.TabIndex = 10;
            this.labelRhomb.Text = "Rhomb";
            // 
            // labelXR
            // 
            this.labelXR.AutoSize = true;
            this.labelXR.Location = new System.Drawing.Point(571, 33);
            this.labelXR.Name = "labelXR";
            this.labelXR.Size = new System.Drawing.Size(14, 13);
            this.labelXR.TabIndex = 1;
            this.labelXR.Text = "X";
            // 
            // labelYR
            // 
            this.labelYR.AutoSize = true;
            this.labelYR.Location = new System.Drawing.Point(571, 59);
            this.labelYR.Name = "labelYR";
            this.labelYR.Size = new System.Drawing.Size(14, 13);
            this.labelYR.TabIndex = 1;
            this.labelYR.Text = "Y";
            // 
            // labelZR
            // 
            this.labelZR.AutoSize = true;
            this.labelZR.Location = new System.Drawing.Point(571, 89);
            this.labelZR.Name = "labelZR";
            this.labelZR.Size = new System.Drawing.Size(14, 13);
            this.labelZR.TabIndex = 1;
            this.labelZR.Text = "Z";
            // 
            // textBoxRhombX1
            // 
            this.textBoxRhombX1.Location = new System.Drawing.Point(597, 33);
            this.textBoxRhombX1.Name = "textBoxRhombX1";
            this.textBoxRhombX1.Size = new System.Drawing.Size(55, 20);
            this.textBoxRhombX1.TabIndex = 1;
            this.textBoxRhombX1.Text = "-10";
            // 
            // textBoxRhombX2
            // 
            this.textBoxRhombX2.Location = new System.Drawing.Point(665, 30);
            this.textBoxRhombX2.Name = "textBoxRhombX2";
            this.textBoxRhombX2.Size = new System.Drawing.Size(55, 20);
            this.textBoxRhombX2.TabIndex = 4;
            this.textBoxRhombX2.Text = "10";
            // 
            // textBoxRhombY1
            // 
            this.textBoxRhombY1.Location = new System.Drawing.Point(597, 57);
            this.textBoxRhombY1.Name = "textBoxRhombY1";
            this.textBoxRhombY1.Size = new System.Drawing.Size(55, 20);
            this.textBoxRhombY1.TabIndex = 2;
            this.textBoxRhombY1.Text = "-10";
            // 
            // textBoxRhombY2
            // 
            this.textBoxRhombY2.Location = new System.Drawing.Point(665, 56);
            this.textBoxRhombY2.Name = "textBoxRhombY2";
            this.textBoxRhombY2.Size = new System.Drawing.Size(55, 20);
            this.textBoxRhombY2.TabIndex = 5;
            this.textBoxRhombY2.Text = "10";
            // 
            // textBoxRhombZ1
            // 
            this.textBoxRhombZ1.Location = new System.Drawing.Point(597, 86);
            this.textBoxRhombZ1.Name = "textBoxRhombZ1";
            this.textBoxRhombZ1.Size = new System.Drawing.Size(55, 20);
            this.textBoxRhombZ1.TabIndex = 3;
            this.textBoxRhombZ1.Text = "30";
            // 
            // textBoxRhombZ2
            // 
            this.textBoxRhombZ2.Location = new System.Drawing.Point(665, 86);
            this.textBoxRhombZ2.Name = "textBoxRhombZ2";
            this.textBoxRhombZ2.Size = new System.Drawing.Size(55, 20);
            this.textBoxRhombZ2.TabIndex = 6;
            this.textBoxRhombZ2.Text = "30";
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.Location = new System.Drawing.Point(551, 121);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(40, 13);
            this.labelNormal.TabIndex = 1;
            this.labelNormal.Text = "Normal";
            // 
            // textBoxNormalX
            // 
            this.textBoxNormalX.Location = new System.Drawing.Point(597, 118);
            this.textBoxNormalX.Name = "textBoxNormalX";
            this.textBoxNormalX.Size = new System.Drawing.Size(37, 20);
            this.textBoxNormalX.TabIndex = 3;
            this.textBoxNormalX.Text = "0";
            // 
            // textBoxNormalY
            // 
            this.textBoxNormalY.Location = new System.Drawing.Point(640, 118);
            this.textBoxNormalY.Name = "textBoxNormalY";
            this.textBoxNormalY.Size = new System.Drawing.Size(37, 20);
            this.textBoxNormalY.TabIndex = 3;
            this.textBoxNormalY.Text = "0";
            // 
            // textBoxNormalZ
            // 
            this.textBoxNormalZ.Location = new System.Drawing.Point(683, 118);
            this.textBoxNormalZ.Name = "textBoxNormalZ";
            this.textBoxNormalZ.Size = new System.Drawing.Size(37, 20);
            this.textBoxNormalZ.TabIndex = 3;
            this.textBoxNormalZ.Text = "1";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(551, 150);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(34, 13);
            this.labelAngle.TabIndex = 1;
            this.labelAngle.Text = "Angle";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(597, 147);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(123, 20);
            this.textBoxAngle.TabIndex = 3;
            this.textBoxAngle.Text = "0,3925";
            // 
            // buttonCreateRhomb
            // 
            this.buttonCreateRhomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCreateRhomb.Location = new System.Drawing.Point(597, 173);
            this.buttonCreateRhomb.Name = "buttonCreateRhomb";
            this.buttonCreateRhomb.Size = new System.Drawing.Size(125, 23);
            this.buttonCreateRhomb.TabIndex = 7;
            this.buttonCreateRhomb.Text = "Paint rhomb";
            this.buttonCreateRhomb.UseVisualStyleBackColor = false;
            this.buttonCreateRhomb.Click += new System.EventHandler(this.buttonCreateRhomb_Click);
            // 
            // buttonXUp
            // 
            this.buttonXUp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonXUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXUp.BackgroundImage")));
            this.buttonXUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonXUp.Location = new System.Drawing.Point(597, 271);
            this.buttonXUp.Name = "buttonXUp";
            this.buttonXUp.Size = new System.Drawing.Size(42, 42);
            this.buttonXUp.TabIndex = 11;
            this.buttonXUp.UseVisualStyleBackColor = false;
            this.buttonXUp.Click += new System.EventHandler(this.buttonXUp_Click);
            // 
            // buttonXDown
            // 
            this.buttonXDown.BackColor = System.Drawing.SystemColors.Control;
            this.buttonXDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonXDown.BackgroundImage")));
            this.buttonXDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonXDown.Location = new System.Drawing.Point(597, 319);
            this.buttonXDown.Name = "buttonXDown";
            this.buttonXDown.Size = new System.Drawing.Size(42, 42);
            this.buttonXDown.TabIndex = 11;
            this.buttonXDown.UseVisualStyleBackColor = false;
            this.buttonXDown.Click += new System.EventHandler(this.buttonXDown_Click);
            // 
            // GraphicsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(742, 362);
            this.Controls.Add(this.buttonXDown);
            this.Controls.Add(this.buttonXUp);
            this.Controls.Add(this.buttonZLeft);
            this.Controls.Add(this.buttonZRight);
            this.Controls.Add(this.buttonYRight);
            this.Controls.Add(this.buttonYLeft);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCreateRhomb);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxRhombZ2);
            this.Controls.Add(this.textBoxZ2);
            this.Controls.Add(this.textBoxNormalZ);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.textBoxNormalY);
            this.Controls.Add(this.textBoxNormalX);
            this.Controls.Add(this.textBoxRhombZ1);
            this.Controls.Add(this.textBoxZ1);
            this.Controls.Add(this.textBoxRhombY2);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxRhombY1);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxRhombX2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxRhombX1);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.labelNormal);
            this.Controls.Add(this.labelZR);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelYR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelXR);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelRhomb);
            this.Controls.Add(this.labelPolygon);
            this.Controls.Add(this.panelScreen);
            this.KeyPreview = true;
            this.Name = "GraphicsViewer";
            this.Text = "GraphicsViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Label labelPolygon;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxZ1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxZ2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonYLeft;
        private System.Windows.Forms.Button buttonYRight;
        private System.Windows.Forms.Button buttonZRight;
        private System.Windows.Forms.Button buttonZLeft;
        private System.Windows.Forms.Label labelRhomb;
        private System.Windows.Forms.Label labelXR;
        private System.Windows.Forms.Label labelYR;
        private System.Windows.Forms.Label labelZR;
        private System.Windows.Forms.TextBox textBoxRhombX1;
        private System.Windows.Forms.TextBox textBoxRhombX2;
        private System.Windows.Forms.TextBox textBoxRhombY1;
        private System.Windows.Forms.TextBox textBoxRhombY2;
        private System.Windows.Forms.TextBox textBoxRhombZ1;
        private System.Windows.Forms.TextBox textBoxRhombZ2;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.TextBox textBoxNormalX;
        private System.Windows.Forms.TextBox textBoxNormalY;
        private System.Windows.Forms.TextBox textBoxNormalZ;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Button buttonCreateRhomb;
        private System.Windows.Forms.Button buttonXUp;
        private System.Windows.Forms.Button buttonXDown;
        private System.Windows.Forms.ColorDialog colorDialogPen;
    }
}