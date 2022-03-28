using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringKlasseVCs
{
	public partial class FString : Form
	{
		public FString()
		{
			InitializeComponent();
		}

		private void Cmd_Lng_Click(object sender, EventArgs e)
		{
			Lbl_Ausgabe.Text = "";
			string eingabe;

			eingabe = Txt_Eingabe.Text;
			Lbl_Ausgabe.Text = $"Länge: {eingabe.Length}";

		}

		private void Cmd_Char_Click(object sender, EventArgs e)
		{
			Lbl_Ausgabe.Text = "";
			string eingabe, ausgabe;

			char zeichen;

			eingabe = Txt_Eingabe.Text;

			ausgabe = "Zeichen: \n";
			for (int i = 0; i < eingabe.Length; i++)
			{
				zeichen = eingabe[i];
				ausgabe += $"{i}: {zeichen} \n";

			}

			Lbl_Ausgabe.Text = ausgabe;
		}

		private void Cmd_Trim_Click(object sender, EventArgs e)
		{
			Lbl_Ausgabe.Text = "";

			string eingabe, getrimmt, ausgabe;
			eingabe = Txt_Eingabe.Text;

			getrimmt = eingabe.Trim(' ', ';', '#');
			ausgabe = $"Getrimmt: |{getrimmt}|";

			Lbl_Ausgabe.Text = ausgabe;
		}

		private void Cmd_Split_Click(object sender, EventArgs e)
		{
			Lbl_Ausgabe.Text = "";
			string eingabe = Txt_Eingabe.Text;
			string[] teil;

			teil = eingabe.Split(';',' ');

			Lbl_Ausgabe.Text = "Worte: \n";

			for (int i = 0; i < teil.Length; i++)
			{
				Lbl_Ausgabe.Text += $"Wort {i}: {teil[i]} \n";
			}
		}

		private void Cmd_Look1_Click(object sender, EventArgs e)
		{
			Lbl_Ausgabe.Text = "";
			string eingabe, suche, ausgabe;
			int position;

			eingabe = Txt_Eingabe.Text;
			suche = Txt_Suche.Text;
			position = eingabe.IndexOf(suche);

			ausgabe = $"Suchtext bei Zeichen: {position}";
			Lbl_Ausgabe.Text = ausgabe;
		}

		private void Cmd_LookAll_Click(object sender, EventArgs e)
		{
			Lbl_Ausgabe.Text = "";
			string eingabe, suche, ausgabe;
			int position, suchstart = 0, anzahl = 0;

			eingabe = Txt_Eingabe.Text;
			suche = Txt_Suche.Text;

			if (eingabe == "" || suche == "") return;

			ausgabe = "Suchtext bei Zeichen: \n";

			do
			{
				position = eingabe.IndexOf(suche, suchstart);
				suchstart = position++;

				if (position != -1)
				{
					ausgabe += $"{position} \n";
					anzahl++;
				}
			}
			while (position != -1);

			ausgabe += $"Anzahl: {anzahl}";
			Lbl_Ausgabe.Text = ausgabe;
		}
	}
}
