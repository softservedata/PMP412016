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
            this.SuspendLayout();
            // 
            // panelScreen
            // 
            this.panelScreen.BackColor = System.Drawing.SystemColors.Window;
            this.panelScreen.Location = new System.Drawing.Point(0, 0);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(587, 325);
            this.panelScreen.TabIndex = 0;
            this.panelScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelScreen_MouseClick);
            // 
            // labelPolygon
            // 
            this.labelPolygon.AutoSize = true;
            this.labelPolygon.Location = new System.Drawing.Point(594, 13);
            this.labelPolygon.Name = "labelPolygon";
            this.labelPolygon.Size = new System.Drawing.Size(45, 13);
            this.labelPolygon.TabIndex = 1;
            this.labelPolygon.Text = "Polygon";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(622, 29);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(55, 20);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.Text = "10";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(622, 56);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(55, 20);
            this.textBoxY1.TabIndex = 3;
            this.textBoxY1.Text = "10";
            // 
            // textBoxZ1
            // 
            this.textBoxZ1.Location = new System.Drawing.Point(622, 82);
            this.textBoxZ1.Name = "textBoxZ1";
            this.textBoxZ1.Size = new System.Drawing.Size(55, 20);
            this.textBoxZ1.TabIndex = 3;
            this.textBoxZ1.Text = "10";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(594, 29);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(593, 59);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(622, 111);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add line";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(712, 29);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(55, 20);
            this.textBoxX2.TabIndex = 2;
            this.textBoxX2.Text = "50";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(712, 55);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(55, 20);
            this.textBoxY2.TabIndex = 3;
            this.textBoxY2.Text = "50";
            // 
            // textBoxZ2
            // 
            this.textBoxZ2.Location = new System.Drawing.Point(712, 85);
            this.textBoxZ2.Name = "textBoxZ2";
            this.textBoxZ2.Size = new System.Drawing.Size(55, 20);
            this.textBoxZ2.TabIndex = 3;
            this.textBoxZ2.Text = "10";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(622, 140);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(145, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset ";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // GraphicsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 328);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxZ2);
            this.Controls.Add(this.textBoxZ1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelPolygon);
            this.Controls.Add(this.panelScreen);
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
    }
}