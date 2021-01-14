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
	public class Events_View : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		[field: AccessedThroughProperty("TextBox1")]
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		internal virtual LinkLabel LinkLabel1
		{
			[CompilerGenerated]
			get
			{
				return _LinkLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = LinkLabel1_LinkClicked;
				LinkLabel linkLabel = _LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked -= value2;
				}
				_LinkLabel1 = value;
				linkLabel = _LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked += value2;
				}
			}
		}

		public Events_View()
		{
			base.Shown += Events_View_Shown;
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
			TextBox1 = new System.Windows.Forms.TextBox();
			Button1 = new System.Windows.Forms.Button();
			Button2 = new System.Windows.Forms.Button();
			LinkLabel1 = new System.Windows.Forms.LinkLabel();
			SuspendLayout();
			TextBox1.BackColor = System.Drawing.SystemColors.Menu;
			TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			TextBox1.Font = new System.Drawing.Font("Lucida Fax", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			TextBox1.Location = new System.Drawing.Point(12, 12);
			TextBox1.MaxLength = 10000;
			TextBox1.Multiline = true;
			TextBox1.Name = "TextBox1";
			TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			TextBox1.Size = new System.Drawing.Size(352, 262);
			TextBox1.TabIndex = 0;
			TextBox1.WordWrap = false;
			Button1.Location = new System.Drawing.Point(244, 281);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(119, 23);
			Button1.TabIndex = 1;
			Button1.Text = "Закрыть";
			Button1.UseVisualStyleBackColor = true;
			Button2.Location = new System.Drawing.Point(12, 278);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(82, 23);
			Button2.TabIndex = 2;
			Button2.Text = "Очистить";
			Button2.UseVisualStyleBackColor = true;
			LinkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
			LinkLabel1.AutoSize = true;
			LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
			LinkLabel1.LinkColor = System.Drawing.Color.DimGray;
			LinkLabel1.Location = new System.Drawing.Point(119, 286);
			LinkLabel1.Name = "LinkLabel1";
			LinkLabel1.Size = new System.Drawing.Size(119, 13);
			LinkLabel1.TabIndex = 3;
			LinkLabel1.TabStop = true;
			LinkLabel1.Text = "Что это такое?";
			LinkLabel1.VisitedLinkColor = System.Drawing.Color.Silver;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ControlLight;
			base.ClientSize = new System.Drawing.Size(376, 313);
			base.Controls.Add(LinkLabel1);
			base.Controls.Add(Button2);
			base.Controls.Add(Button1);
			base.Controls.Add(TextBox1);
			Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Events_View";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Журнал";
			ResumeLayout(false);
			PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button2_Click(object sender, EventArgs e)
		{
			if (Interaction.MsgBox("Вы действительно хотите удалить ВСЕ данные журнала Анти-Курение?", MsgBoxStyle.YesNo, "Подтверждение") == MsgBoxResult.Yes)
			{
				FileSystem.FileClose(2);
				MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "/MyComplex.dat");
				Interaction.MsgBox("Анти-Курение должно быть перезагружено...", MsgBoxStyle.OkOnly, "Предупреждение");
				ProjectData.EndApp();
			}
		}

		private void Events_View_Shown(object sender, EventArgs e)
		{
			TextBox1.Lines = MyProject.Forms.start.dat;
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			Interaction.MsgBox("Перед каждым событием пишется дата его происхождения.\nВ журнале фиксируются только важные события.\n---- Список обозначений событий ----\nЗапуск - Анти-Курение запущено; Отключение - Анти-Курение выключено (закрыто)\n\nДата выбрана - установлена дата начала и(или) конца цикла Анти-Курение\n\nОценка: /оценка/ - Оченка, которую пользователь поставил программе (можно отключить возможность оценивания в настройках)\n\nСтадия: /стадия/ - Номер стадии, на которой находится пользователь (от 1 до 6: слежение, бросить 1-ую сигарету, бросить 2-ую сягарету, не курите первые четыре часа, оставьте только 4 сигареты, не курите)\n\nМиссия выполнена! - сообщение, которое будет записано в журнал после положительного ответа на спрос конечных результатов работы Анти-Курение\n\nСостояние: /состояние/ - пожалуй, то, ради чего вам стоит смотреть журнал. Это показатель успехов работы программы, но не общих, а промежуточных (именно по ним строится график)\n\nСогласие получено - сообщение, которое записывается в журнал после соглсия пользователя работать с Анти-Курение", MsgBoxStyle.OkOnly, "Информация");
		}
	}
}
