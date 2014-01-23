﻿namespace WorldSmith.Dialogs.Actions
{
    partial class TargetKeyEditor
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkChance = new System.Windows.Forms.LinkLabel();
            this.linkTargetFilter = new System.Windows.Forms.LinkLabel();
            this.linkLineOrCircle = new System.Windows.Forms.LinkLabel();
            this.linkHeader = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Preset";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Custom";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkChance);
            this.panel1.Controls.Add(this.linkTargetFilter);
            this.panel1.Controls.Add(this.linkLineOrCircle);
            this.panel1.Controls.Add(this.linkHeader);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 163);
            this.panel1.TabIndex = 3;
            // 
            // linkChance
            // 
            this.linkChance.AutoSize = true;
            this.linkChance.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkChance.Location = new System.Drawing.Point(6, 117);
            this.linkChance.Name = "linkChance";
            this.linkChance.Size = new System.Drawing.Size(266, 13);
            this.linkChance.TabIndex = 3;
            this.linkChance.Text = "And selects %MaxTargets and %Random addition units";
            // 
            // linkTargetFilter
            // 
            this.linkTargetFilter.AutoSize = true;
            this.linkTargetFilter.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkTargetFilter.Location = new System.Drawing.Point(6, 82);
            this.linkTargetFilter.Name = "linkTargetFilter";
            this.linkTargetFilter.Size = new System.Drawing.Size(220, 13);
            this.linkTargetFilter.TabIndex = 2;
            this.linkTargetFilter.Text = "That targets %Types on %Teams with %Flags";
            // 
            // linkLineOrCircle
            // 
            this.linkLineOrCircle.AutoSize = true;
            this.linkLineOrCircle.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLineOrCircle.Location = new System.Drawing.Point(6, 48);
            this.linkLineOrCircle.Name = "linkLineOrCircle";
            this.linkLineOrCircle.Size = new System.Drawing.Size(339, 13);
            this.linkLineOrCircle.TabIndex = 1;
            this.linkLineOrCircle.Text = "With radius %Radius | With length %length and Thickness %Thickness";
            // 
            // linkHeader
            // 
            this.linkHeader.AutoSize = true;
            this.linkHeader.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkHeader.Location = new System.Drawing.Point(6, 15);
            this.linkHeader.Name = "linkHeader";
            this.linkHeader.Size = new System.Drawing.Size(205, 13);
            this.linkHeader.TabIndex = 0;
            this.linkHeader.Text = "Create a %Type centered around %Center";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(13, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TargetKeyEditor
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(374, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton1);
            this.Name = "TargetKeyEditor";
            this.Text = "TargetKeyEditor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkChance;
        private System.Windows.Forms.LinkLabel linkTargetFilter;
        private System.Windows.Forms.LinkLabel linkLineOrCircle;
        private System.Windows.Forms.LinkLabel linkHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}