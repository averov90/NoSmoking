using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Anti_Kurenie.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Anti_Kurenie
{
	[DesignerGenerated]
	public class start : Form
	{
		public string[] data;

		public string[] inf;

		public string[] dat;

		private string write_line;

		public string version;

		private IContainer components;

		public start()
		{
			base.Load += start_Load;
			base.Shown += start_Shown;
			data = new string[4];
			version = "1.0.1.4";
			InitializeComponent();
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void start_Load(object sender, EventArgs e)
		{
			base.Left = checked(MyProject.Computer.Screen.Bounds.Left - 200);
			if (!MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "/MyDiary.dat"))
			{
				MyProject.Computer.FileSystem.WriteAllText(Application.StartupPath + "/MyDiary.dat", "", append: false);
				string[] array = new string[4];
				File.WriteAllLines(Application.StartupPath + "/MyDiary.dat", array);
				data[0] = array[0];
				data[1] = array[1];
				data[2] = array[2];
				data[3] = array[3];
			}
			else
			{
				string[] array2 = File.ReadAllLines(Application.StartupPath + "/MyDiary.dat");
				if (array2.Length == 0)
				{
					Array.Resize(ref array2, 3);
					File.WriteAllLines(Application.StartupPath + "/MyDiary.dat", array2);
				}
				data[0] = array2[0];
				data[1] = array2[1];
				data[2] = array2[2];
				data[3] = array2[3];
			}
			if (!MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "/MyComplex.dat"))
			{
				MyProject.Computer.FileSystem.WriteAllText(Application.StartupPath + "/MyComplex.dat", "", append: false);
				Array.Resize(ref dat, 0);
			}
			else
			{
				dat = File.ReadAllLines(Application.StartupPath + "/MyComplex.dat");
			}
			if (!MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "/MyInfo.dat"))
			{
				MyProject.Computer.FileSystem.WriteAllText(Application.StartupPath + "/MyInfo.dat", "", append: false);
				Array.Resize(ref inf, 8);
				inf[0] = "0000";
				inf[1] = "open";
				inf[2] = "open";
				inf[3] = "open";
				inf[4] = "open";
				inf[5] = "open";
				inf[6] = "open";
				inf[7] = "open";
				File.WriteAllLines(Application.StartupPath + "/MyInfo.dat", inf);
			}
			else
			{
				inf = File.ReadAllLines(Application.StartupPath + "/MyInfo.dat");
			}
			FileSystem.FileOpen(1, Application.StartupPath + "/MyDiary.dat", OpenMode.Binary);
			FileSystem.FileOpen(3, Application.StartupPath + "/MyInfo.dat", OpenMode.Binary);
		}

		private void start_Shown(object sender, EventArgs e)
		{
			checked
			{
				Array.Resize(ref dat, dat.Length + 1);
				write_line = Conversions.ToString(dat.Length - 1);
				File.WriteAllLines(Application.StartupPath + "/MyComplex.dat", dat);
				Register(": Запуск.; ");
				if (Operators.CompareString(data[3], "OK", TextCompare: false) != 0)
				{
					if (Operators.CompareString(data[0], "Yes", TextCompare: false) != 0)
					{
						MyProject.Forms.Yes.ShowDialog();
					}
					if (Operators.CompareString(data[0], "Yes", TextCompare: false) == 0)
					{
						if (Operators.CompareString(data[1], "", TextCompare: false) == 0)
						{
							MyProject.Forms.phon.ShowDialog();
						}
						else
						{
							DateTime dateTime = DateAndTime.DateValue(data[1]);
							DateTime dateTime2 = DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime));
							DateTime dateTime3 = DateAndTime.DateValue(data[2]);
							if (((dateTime2.Day >= dateTime3.Day) & (dateTime2.Month == dateTime3.Month) & (dateTime2.Year == dateTime3.Year)) | ((dateTime2.Month > dateTime3.Month) & (dateTime2.Year == dateTime3.Year)) | (dateTime2.Year > dateTime3.Year))
							{
								MyProject.Forms.no_smoking_winner.ShowDialog();
							}
							else if (((dateTime2.Day >= dateTime.Day) & (dateTime2.Month == dateTime.Month) & (dateTime2.Year == dateTime.Year)) | ((dateTime2.Month > dateTime.Month) & (dateTime2.Year == dateTime.Year)) | (dateTime2.Year > dateTime.Year))
							{
								MyProject.Forms.phon.ShowDialog();
							}
							else
							{
								Interaction.MsgBox("До начала цикла Анти-Курение осталось: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.DayOfYear, MyProject.Computer.Clock.LocalTime, DateAndTime.DateValue(data[1]))) + "/день/", MsgBoxStyle.OkOnly, "Анти-Курение");
							}
						}
					}
				}
				Register(": Отключение.; ");
				Close();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void write()
		{
			FileSystem.FileClose(1);
			File.WriteAllLines(Application.StartupPath + "/MyDiary.dat", data);
			FileSystem.FileOpen(1, Application.StartupPath + "/MyDiary.dat", OpenMode.Binary);
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void infwrite()
		{
			FileSystem.FileClose(3);
			File.WriteAllLines(Application.StartupPath + "/MyInfo.dat", inf);
			FileSystem.FileOpen(3, Application.StartupPath + "/MyInfo.dat", OpenMode.Binary);
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void Register(string data_text)
		{
			FileSystem.FileClose(2);
			dat = File.ReadAllLines(Application.StartupPath + "/MyComplex.dat");
			dat[Conversions.ToInteger(write_line)] = dat[Conversions.ToInteger(write_line)] + Conversions.ToString(MyProject.Computer.Clock.LocalTime.Day) + "." + Conversions.ToString(MyProject.Computer.Clock.LocalTime.Month) + "." + Conversions.ToString(MyProject.Computer.Clock.LocalTime.Year) + data_text;
			File.WriteAllLines(Application.StartupPath + "/MyComplex.dat", dat);
			FileSystem.FileOpen(2, Application.StartupPath + "/MyComplex.dat", OpenMode.Binary);
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.start));
			SuspendLayout();
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Menu;
			base.ClientSize = new System.Drawing.Size(4, 4);
			base.ControlBox = false;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "start";
			base.ShowInTaskbar = false;
			ResumeLayout(false);
		}
	}
}
