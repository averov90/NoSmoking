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
	public class Komments : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton1")]
		private RadioButton _RadioButton1;

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton2")]
		private RadioButton _RadioButton2;

		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton3")]
		private RadioButton _RadioButton3;

		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton4")]
		private RadioButton _RadioButton4;

		[CompilerGenerated]
		[AccessedThroughProperty("RadioButton5")]
		private RadioButton _RadioButton5;

		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		private int number;

		[field: AccessedThroughProperty("RadioButton1")]
		internal virtual RadioButton RadioButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("RadioButton2")]
		internal virtual RadioButton RadioButton2 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("RadioButton3")]
		internal virtual RadioButton RadioButton3 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("RadioButton4")]
		internal virtual RadioButton RadioButton4 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("RadioButton5")]
		internal virtual RadioButton RadioButton5 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return _Timer1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Timer1_Tick;
				Timer timer = _Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				_Timer1 = value;
				timer = _Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		public Komments()
		{
			base.FormClosing += Komments_FormClosing;
			base.Shown += Komments_Shown;
			number = 0;
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
			RadioButton1 = new System.Windows.Forms.RadioButton();
			Label1 = new System.Windows.Forms.Label();
			RadioButton2 = new System.Windows.Forms.RadioButton();
			RadioButton3 = new System.Windows.Forms.RadioButton();
			RadioButton4 = new System.Windows.Forms.RadioButton();
			RadioButton5 = new System.Windows.Forms.RadioButton();
			Label2 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			Label5 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			Button1 = new System.Windows.Forms.Button();
			Label9 = new System.Windows.Forms.Label();
			Timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			RadioButton1.AutoSize = true;
			RadioButton1.Checked = true;
			RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			RadioButton1.Location = new System.Drawing.Point(25, 28);
			RadioButton1.Name = "RadioButton1";
			RadioButton1.Size = new System.Drawing.Size(33, 20);
			RadioButton1.TabIndex = 1;
			RadioButton1.TabStop = true;
			RadioButton1.Text = "5";
			ToolTip1.SetToolTip(RadioButton1, "Вам всё нравится в этой программе");
			RadioButton1.UseVisualStyleBackColor = true;
			Label1.AutoSize = true;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label1.Location = new System.Drawing.Point(12, 5);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(112, 20);
			Label1.TabIndex = 2;
			Label1.Text = "Ваша оценка:";
			RadioButton2.AutoSize = true;
			RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			RadioButton2.Location = new System.Drawing.Point(25, 51);
			RadioButton2.Name = "RadioButton2";
			RadioButton2.Size = new System.Drawing.Size(33, 20);
			RadioButton2.TabIndex = 3;
			RadioButton2.Text = "4";
			ToolTip1.SetToolTip(RadioButton2, "Вы считаете программу полезной, но не очень удобной");
			RadioButton2.UseVisualStyleBackColor = true;
			RadioButton3.AutoSize = true;
			RadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			RadioButton3.Location = new System.Drawing.Point(25, 74);
			RadioButton3.Name = "RadioButton3";
			RadioButton3.Size = new System.Drawing.Size(33, 20);
			RadioButton3.TabIndex = 4;
			RadioButton3.Text = "3";
			ToolTip1.SetToolTip(RadioButton3, "Программа не очень полезная и не удобная");
			RadioButton3.UseVisualStyleBackColor = true;
			RadioButton4.AutoSize = true;
			RadioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			RadioButton4.Location = new System.Drawing.Point(25, 97);
			RadioButton4.Name = "RadioButton4";
			RadioButton4.Size = new System.Drawing.Size(33, 20);
			RadioButton4.TabIndex = 5;
			RadioButton4.Text = "2";
			ToolTip1.SetToolTip(RadioButton4, "Вы считаете программу бесполезной");
			RadioButton4.UseVisualStyleBackColor = true;
			RadioButton5.AutoSize = true;
			RadioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			RadioButton5.Location = new System.Drawing.Point(25, 120);
			RadioButton5.Name = "RadioButton5";
			RadioButton5.Size = new System.Drawing.Size(33, 20);
			RadioButton5.TabIndex = 6;
			RadioButton5.Text = "1";
			ToolTip1.SetToolTip(RadioButton5, "Вы считаете программу вредной");
			RadioButton5.UseVisualStyleBackColor = true;
			Label2.AutoSize = true;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label2.Location = new System.Drawing.Point(64, 30);
			Label2.Name = "Label2";
			Label2.Size = new System.Drawing.Size(57, 16);
			Label2.TabIndex = 7;
			Label2.Text = "Хорошо";
			Label3.AutoSize = true;
			Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label3.Location = new System.Drawing.Point(64, 53);
			Label3.Name = "Label3";
			Label3.Size = new System.Drawing.Size(82, 16);
			Label3.TabIndex = 8;
			Label3.Text = "Нормально";
			Label4.AutoSize = true;
			Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label4.Location = new System.Drawing.Point(64, 76);
			Label4.Name = "Label4";
			Label4.Size = new System.Drawing.Size(48, 16);
			Label4.TabIndex = 9;
			Label4.Text = "Плохо";
			Label5.AutoSize = true;
			Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label5.Location = new System.Drawing.Point(64, 99);
			Label5.Name = "Label5";
			Label5.Size = new System.Drawing.Size(90, 16);
			Label5.TabIndex = 10;
			Label5.Text = "Очень плохо";
			Label6.AutoSize = true;
			Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label6.Location = new System.Drawing.Point(64, 122);
			Label6.Name = "Label6";
			Label6.Size = new System.Drawing.Size(57, 16);
			Label6.TabIndex = 11;
			Label6.Text = "Ужасно";
			Label8.AutoSize = true;
			Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label8.ForeColor = System.Drawing.Color.OrangeRed;
			Label8.Location = new System.Drawing.Point(15, 146);
			Label8.Name = "Label8";
			Label8.Size = new System.Drawing.Size(200, 20);
			Label8.TabIndex = 15;
			Label8.Text = "Нам важно ваше мнение!";
			Button1.Enabled = false;
			Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button1.Location = new System.Drawing.Point(12, 169);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(192, 23);
			Button1.TabIndex = 16;
			Button1.Text = "Оценить";
			ToolTip1.SetToolTip(Button1, "Оценить программу и закрыть это окно.");
			Button1.UseVisualStyleBackColor = true;
			Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label9.Location = new System.Drawing.Point(22, 195);
			Label9.Name = "Label9";
			Label9.Size = new System.Drawing.Size(169, 36);
			Label9.TabIndex = 18;
			Label9.Text = "Оценить можно будет через:";
			Timer1.Interval = 1000;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(216, 237);
			base.Controls.Add(Label9);
			base.Controls.Add(Button1);
			base.Controls.Add(Label8);
			base.Controls.Add(Label6);
			base.Controls.Add(Label5);
			base.Controls.Add(Label4);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(RadioButton5);
			base.Controls.Add(RadioButton4);
			base.Controls.Add(RadioButton3);
			base.Controls.Add(RadioButton2);
			base.Controls.Add(Label1);
			base.Controls.Add(RadioButton1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Komments";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Оценить";
			ResumeLayout(false);
			PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			if (RadioButton5.Checked)
			{
				MyProject.Forms.start.Register(": Оценка: Ужасно; ");
			}
			else if (RadioButton4.Checked)
			{
				MyProject.Forms.start.Register(": Оценка: Очень плохо; ");
			}
			else if (RadioButton3.Checked)
			{
				MyProject.Forms.start.Register(": Оценка: Плохо; ");
			}
			else if (RadioButton2.Checked)
			{
				MyProject.Forms.start.Register(": Оценка: Нормально; ");
			}
			else if (RadioButton1.Checked)
			{
				MyProject.Forms.start.Register(": Оценка: Хорошо; ");
			}
			Close();
		}

		private void Komments_FormClosing(object sender, FormClosingEventArgs e)
		{
			Button1.Enabled = true;
			Timer1.Enabled = false;
			MyProject.Computer.Audio.Stop();
		}

		private void Komments_Shown(object sender, EventArgs e)
		{
			Button1.Enabled = false;
			number = 0;
			Timer1.Enabled = true;
			Label9.Text = "Оценить можно будет через: 30 сек.";
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (number == 30)
				{
					MyProject.Computer.Audio.Stop();
					Label9.Text = "Оценивайте.";
					Button1.Enabled = true;
					Timer1.Enabled = false;
				}
				else
				{
					number++;
					Label9.Text = "Оценить можно будет через: " + Conversions.ToString(30 - number) + " сек.";
				}
			}
		}
	}
}
