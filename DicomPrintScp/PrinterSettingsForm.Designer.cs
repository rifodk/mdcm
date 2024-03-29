﻿namespace DicomPrintScp {
	partial class PrinterSettingsForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbPreviewOnly = new System.Windows.Forms.CheckBox();
			this.tbAETitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbPaperSource = new System.Windows.Forms.ComboBox();
			this.tbPrinterName = new System.Windows.Forms.TextBox();
			this.bttnSelectPrinter = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(282, 176);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "&Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(201, 176);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "&OK";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Printer:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tray:";
			// 
			// cbPreviewOnly
			// 
			this.cbPreviewOnly.AutoSize = true;
			this.cbPreviewOnly.Location = new System.Drawing.Point(100, 128);
			this.cbPreviewOnly.Name = "cbPreviewOnly";
			this.cbPreviewOnly.Size = new System.Drawing.Size(88, 17);
			this.cbPreviewOnly.TabIndex = 2;
			this.cbPreviewOnly.Text = "Preview Only";
			this.cbPreviewOnly.UseVisualStyleBackColor = true;
			this.cbPreviewOnly.CheckedChanged += new System.EventHandler(this.OnPreviewOnlyChanged);
			// 
			// tbAETitle
			// 
			this.tbAETitle.Location = new System.Drawing.Point(100, 21);
			this.tbAETitle.MaxLength = 16;
			this.tbAETitle.Name = "tbAETitle";
			this.tbAETitle.Size = new System.Drawing.Size(100, 20);
			this.tbAETitle.TabIndex = 0;
			this.tbAETitle.TextChanged += new System.EventHandler(this.OnChangeAETitle);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "AE Title:";
			// 
			// cbPaperSource
			// 
			this.cbPaperSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPaperSource.FormattingEnabled = true;
			this.cbPaperSource.Location = new System.Drawing.Point(100, 92);
			this.cbPaperSource.Name = "cbPaperSource";
			this.cbPaperSource.Size = new System.Drawing.Size(200, 21);
			this.cbPaperSource.TabIndex = 11;
			this.cbPaperSource.SelectedIndexChanged += new System.EventHandler(this.OnSelectTray);
			// 
			// tbPrinterName
			// 
			this.tbPrinterName.Location = new System.Drawing.Point(100, 65);
			this.tbPrinterName.Name = "tbPrinterName";
			this.tbPrinterName.ReadOnly = true;
			this.tbPrinterName.Size = new System.Drawing.Size(200, 20);
			this.tbPrinterName.TabIndex = 12;
			// 
			// bttnSelectPrinter
			// 
			this.bttnSelectPrinter.Location = new System.Drawing.Point(306, 63);
			this.bttnSelectPrinter.Name = "bttnSelectPrinter";
			this.bttnSelectPrinter.Size = new System.Drawing.Size(34, 22);
			this.bttnSelectPrinter.TabIndex = 13;
			this.bttnSelectPrinter.Text = "...";
			this.bttnSelectPrinter.UseVisualStyleBackColor = true;
			this.bttnSelectPrinter.Click += new System.EventHandler(this.OnSelectPrinter);
			// 
			// PrinterSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 211);
			this.ControlBox = false;
			this.Controls.Add(this.bttnSelectPrinter);
			this.Controls.Add(this.tbPrinterName);
			this.Controls.Add(this.cbPaperSource);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbAETitle);
			this.Controls.Add(this.cbPreviewOnly);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "PrinterSettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DICOM Printer Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbPreviewOnly;
		private System.Windows.Forms.TextBox tbAETitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbPaperSource;
		private System.Windows.Forms.TextBox tbPrinterName;
		private System.Windows.Forms.Button bttnSelectPrinter;
	}
}