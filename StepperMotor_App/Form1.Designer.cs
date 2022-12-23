namespace StepperMotor_App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.commStage = new customControl.comboSerial();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtBxTarget = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBxMoveRel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enableWarningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBxCurrent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // commStage
            // 
            this.commStage.Location = new System.Drawing.Point(12, 37);
            this.commStage.Name = "commStage";
            this.commStage.Size = new System.Drawing.Size(102, 72);
            this.commStage.TabIndex = 0;
            this.commStage.TabStop = false;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(8, 8);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 51);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(212, 8);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 51);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtBxTarget
            // 
            this.txtBxTarget.Location = new System.Drawing.Point(53, 122);
            this.txtBxTarget.Name = "txtBxTarget";
            this.txtBxTarget.Size = new System.Drawing.Size(76, 20);
            this.txtBxTarget.TabIndex = 1;
            this.txtBxTarget.TextChanged += new System.EventHandler(this.txtBxTarget_TextChanged);
            this.txtBxTarget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTarget_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.txtBxMoveRel);
            this.panel1.Location = new System.Drawing.Point(12, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 64);
            this.panel1.TabIndex = 3;
            // 
            // txtBxMoveRel
            // 
            this.txtBxMoveRel.Location = new System.Drawing.Point(111, 24);
            this.txtBxMoveRel.Name = "txtBxMoveRel";
            this.txtBxMoveRel.Size = new System.Drawing.Size(70, 20);
            this.txtBxMoveRel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Relative Motion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(135, 120);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(43, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.TabStop = false;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tareToolStripMenuItem
            // 
            this.tareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareToolStripMenuItem1,
            this.enableWarningToolStripMenuItem});
            this.tareToolStripMenuItem.Name = "tareToolStripMenuItem";
            this.tareToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tareToolStripMenuItem.Text = "Options";
            this.tareToolStripMenuItem.Click += new System.EventHandler(this.tareToolStripMenuItem_Click);
            // 
            // tareToolStripMenuItem1
            // 
            this.tareToolStripMenuItem1.Name = "tareToolStripMenuItem1";
            this.tareToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.tareToolStripMenuItem1.Text = "Tare";
            this.tareToolStripMenuItem1.Click += new System.EventHandler(this.tareToolStripMenuItem1_Click);
            // 
            // enableWarningToolStripMenuItem
            // 
            this.enableWarningToolStripMenuItem.Name = "enableWarningToolStripMenuItem";
            this.enableWarningToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.enableWarningToolStripMenuItem.Text = "Enable Warning";
            this.enableWarningToolStripMenuItem.Click += new System.EventHandler(this.enableWarningToolStripMenuItem_Click);
            // 
            // txtBxCurrent
            // 
            this.txtBxCurrent.Enabled = false;
            this.txtBxCurrent.Location = new System.Drawing.Point(228, 122);
            this.txtBxCurrent.Name = "txtBxCurrent";
            this.txtBxCurrent.Size = new System.Drawing.Size(76, 20);
            this.txtBxCurrent.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 259);
            this.Controls.Add(this.txtBxCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtBxTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.commStage);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stepper Motor Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customControl.comboSerial commStage;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtBxTarget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtBxMoveRel;
        private System.Windows.Forms.TextBox txtBxCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem enableWarningToolStripMenuItem;
    }
}

