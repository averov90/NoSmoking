using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Anti_Kurenie.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Anti_Kurenie
{
	[DesignerGenerated]
	public class data : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker1")]
		private DateTimePicker _DateTimePicker1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		private bool cancel;

		[field: AccessedThroughProperty("DateTimePicker1")]
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return _Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button1_Click;
				Button button = _Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button1 = value;
				button = _Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("ToolTip1")]
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		public data()
		{
			base.FormClosing += Form1_FormClosing;
			base.Load += data_Load;
			cancel = true;
			InitializeComponent();
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.data));
			DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			Button1 = new System.Windows.Forms.Button();
			Label1 = new System.Windows.Forms.Label();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			SuspendLayout();
			DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			DateTimePicker1.Location = new System.Drawing.Point(13, 31);
			DateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
			DateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			DateTimePicker1.Name = "DateTimePicker1";
			DateTimePicker1.Size = new System.Drawing.Size(299, 22);
			DateTimePicker1.TabIndex = 0;
			ToolTip1.SetToolTip(DateTimePicker1, "Здесь вам надо выбрать дату начала цикла \"Анти-Курение\".");
			Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button1.Location = new System.Drawing.Point(195, 59);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(117, 31);
			Button1.TabIndex = 1;
			Button1.Text = "Начать!";
			ToolTip1.SetToolTip(Button1, "Принять дату.");
			Button1.UseVisualStyleBackColor = true;
			Label1.AutoSize = true;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label1.Location = new System.Drawing.Point(13, 12);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(152, 16);
			Label1.TabIndex = 2;
			Label1.Text = "Введите дату начала:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(324, 102);
			base.Controls.Add(Label1);
			base.Controls.Add(Button1);
			base.Controls.Add(DateTimePicker1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "data";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			Text = "Анти-Курение";
			ResumeLayout(false);
			PerformLayout();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (cancel)
			{
				Interaction.MsgBox("Пожалуйста, укажите дату начала цикла 'Анти-Курение' и нажмите кнопку 'Начать!'.", MsgBoxStyle.OkOnly, "Сообщение");
				e.Cancel = true;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.start.data[1] = Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Day) + "." + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Month) + "." + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Year);
			MyProject.Forms.start.data[2] = Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Day) + "." + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Month) + "." + Conversions.ToString(checked(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Year + 1));
			MyProject.Forms.start.write();
			cancel = false;
			MyProject.Forms.phon.cansel = true;
			MyProject.Forms.start.Register(": Дата выбрана.; ");
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			Close();
		}

		private void data_Load(object sender, EventArgs e)
		{
			DateTimePicker1.MinDate = DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime));
			DateTimePicker1.MaxDate = DateAndTime.DateValue(Conversions.ToString(Conversions.ToDate(Conversions.ToString(DateTimePicker1.Value.Day) + "." + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Month) + "." + Conversions.ToString(checked(DateAndTime.DateValue(Conversions.ToString(DateTimePicker1.Value)).Year + 1)))));
		}
	}
}
