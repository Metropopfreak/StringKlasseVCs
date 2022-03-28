
namespace StringKlasseVCs
{
	partial class FString
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
			this.Cmd_Lng = new System.Windows.Forms.Button();
			this.Cmd_Char = new System.Windows.Forms.Button();
			this.Cmd_Trim = new System.Windows.Forms.Button();
			this.Cmd_Split = new System.Windows.Forms.Button();
			this.Txt_Eingabe = new System.Windows.Forms.TextBox();
			this.Cmd_Look1 = new System.Windows.Forms.Button();
			this.Cmd_LookAll = new System.Windows.Forms.Button();
			this.Txt_Suche = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Lbl_Ausgabe = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Cmd_Lng
			// 
			this.Cmd_Lng.Location = new System.Drawing.Point(759, 41);
			this.Cmd_Lng.Name = "Cmd_Lng";
			this.Cmd_Lng.Size = new System.Drawing.Size(122, 36);
			this.Cmd_Lng.TabIndex = 0;
			this.Cmd_Lng.Text = "Länge";
			this.Cmd_Lng.UseVisualStyleBackColor = true;
			this.Cmd_Lng.Click += new System.EventHandler(this.Cmd_Lng_Click);
			// 
			// Cmd_Char
			// 
			this.Cmd_Char.Location = new System.Drawing.Point(759, 83);
			this.Cmd_Char.Name = "Cmd_Char";
			this.Cmd_Char.Size = new System.Drawing.Size(122, 35);
			this.Cmd_Char.TabIndex = 1;
			this.Cmd_Char.Text = "Zeichen";
			this.Cmd_Char.UseVisualStyleBackColor = true;
			this.Cmd_Char.Click += new System.EventHandler(this.Cmd_Char_Click);
			// 
			// Cmd_Trim
			// 
			this.Cmd_Trim.Location = new System.Drawing.Point(759, 124);
			this.Cmd_Trim.Name = "Cmd_Trim";
			this.Cmd_Trim.Size = new System.Drawing.Size(122, 36);
			this.Cmd_Trim.TabIndex = 2;
			this.Cmd_Trim.Text = "Trimmen";
			this.Cmd_Trim.UseVisualStyleBackColor = true;
			this.Cmd_Trim.Click += new System.EventHandler(this.Cmd_Trim_Click);
			// 
			// Cmd_Split
			// 
			this.Cmd_Split.Location = new System.Drawing.Point(759, 166);
			this.Cmd_Split.Name = "Cmd_Split";
			this.Cmd_Split.Size = new System.Drawing.Size(122, 36);
			this.Cmd_Split.TabIndex = 3;
			this.Cmd_Split.Text = "Splitten";
			this.Cmd_Split.UseVisualStyleBackColor = true;
			this.Cmd_Split.Click += new System.EventHandler(this.Cmd_Split_Click);
			// 
			// Txt_Eingabe
			// 
			this.Txt_Eingabe.AcceptsReturn = true;
			this.Txt_Eingabe.AcceptsTab = true;
			this.Txt_Eingabe.Location = new System.Drawing.Point(74, 51);
			this.Txt_Eingabe.Name = "Txt_Eingabe";
			this.Txt_Eingabe.Size = new System.Drawing.Size(306, 26);
			this.Txt_Eingabe.TabIndex = 0;
			// 
			// Cmd_Look1
			// 
			this.Cmd_Look1.Location = new System.Drawing.Point(759, 388);
			this.Cmd_Look1.Name = "Cmd_Look1";
			this.Cmd_Look1.Size = new System.Drawing.Size(122, 36);
			this.Cmd_Look1.TabIndex = 5;
			this.Cmd_Look1.Text = "Suche 1";
			this.Cmd_Look1.UseVisualStyleBackColor = true;
			this.Cmd_Look1.Click += new System.EventHandler(this.Cmd_Look1_Click);
			// 
			// Cmd_LookAll
			// 
			this.Cmd_LookAll.Location = new System.Drawing.Point(759, 430);
			this.Cmd_LookAll.Name = "Cmd_LookAll";
			this.Cmd_LookAll.Size = new System.Drawing.Size(122, 36);
			this.Cmd_LookAll.TabIndex = 6;
			this.Cmd_LookAll.Text = "Suche Alle";
			this.Cmd_LookAll.UseVisualStyleBackColor = true;
			this.Cmd_LookAll.Click += new System.EventHandler(this.Cmd_LookAll_Click);
			// 
			// Txt_Suche
			// 
			this.Txt_Suche.Location = new System.Drawing.Point(734, 318);
			this.Txt_Suche.Name = "Txt_Suche";
			this.Txt_Suche.Size = new System.Drawing.Size(147, 26);
			this.Txt_Suche.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(730, 296);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 19);
			this.label1.TabIndex = 8;
			this.label1.Text = "Suche: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 19);
			this.label2.TabIndex = 9;
			this.label2.Text = "Eingabe:";
			// 
			// Lbl_Ausgabe
			// 
			this.Lbl_Ausgabe.AutoSize = true;
			this.Lbl_Ausgabe.Location = new System.Drawing.Point(70, 133);
			this.Lbl_Ausgabe.Name = "Lbl_Ausgabe";
			this.Lbl_Ausgabe.Size = new System.Drawing.Size(72, 19);
			this.Lbl_Ausgabe.TabIndex = 10;
			this.Lbl_Ausgabe.Text = "Ausgabe";
			// 
			// FString
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 546);
			this.Controls.Add(this.Lbl_Ausgabe);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Txt_Suche);
			this.Controls.Add(this.Cmd_LookAll);
			this.Controls.Add(this.Cmd_Look1);
			this.Controls.Add(this.Txt_Eingabe);
			this.Controls.Add(this.Cmd_Split);
			this.Controls.Add(this.Cmd_Trim);
			this.Controls.Add(this.Cmd_Char);
			this.Controls.Add(this.Cmd_Lng);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FString";
			this.Text = "Die String Klasse";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Cmd_Lng;
		private System.Windows.Forms.Button Cmd_Char;
		private System.Windows.Forms.Button Cmd_Trim;
		private System.Windows.Forms.Button Cmd_Split;
		private System.Windows.Forms.TextBox Txt_Eingabe;
		private System.Windows.Forms.Button Cmd_Look1;
		private System.Windows.Forms.Button Cmd_LookAll;
		private System.Windows.Forms.TextBox Txt_Suche;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Lbl_Ausgabe;
	}
}

