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
	public class no_smoking_winner : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		private Point point;

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("ToolTip1")]
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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
				EventHandler value2 = Button1_Click_1;
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

		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return _Button2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button2_Click_1;
				Button button = _Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button2 = value;
				button = _Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		public no_smoking_winner()
		{
			base.Move += no_smoking_winner_Move;
			base.Shown += no_smoking_winner_Shown;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.no_smoking_winner));
			Label1 = new System.Windows.Forms.Label();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			Button1 = new System.Windows.Forms.Button();
			Button2 = new System.Windows.Forms.Button();
			Label2 = new System.Windows.Forms.Label();
			SuspendLayout();
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label1.Location = new System.Drawing.Point(12, 68);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(312, 64);
			Label1.TabIndex = 0;
			Label1.Text = "Пожалуйста, ответьте честно, с чистой совестью на вопрос: \r\n                                    Вы бросили курить?";
			ToolTip1.SetToolTip(Label1, "Для того, кто бросил курить.");
			Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button1.Location = new System.Drawing.Point(161, 135);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(75, 31);
			Button1.TabIndex = 9;
			Button1.Text = "Да";
			ToolTip1.SetToolTip(Button1, "Вы бросили курить и больше никогда курить не будете.");
			Button1.UseVisualStyleBackColor = true;
			Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button2.Location = new System.Drawing.Point(249, 135);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(75, 31);
			Button2.TabIndex = 10;
			Button2.Text = "Нет";
			ToolTip1.SetToolTip(Button2, "Вы ещё курите.");
			Button2.UseVisualStyleBackColor = true;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label2.Location = new System.Drawing.Point(12, 9);
			Label2.Name = "Label2";
			Label2.Size = new System.Drawing.Size(312, 65);
			Label2.TabIndex = 11;
			Label2.Text = "Время, отведённое вам, чтобы вы бросили курить, истекло!\r\n----------------------------------------------------------";
			ToolTip1.SetToolTip(Label2, "Для того, кто бросил курить.");
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(336, 176);
			base.Controls.Add(Label1);
			base.Controls.Add(Label2);
			base.Controls.Add(Button2);
			base.Controls.Add(Button1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "no_smoking_winner";
			base.ShowInTaskbar = false;
			Text = "Анти-Курение";
			base.TopMost = true;
			ResumeLayout(false);
		}

		private void no_smoking_winner_Move(object sender, EventArgs e)
		{
			base.Left = point.X;
			base.Top = point.Y;
		}

		private void no_smoking_winner_Shown(object sender, EventArgs e)
		{
			checked
			{
				point.X = (int)Math.Round((double)MyProject.Computer.Screen.Bounds.Width / 2.0 - (double)base.Width / 2.0);
				point.Y = (int)Math.Round((double)MyProject.Computer.Screen.Bounds.Height / 2.0 - (double)base.Height / 2.0);
				base.Left = (int)Math.Round((double)MyProject.Computer.Screen.Bounds.Width / 2.0 - (double)base.Width / 2.0);
				base.Top = (int)Math.Round((double)MyProject.Computer.Screen.Bounds.Height / 2.0 - (double)base.Height / 2.0);
			}
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			MyProject.Forms.start.data[3] = "OK";
			MyProject.Forms.start.write();
			MyProject.Forms.start.Register(": Миссия выполнена!; ");
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			Interaction.MsgBox("Вы совершили огромный подвиг! Вы можете этим гордится! Вы отказались от сигарет навсегда!", MsgBoxStyle.OkOnly, "Сообщение");
			Close();
		}

		private void Button2_Click_1(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			MyProject.Forms.start.data[1] = Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime)).Day) + "." + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime)).Month) + "." + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime)).Year);
			MyProject.Forms.start.data[2] = Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime)).Day) + "." + Conversions.ToString(DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime)).Month) + "." + Conversions.ToString(checked(DateAndTime.DateValue(Conversions.ToString(MyProject.Computer.Clock.LocalTime)).Year + 1));
			MyProject.Forms.start.data[3] = "";
			MyProject.Forms.start.write();
			Interaction.MsgBox("Увы, вы не справились с задачей... Ну ничего страшного, мы ещё попробуем!", MsgBoxStyle.OkOnly, "Сообщение");
			Close();
		}
	}
}
