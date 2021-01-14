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
	public class Settings : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[CompilerGenerated]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[AccessedThroughProperty("DateTimePicker1")]
		private DateTimePicker _DateTimePicker1;

		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox4")]
		private CheckBox _CheckBox4;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox5")]
		private CheckBox _CheckBox5;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox6")]
		private CheckBox _CheckBox6;

		[CompilerGenerated]
		[AccessedThroughProperty("CheckBox7")]
		private CheckBox _CheckBox7;

		[CompilerGenerated]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		[CompilerGenerated]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		private string old_text;

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

		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return _TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = TextBox1_TextChanged;
				TextBox textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				_TextBox1 = value;
				textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("DateTimePicker1")]
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("CheckBox1")]
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("CheckBox2")]
		internal virtual CheckBox CheckBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("CheckBox3")]
		internal virtual CheckBox CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("CheckBox4")]
		internal virtual CheckBox CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("CheckBox5")]
		internal virtual CheckBox CheckBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("CheckBox6")]
		internal virtual CheckBox CheckBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("CheckBox7")]
		internal virtual CheckBox CheckBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

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

		public Settings()
		{
			base.Shown += Settings_Shown;
			old_text = "";
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
			Button1 = new System.Windows.Forms.Button();
			TextBox1 = new System.Windows.Forms.TextBox();
			Label1 = new System.Windows.Forms.Label();
			Button3 = new System.Windows.Forms.Button();
			Label2 = new System.Windows.Forms.Label();
			DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			Label3 = new System.Windows.Forms.Label();
			Button4 = new System.Windows.Forms.Button();
			Label4 = new System.Windows.Forms.Label();
			CheckBox1 = new System.Windows.Forms.CheckBox();
			CheckBox2 = new System.Windows.Forms.CheckBox();
			CheckBox3 = new System.Windows.Forms.CheckBox();
			CheckBox4 = new System.Windows.Forms.CheckBox();
			CheckBox5 = new System.Windows.Forms.CheckBox();
			CheckBox6 = new System.Windows.Forms.CheckBox();
			CheckBox7 = new System.Windows.Forms.CheckBox();
			Label5 = new System.Windows.Forms.Label();
			Button2 = new System.Windows.Forms.Button();
			Button5 = new System.Windows.Forms.Button();
			Label6 = new System.Windows.Forms.Label();
			Button6 = new System.Windows.Forms.Button();
			SuspendLayout();
			Button1.Location = new System.Drawing.Point(214, 374);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(118, 23);
			Button1.TabIndex = 0;
			Button1.Text = "Закрыть";
			Button1.UseVisualStyleBackColor = true;
			TextBox1.Location = new System.Drawing.Point(12, 25);
			TextBox1.MaxLength = 10;
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new System.Drawing.Size(239, 20);
			TextBox1.TabIndex = 3;
			Label1.AutoSize = true;
			Label1.Location = new System.Drawing.Point(12, 9);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(239, 13);
			Label1.TabIndex = 4;
			Label1.Text = "Новый PIN-код (только цифры):";
			Button3.Location = new System.Drawing.Point(257, 25);
			Button3.Name = "Button3";
			Button3.Size = new System.Drawing.Size(72, 23);
			Button3.TabIndex = 5;
			Button3.Text = "ОК";
			Button3.UseVisualStyleBackColor = true;
			Label2.AutoSize = true;
			Label2.Location = new System.Drawing.Point(9, 60);
			Label2.Name = "Label2";
			Label2.Size = new System.Drawing.Size(303, 13);
			Label2.TabIndex = 6;
			Label2.Text = "Новая дата (изменять не рекомендуем):";
			DateTimePicker1.Location = new System.Drawing.Point(142, 76);
			DateTimePicker1.Name = "DateTimePicker1";
			DateTimePicker1.Size = new System.Drawing.Size(190, 20);
			DateTimePicker1.TabIndex = 7;
			Label3.AutoSize = true;
			Label3.Location = new System.Drawing.Point(9, 82);
			Label3.Name = "Label3";
			Label3.Size = new System.Drawing.Size(127, 13);
			Label3.TabIndex = 8;
			Label3.Text = "Дата окончания:";
			Button4.Location = new System.Drawing.Point(237, 102);
			Button4.Name = "Button4";
			Button4.Size = new System.Drawing.Size(92, 23);
			Button4.TabIndex = 9;
			Button4.Text = "Изменить";
			Button4.UseVisualStyleBackColor = true;
			Label4.AutoSize = true;
			Label4.Location = new System.Drawing.Point(12, 128);
			Label4.Name = "Label4";
			Label4.Size = new System.Drawing.Size(223, 26);
			Label4.TabIndex = 10;
			Label4.Text = "Отключить модули программы:\r\n(не рекомендуем)";
			CheckBox1.AutoSize = true;
			CheckBox1.Location = new System.Drawing.Point(30, 157);
			CheckBox1.Name = "CheckBox1";
			CheckBox1.Size = new System.Drawing.Size(106, 17);
			CheckBox1.TabIndex = 11;
			CheckBox1.Text = "Страница 1";
			CheckBox1.UseVisualStyleBackColor = true;
			CheckBox2.AutoSize = true;
			CheckBox2.Location = new System.Drawing.Point(30, 180);
			CheckBox2.Name = "CheckBox2";
			CheckBox2.Size = new System.Drawing.Size(106, 17);
			CheckBox2.TabIndex = 12;
			CheckBox2.Text = "Страница 2";
			CheckBox2.UseVisualStyleBackColor = true;
			CheckBox3.AutoSize = true;
			CheckBox3.Location = new System.Drawing.Point(142, 157);
			CheckBox3.Name = "CheckBox3";
			CheckBox3.Size = new System.Drawing.Size(130, 17);
			CheckBox3.TabIndex = 13;
			CheckBox3.Text = "Почему 1 год?";
			CheckBox3.UseVisualStyleBackColor = true;
			CheckBox4.AutoSize = true;
			CheckBox4.Location = new System.Drawing.Point(142, 180);
			CheckBox4.Name = "CheckBox4";
			CheckBox4.Size = new System.Drawing.Size(146, 17);
			CheckBox4.TabIndex = 14;
			CheckBox4.Text = "Просмотр фильма";
			CheckBox4.UseVisualStyleBackColor = true;
			CheckBox5.AutoSize = true;
			CheckBox5.Location = new System.Drawing.Point(30, 203);
			CheckBox5.Name = "CheckBox5";
			CheckBox5.Size = new System.Drawing.Size(66, 17);
			CheckBox5.TabIndex = 15;
			CheckBox5.Text = "Опрос";
			CheckBox5.UseVisualStyleBackColor = true;
			CheckBox6.AutoSize = true;
			CheckBox6.Location = new System.Drawing.Point(142, 203);
			CheckBox6.Name = "CheckBox6";
			CheckBox6.Size = new System.Drawing.Size(74, 17);
			CheckBox6.TabIndex = 16;
			CheckBox6.Text = "Оценка";
			CheckBox6.UseVisualStyleBackColor = true;
			CheckBox7.AutoSize = true;
			CheckBox7.Location = new System.Drawing.Point(30, 226);
			CheckBox7.Name = "CheckBox7";
			CheckBox7.Size = new System.Drawing.Size(242, 17);
			CheckBox7.TabIndex = 17;
			CheckBox7.Text = "Инф. о кол-ве дней до конца";
			CheckBox7.UseVisualStyleBackColor = true;
			Label5.AutoSize = true;
			Label5.Location = new System.Drawing.Point(12, 272);
			Label5.Name = "Label5";
			Label5.Size = new System.Drawing.Size(223, 26);
			Label5.TabIndex = 18;
			Label5.Text = "Перезапустить Анти-Курение:\r\n(не рекомендуем)";
			Button2.Location = new System.Drawing.Point(15, 301);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(121, 23);
			Button2.TabIndex = 19;
			Button2.Text = "Перезапуск";
			Button2.UseVisualStyleBackColor = true;
			Button5.Location = new System.Drawing.Point(240, 246);
			Button5.Name = "Button5";
			Button5.Size = new System.Drawing.Size(89, 23);
			Button5.TabIndex = 20;
			Button5.Text = "Сохранить";
			Button5.UseVisualStyleBackColor = true;
			Label6.AutoSize = true;
			Label6.Location = new System.Drawing.Point(9, 337);
			Label6.Name = "Label6";
			Label6.Size = new System.Drawing.Size(127, 13);
			Label6.TabIndex = 21;
			Label6.Text = "Открыть журнал:";
			Button6.Location = new System.Drawing.Point(142, 332);
			Button6.Name = "Button6";
			Button6.Size = new System.Drawing.Size(93, 23);
			Button6.TabIndex = 22;
			Button6.Text = "Журнал";
			Button6.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ControlLight;
			base.ClientSize = new System.Drawing.Size(341, 407);
			base.Controls.Add(Button6);
			base.Controls.Add(Label6);
			base.Controls.Add(Button5);
			base.Controls.Add(Button2);
			base.Controls.Add(Label5);
			base.Controls.Add(CheckBox7);
			base.Controls.Add(CheckBox6);
			base.Controls.Add(CheckBox5);
			base.Controls.Add(CheckBox4);
			base.Controls.Add(CheckBox3);
			base.Controls.Add(CheckBox2);
			base.Controls.Add(CheckBox1);
			base.Controls.Add(Label4);
			base.Controls.Add(Button4);
			base.Controls.Add(Label3);
			base.Controls.Add(DateTimePicker1);
			base.Controls.Add(Label2);
			base.Controls.Add(Button3);
			base.Controls.Add(Label1);
			base.Controls.Add(TextBox1);
			base.Controls.Add(Button1);
			Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Settings";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Настройки";
			ResumeLayout(false);
			PerformLayout();
		}

		private void Settings_Shown(object sender, EventArgs e)
		{
			TextBox1.Text = MyProject.Forms.start.inf[0];
			DateTime dateTime = DateAndTime.DateAdd(DateInterval.Day, 1.0, DateAndTime.DateValue(MyProject.Forms.start.data[1]));
			DateTimePicker1.MinDate = dateTime;
			dateTime = DateAndTime.DateAdd(DateInterval.Year, 1.0, dateTime);
			dateTime = DateAndTime.DateAdd(DateInterval.Month, 1.0, dateTime);
			DateTimePicker1.Value = Conversions.ToDate(MyProject.Forms.start.data[2]);
			DateTimePicker1.MaxDate = dateTime;
			if (Operators.CompareString(MyProject.Forms.start.inf[1], "open", TextCompare: false) == 0)
			{
				CheckBox1.Checked = false;
			}
			else
			{
				CheckBox1.Checked = true;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[2], "open", TextCompare: false) == 0)
			{
				CheckBox2.Checked = false;
			}
			else
			{
				CheckBox2.Checked = true;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[3], "open", TextCompare: false) == 0)
			{
				CheckBox3.Checked = false;
			}
			else
			{
				CheckBox3.Checked = true;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[4], "open", TextCompare: false) == 0)
			{
				CheckBox4.Checked = false;
			}
			else
			{
				CheckBox4.Checked = true;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[5], "open", TextCompare: false) == 0)
			{
				CheckBox5.Checked = false;
			}
			else
			{
				CheckBox5.Checked = true;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[6], "open", TextCompare: false) == 0)
			{
				CheckBox6.Checked = false;
			}
			else
			{
				CheckBox6.Checked = true;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[7], "open", TextCompare: false) == 0)
			{
				CheckBox7.Checked = false;
			}
			else
			{
				CheckBox7.Checked = true;
			}
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				Conversions.ToShort(TextBox1.Text);
				old_text = TextBox1.Text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Operators.CompareString(TextBox1.Text, "", TextCompare: false) == 0)
				{
					old_text = TextBox1.Text;
				}
				else
				{
					TextBox1.Text = old_text;
					TextBox1.SelectionStart = TextBox1.Text.Length;
				}
				ProjectData.ClearProjectError();
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			Close();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			if (Operators.CompareString(TextBox1.Text, "", TextCompare: false) != 0)
			{
				MyProject.Forms.start.inf[0] = TextBox1.Text;
				MyProject.Forms.start.infwrite();
				Interaction.MsgBox("PIN-код изменён!", MsgBoxStyle.OkOnly, "Информация");
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			MyProject.Forms.start.data[2] = Conversions.ToString(DateTimePicker1.Value);
			MyProject.Forms.start.write();
			Interaction.MsgBox("Дата изменёна!", MsgBoxStyle.OkOnly, "Информация");
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			if (CheckBox1.Checked)
			{
				MyProject.Forms.start.inf[1] = "close";
			}
			else
			{
				MyProject.Forms.start.inf[1] = "open";
			}
			if (CheckBox2.Checked)
			{
				MyProject.Forms.start.inf[2] = "close";
			}
			else
			{
				MyProject.Forms.start.inf[2] = "open";
			}
			if (CheckBox3.Checked)
			{
				MyProject.Forms.start.inf[3] = "close";
			}
			else
			{
				MyProject.Forms.start.inf[3] = "open";
			}
			if (CheckBox4.Checked)
			{
				MyProject.Forms.start.inf[4] = "close";
			}
			else
			{
				MyProject.Forms.start.inf[4] = "open";
			}
			if (CheckBox5.Checked)
			{
				MyProject.Forms.start.inf[5] = "close";
			}
			else
			{
				MyProject.Forms.start.inf[5] = "open";
			}
			if (CheckBox6.Checked)
			{
				MyProject.Forms.start.inf[6] = "close";
			}
			else
			{
				MyProject.Forms.start.inf[6] = "open";
			}
			if (CheckBox7.Checked)
			{
				MyProject.Forms.start.inf[7] = "close";
			}
			else
			{
				MyProject.Forms.start.inf[7] = "open";
			}
			MyProject.Forms.start.infwrite();
			Interaction.MsgBox("Настройки изменёны! Рекомендуем перезагрузить Анти-Курение!", MsgBoxStyle.OkOnly, "Информация");
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button2_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("Вы действительно хотите перезапустить Анти-Курение (данные о начале цикла будут удалены)?", MsgBoxStyle.YesNo, "Подтверждение") == MsgBoxResult.Yes)
			{
				FileSystem.FileClose(1);
				MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "/MyDiary.dat");
				Interaction.MsgBox("Анти-Курение должно быть перезагружено...", MsgBoxStyle.OkOnly, "Предупреждение");
				ProjectData.EndApp();
			}
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			MyProject.Forms.Events_View.ShowDialog();
		}
	}
}
