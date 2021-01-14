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
	public class Opros : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		[CompilerGenerated]
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		private int select_button;

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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
				EventHandler value2 = Button2_Click;
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

		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return _Button3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button3_Click;
				Button button = _Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button3 = value;
				button = _Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return _Button4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button4_Click;
				Button button = _Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button4 = value;
				button = _Button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return _Button5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button5_Click;
				Button button = _Button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button5 = value;
				button = _Button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return _Button6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button6_Click;
				Button button = _Button6;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button6 = value;
				button = _Button6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button Button7
		{
			[CompilerGenerated]
			get
			{
				return _Button7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button7_Click;
				Button button = _Button7;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button7 = value;
				button = _Button7;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("ToolTip1")]
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		public Opros()
		{
			select_button = 0;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.Opros));
			Label1 = new System.Windows.Forms.Label();
			Button1 = new System.Windows.Forms.Button();
			Button2 = new System.Windows.Forms.Button();
			Button3 = new System.Windows.Forms.Button();
			Button4 = new System.Windows.Forms.Button();
			Button5 = new System.Windows.Forms.Button();
			Button6 = new System.Windows.Forms.Button();
			Button7 = new System.Windows.Forms.Button();
			Label2 = new System.Windows.Forms.Label();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			SuspendLayout();
			Label1.AutoSize = true;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label1.Location = new System.Drawing.Point(12, 9);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(265, 16);
			Label1.TabIndex = 1;
			Label1.Text = "Как вы себя чуствуете на этой стадии?";
			Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			Button1.Location = new System.Drawing.Point(195, 249);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(79, 23);
			Button1.TabIndex = 2;
			Button1.Text = "ОК";
			ToolTip1.SetToolTip(Button1, "Принять (далее)");
			Button1.UseVisualStyleBackColor = true;
			Button2.BackColor = System.Drawing.Color.SpringGreen;
			Button2.Location = new System.Drawing.Point(12, 40);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(259, 25);
			Button2.TabIndex = 3;
			Button2.Text = "Хорошо! Со всем справляюсь!";
			ToolTip1.SetToolTip(Button2, "Вы хорошо себя чуствуете, выполнение этой задачи пошло вам напользу");
			Button2.UseVisualStyleBackColor = false;
			Button3.BackColor = System.Drawing.Color.MediumSeaGreen;
			Button3.Location = new System.Drawing.Point(12, 71);
			Button3.Name = "Button3";
			Button3.Size = new System.Drawing.Size(259, 25);
			Button3.TabIndex = 4;
			Button3.Text = "Нормально. Тяжело, но справляюсь.";
			ToolTip1.SetToolTip(Button3, "Вам достаточно тяжело выполнить эту задачу, но её выполнение помогает вам");
			Button3.UseVisualStyleBackColor = false;
			Button4.BackColor = System.Drawing.Color.Goldenrod;
			Button4.Location = new System.Drawing.Point(12, 102);
			Button4.Name = "Button4";
			Button4.Size = new System.Drawing.Size(259, 25);
			Button4.TabIndex = 5;
			Button4.Text = "Не очень хорошо. Справляюсь, но не со всем.";
			ToolTip1.SetToolTip(Button4, "Вы плохо справляетесь с задачей, вам не удаётся выполнить её целиком");
			Button4.UseVisualStyleBackColor = false;
			Button5.BackColor = System.Drawing.Color.DarkGoldenrod;
			Button5.Location = new System.Drawing.Point(12, 133);
			Button5.Name = "Button5";
			Button5.Size = new System.Drawing.Size(259, 25);
			Button5.TabIndex = 6;
			Button5.Text = "Плохо. Еле-еле что-то делаю.";
			ToolTip1.SetToolTip(Button5, "Вы можете, и то с большим трудом, выполнить только небольшую часть от поставленной задачи");
			Button5.UseVisualStyleBackColor = false;
			Button6.BackColor = System.Drawing.Color.OrangeRed;
			Button6.Location = new System.Drawing.Point(12, 164);
			Button6.Name = "Button6";
			Button6.Size = new System.Drawing.Size(259, 25);
			Button6.TabIndex = 7;
			Button6.Text = "Очень плохо. Не могу ничего поделать.";
			ToolTip1.SetToolTip(Button6, "Вы стараетесь выполнить задачу, но никаких изменений нет");
			Button6.UseVisualStyleBackColor = false;
			Button7.BackColor = System.Drawing.Color.Brown;
			Button7.Location = new System.Drawing.Point(12, 195);
			Button7.Name = "Button7";
			Button7.Size = new System.Drawing.Size(259, 25);
			Button7.TabIndex = 8;
			Button7.Text = "Ужас! Без сигарет - жить не могу!";
			ToolTip1.SetToolTip(Button7, "Стараясь выполнить задачу, вы стали курить ещё больше");
			Button7.UseVisualStyleBackColor = false;
			Label2.AutoSize = true;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label2.Location = new System.Drawing.Point(9, 223);
			Label2.Name = "Label2";
			Label2.Size = new System.Drawing.Size(141, 16);
			Label2.TabIndex = 9;
			Label2.Text = "Вы выбрали: ничего.";
			ToolTip1.SetToolTip(Label2, "Ваш выбор (меняется, когда вы нажимаете кнопки выше)");
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(286, 284);
			base.Controls.Add(Label2);
			base.Controls.Add(Button7);
			base.Controls.Add(Button6);
			base.Controls.Add(Button5);
			base.Controls.Add(Button4);
			base.Controls.Add(Button3);
			base.Controls.Add(Button2);
			base.Controls.Add(Button1);
			base.Controls.Add(Label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Opros";
			base.ShowIcon = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Ваше самочуствие и результаты";
			ResumeLayout(false);
			PerformLayout();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			select_button = 1;
			Label2.Text = "Вы выбрали: Хорошо!";
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			select_button = 2;
			Label2.Text = "Вы выбрали: Нормально.";
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			select_button = 3;
			Label2.Text = "Вы выбрали: Не очень хорошо.";
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			select_button = 4;
			Label2.Text = "Вы выбрали: Плохо.";
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			select_button = 5;
			Label2.Text = "Вы выбрали: Очень плохо.";
		}

		private void Button7_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			select_button = 6;
			Label2.Text = "Вы выбрали: Ужас!";
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			if (select_button == 1)
			{
				MyProject.Forms.start.Register(": Состояние: Хорошо! Со всем справляюсь!; ");
				Close();
			}
			else if (select_button == 2)
			{
				MyProject.Forms.start.Register(": Состояние: Нормально. Тяжело, но справляюсь.; ");
				Close();
			}
			else if (select_button == 3)
			{
				MyProject.Forms.start.Register(": Состояние: Не очень хорошо. Справляюсь, но не со всем.; ");
				Close();
			}
			else if (select_button == 4)
			{
				MyProject.Forms.start.Register(": Состояние: Плохо. Еле-еле что-то делаю.; ");
				Close();
			}
			else if (select_button == 5)
			{
				MyProject.Forms.start.Register(": Состояние: Очень плохо. Не могу ничего поделать.; ");
				Close();
			}
			else if (select_button == 6)
			{
				MyProject.Forms.start.Register(": Состояние: Ужас! Без сигарет - жить не могу!; ");
				Close();
			}
			else
			{
				Interaction.MsgBox("Вы ничего не выбрали!", MsgBoxStyle.OkOnly, "Сообщение ");
			}
		}
	}
}
