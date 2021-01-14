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
	public class no_smoking : Form
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
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		[CompilerGenerated]
		[AccessedThroughProperty("КопироватьToolStripMenuItem")]
		private ToolStripMenuItem _КопироватьToolStripMenuItem;

		[CompilerGenerated]
		[AccessedThroughProperty("КопироватьВсёToolStripMenuItem")]
		private ToolStripMenuItem _КопироватьВсёToolStripMenuItem;

		[CompilerGenerated]
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		[CompilerGenerated]
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		private int i;

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

		[field: AccessedThroughProperty("ToolTip1")]
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		[field: AccessedThroughProperty("ContextMenuStrip1")]
		internal virtual ContextMenuStrip ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		internal virtual ToolStripMenuItem КопироватьToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _КопироватьToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = КопироватьToolStripMenuItem_Click;
				ToolStripMenuItem копироватьToolStripMenuItem = _КопироватьToolStripMenuItem;
				if (копироватьToolStripMenuItem != null)
				{
					копироватьToolStripMenuItem.Click -= value2;
				}
				_КопироватьToolStripMenuItem = value;
				копироватьToolStripMenuItem = _КопироватьToolStripMenuItem;
				if (копироватьToolStripMenuItem != null)
				{
					копироватьToolStripMenuItem.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem КопироватьВсёToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return _КопироватьВсёToolStripMenuItem;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = КопироватьВсёToolStripMenuItem_Click;
				ToolStripMenuItem копироватьВсёToolStripMenuItem = _КопироватьВсёToolStripMenuItem;
				if (копироватьВсёToolStripMenuItem != null)
				{
					копироватьВсёToolStripMenuItem.Click -= value2;
				}
				_КопироватьВсёToolStripMenuItem = value;
				копироватьВсёToolStripMenuItem = _КопироватьВсёToolStripMenuItem;
				if (копироватьВсёToolStripMenuItem != null)
				{
					копироватьВсёToolStripMenuItem.Click += value2;
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

		public no_smoking()
		{
			base.FormClosing += Form1_FormClosing;
			base.Shown += no_smoking_Shown;
			i = 0;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.no_smoking));
			TextBox1 = new System.Windows.Forms.TextBox();
			ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			КопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			КопироватьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			Button1 = new System.Windows.Forms.Button();
			Button2 = new System.Windows.Forms.Button();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			Button3 = new System.Windows.Forms.Button();
			Button4 = new System.Windows.Forms.Button();
			Button5 = new System.Windows.Forms.Button();
			ContextMenuStrip1.SuspendLayout();
			SuspendLayout();
			TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			TextBox1.BackColor = System.Drawing.SystemColors.Window;
			TextBox1.ContextMenuStrip = ContextMenuStrip1;
			TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			TextBox1.Location = new System.Drawing.Point(12, 12);
			TextBox1.Multiline = true;
			TextBox1.Name = "TextBox1";
			TextBox1.ReadOnly = true;
			TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			TextBox1.Size = new System.Drawing.Size(470, 419);
			TextBox1.TabIndex = 0;
			TextBox1.Text = resources.GetString("TextBox1.Text");
			ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { КопироватьToolStripMenuItem, КопироватьВсёToolStripMenuItem });
			ContextMenuStrip1.Name = "ContextMenuStrip1";
			ContextMenuStrip1.Size = new System.Drawing.Size(173, 48);
			КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem";
			КопироватьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			КопироватьToolStripMenuItem.Text = "Копировать";
			КопироватьToolStripMenuItem.ToolTipText = "Копировать выделенный текст.";
			КопироватьВсёToolStripMenuItem.Name = "КопироватьВсёToolStripMenuItem";
			КопироватьВсёToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			КопироватьВсёToolStripMenuItem.Text = "Копировать всё";
			КопироватьВсёToolStripMenuItem.ToolTipText = "Копировать весь текст.";
			Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			Button1.Location = new System.Drawing.Point(375, 437);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(106, 23);
			Button1.TabIndex = 1;
			Button1.Text = "OK";
			ToolTip1.SetToolTip(Button1, "Далее");
			Button1.UseVisualStyleBackColor = true;
			Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Button2.Location = new System.Drawing.Point(12, 437);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(110, 23);
			Button2.TabIndex = 2;
			Button2.Text = "Почему 1 год?";
			ToolTip1.SetToolTip(Button2, "Объяснение 365-дневной методики \"Анти-Курение\"");
			Button2.UseVisualStyleBackColor = true;
			Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			Button3.Location = new System.Drawing.Point(297, 437);
			Button3.Name = "Button3";
			Button3.Size = new System.Drawing.Size(72, 23);
			Button3.TabIndex = 4;
			Button3.Text = "Оценить";
			ToolTip1.SetToolTip(Button3, "Оценить программу");
			Button3.UseVisualStyleBackColor = true;
			Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Button4.Location = new System.Drawing.Point(128, 437);
			Button4.Name = "Button4";
			Button4.Size = new System.Drawing.Size(83, 23);
			Button4.TabIndex = 5;
			Button4.Text = "О программе";
			ToolTip1.SetToolTip(Button4, "Информация о программе");
			Button4.UseVisualStyleBackColor = true;
			Button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			Button5.Location = new System.Drawing.Point(217, 437);
			Button5.Name = "Button5";
			Button5.Size = new System.Drawing.Size(74, 23);
			Button5.TabIndex = 6;
			Button5.Text = "График";
			ToolTip1.SetToolTip(Button5, "Информация о программе");
			Button5.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(494, 472);
			base.Controls.Add(Button5);
			base.Controls.Add(Button1);
			base.Controls.Add(Button2);
			base.Controls.Add(Button3);
			base.Controls.Add(TextBox1);
			base.Controls.Add(Button4);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(510, 116);
			base.Name = "no_smoking";
			base.ShowIcon = false;
			Text = "Анти-Курение";
			ContextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			MyProject.Forms.phon.cansel = true;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Stop();
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			checked
			{
				if (i == 0)
				{
					if (Operators.CompareString(MyProject.Forms.start.inf[2], "close", TextCompare: false) == 0)
					{
						i += 2;
						string text = "Исключайте курение из списка привычек.";
						int num = (int)DateAndTime.DateDiff(DateInterval.DayOfYear, DateAndTime.DateValue(MyProject.Forms.start.data[1]), MyProject.Computer.Clock.LocalTime);
						if (num >= 49)
						{
							text = "Не курите (вообще).";
							MyProject.Forms.start.Register(": Стадия: 6.; ");
						}
						else if (unchecked(num >= 35 && num < 49))
						{
							text = "Оставьте для курения только 4 основные сигареты (на случай, если после предыдущих стадий у вас осталось менее 4 сигарет, то исключите следующую сигарету). (у вас на это: " + Conversions.ToString(49 - num) + " /день/)";
							MyProject.Forms.start.Register(": Стадия: 5.; ");
						}
						else if (unchecked(num >= 21 && num < 35))
						{
							text = "Не курите первые 4 (можно и больше) часа после того как встанете (с утчётом сна вы не должны курить 12 часов, в противном случае - после побудки не курите оставшееся до нормы время). (у вас на это: " + Conversions.ToString(35 - num) + " /день/)";
							MyProject.Forms.start.Register(": Стадия: 4.; ");
						}
						else if (unchecked(num >= 14 && num < 21))
						{
							text = "Исключите вторую, но важную (опорную) для вас сигарету. (у вас на это: " + Conversions.ToString(21 - num) + " /день/)";
							MyProject.Forms.start.Register(": Стадия: 3.; ");
						}
						else if (unchecked(num >= 7 && num < 14))
						{
							text = "Исключите одну, но очень важную (опорную) для вас сигарету. (у вас на это: " + Conversions.ToString(14 - num) + " /день/)";
							MyProject.Forms.start.Register(": Стадия: 2.; ");
						}
						else if (num >= 0)
						{
							text = "Следите за собой: установите время курения, колличество сигарет в день, тягу к курению в зависитмости от времени суток. (у вас на это: " + Conversions.ToString(7 - num) + " /день/)";
							MyProject.Forms.start.Register(": Стадия: 1.; ");
						}
						TextBox1.Text = "Ваша задача: " + text;
						if (Operators.CompareString(MyProject.Forms.start.inf[5], "open", TextCompare: false) == 0)
						{
							MyProject.Forms.Opros.ShowDialog();
						}
					}
					else
					{
						i++;
						string[] lines = new string[6] { "1) вместе с дымом в организм поступают не только никотин, углекислый газ и всякие смолы, но и практически все элементы таблицы Менделеева. Следовательно, количество грязи в крови постоянно поддерживается на определенном уровне, и организм к этому привыкает. Если эта привычная дрянь не поступает в кровь, организм дает сбой — чего-то хочется, но непонятно чего. В качестве замены удобнее всего использовать поваренную соль в виде соленой рыбы вечером и сушеных кальмаров или анчоусов в течение дня;", "2) углекислота оказывает возбуждающее действие на дыхательный центр головного мозга, и мозг привыкает к постоянной стимуляции этого центра. Поэтому, когда перестаешь курить, возникает ощущение, что не хватает воздуха, — не можешь надышаться и забываешь вовремя вдохнуть. При нехватке кислорода у человека автоматически возникает тревожное состояние и срабатывает инстинкт самосохранения, который в данном случае проще всего удовлетворить возвратом к курению. Если не впадать в истерику, то стимулировать дыхательный центр можно с помощью препарата «Кордиамин». Это диэтиламид никотиновой кислоты, являющийся дыхательным аналептиком. В самые тяжкие моменты можно накапать в стакан капель 30, разбавить водой и выпить. Но не более 5 раз в день, иначе может подскочить давление;", "3) никотин успокаивает и стабилизирует нервную систему. При отказе от него могут возникнуть повышенная возбудимость, раздражительность, быстрая утомляемость, невозможность сосредоточиться на чем-то, периодически может падать давление и т. д. Чтобы сгладить все эти негативы, можно использовать валерьянку и кофе. Кофе пить чуть крепче или чаще, а экстракт валерианы в таблетках пропить курсом по 2 таблетки 3 раза в день в течение двух-трех недель;", "4) после курения усиливается перистальтика кишечника (специальные его сокращения, которые способствуют перемещению съеденного на выход) — естественно, при отмене табака кишечник может начать бастовать. Посему нужно временно снизить потребление легкоусвояемой белковой пищи и булок, налечь на овощи, включить в рацион недозрелые бананы, чернослив, свеклу, кефир и т. д. После обильной трапезы обязательно принимать фестал или другие ферментативные препараты;", "5) человеческий организм — очень хитрая штука, и, раз уж в него поступает целая куча химических элементов, он начинает ими не только травиться, но и кое-что использовать. Плюс к тому начало перестройки обмена веществ — это большой стресс, и, чтобы быстрее с ним справиться, нужно начать прием витаминов. Причем обязательно в комбинации с минералами;", "6) у кого-то психическая зависимость, связанная с определенной моторикой, ритуалами и привычными действиями, проходит довольно быстро и легко, у кого-то наоборот — именно сила привычки, а не физический дискомфорт заставляет снова взяться за сигарету. В любом случае на первое время рот надо чем-то занять. Похожее раздражение слизистой оболочки полости рта, глотки и трахеи можно вызвать употреблением самого жестокомятного «Тик-така» или других похожих конфет, а моторную недостачу можно восполнить поеданием семечек. Только расщелкивать их надо обязательно руками." };
						TextBox1.Lines = lines;
					}
				}
				else if (i == 1)
				{
					i++;
					string text2 = "Исключайте курение из списка привычек.";
					int num2 = (int)DateAndTime.DateDiff(DateInterval.DayOfYear, DateAndTime.DateValue(MyProject.Forms.start.data[1]), MyProject.Computer.Clock.LocalTime);
					if (num2 >= 49)
					{
						text2 = "Не курите (вообще).";
						MyProject.Forms.start.Register(": Стадия: 6.; ");
					}
					else if (unchecked(num2 >= 35 && num2 < 49))
					{
						text2 = "Оставьте для курения только 4 основные сигареты (на случай, если после предыдущих стадий у вас осталось менее 4 сигарет, то исключите следующую сигарету). (у вас на это: " + Conversions.ToString(49 - num2) + " /день/)";
						MyProject.Forms.start.Register(": Стадия: 5.; ");
					}
					else if (unchecked(num2 >= 21 && num2 < 35))
					{
						text2 = "Не курите первые 4 (можно и больше) часа после того как встанете (с утчётом сна вы не должны курить 12 часов, в противном случае - после побудки не курите оставшееся до нормы время). (у вас на это: " + Conversions.ToString(35 - num2) + " /день/)";
						MyProject.Forms.start.Register(": Стадия: 4.; ");
					}
					else if (unchecked(num2 >= 14 && num2 < 21))
					{
						text2 = "Исключите вторую, но важную (опорную) для вас сигарету. (у вас на это: " + Conversions.ToString(21 - num2) + " /день/)";
						MyProject.Forms.start.Register(": Стадия: 3.; ");
					}
					else if (unchecked(num2 >= 7 && num2 < 14))
					{
						text2 = "Исключите одну, но очень важную (опорную) для вас сигарету. (у вас на это: " + Conversions.ToString(14 - num2) + " /день/)";
						MyProject.Forms.start.Register(": Стадия: 2.; ");
					}
					else if (num2 >= 0)
					{
						text2 = "Следите за собой: установите время курения, колличество сигарет в день, тягу к курению в зависитмости от времени суток. (у вас на это: " + Conversions.ToString(7 - num2) + " /день/)";
						MyProject.Forms.start.Register(": Стадия: 1.; ");
					}
					TextBox1.Text = "Ваша задача: " + text2;
					if (Operators.CompareString(MyProject.Forms.start.inf[5], "open", TextCompare: false) == 0)
					{
						MyProject.Forms.Opros.ShowDialog();
					}
				}
				else if (i == 2)
				{
					i++;
					if (Operators.CompareString(MyProject.Forms.start.inf[7], "open", TextCompare: false) == 0)
					{
						Interaction.MsgBox("Если вы будете выполнять все задачи, то бросите курить через: " + Conversions.ToString(DateAndTime.DateDiff(DateInterval.DayOfYear, MyProject.Computer.Clock.LocalTime, DateAndTime.DateValue(MyProject.Forms.start.data[2]))) + "/день/", MsgBoxStyle.OkOnly, "Сообщение");
					}
					MyProject.Forms.phon.cansel = true;
					MyProject.Forms.one.Close();
					Close();
				}
				MyProject.Forms.start.write();
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			MyProject.Forms.one.Close();
			MyProject.Forms.one.Show();
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			MyProject.Forms.Komments.ShowDialog();
		}

		private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (TextBox1.SelectionLength > 0)
			{
				MyProject.Computer.Clipboard.SetText(TextBox1.SelectedText);
			}
		}

		private void КопироватьВсёToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Computer.Clipboard.SetText(TextBox1.Text);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			MyProject.Forms.AbountProgramm.ShowDialog();
		}

		private void no_smoking_Shown(object sender, EventArgs e)
		{
			if (Operators.CompareString(MyProject.Forms.start.inf[1], "close", TextCompare: false) == 0)
			{
				i = 1;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[3], "close", TextCompare: false) == 0)
			{
				Button2.Enabled = false;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[6], "close", TextCompare: false) == 0)
			{
				Button3.Enabled = false;
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[1], "close", TextCompare: false) == 0)
			{
				string[] lines = new string[6] { "1) вместе с дымом в организм поступают не только никотин, углекислый газ и всякие смолы, но и практически все элементы таблицы Менделеева. Следовательно, количество грязи в крови постоянно поддерживается на определенном уровне, и организм к этому привыкает. Если эта привычная дрянь не поступает в кровь, организм дает сбой — чего-то хочется, но непонятно чего. В качестве замены удобнее всего использовать поваренную соль в виде соленой рыбы вечером и сушеных кальмаров или анчоусов в течение дня;", "2) углекислота оказывает возбуждающее действие на дыхательный центр головного мозга, и мозг привыкает к постоянной стимуляции этого центра. Поэтому, когда перестаешь курить, возникает ощущение, что не хватает воздуха, — не можешь надышаться и забываешь вовремя вдохнуть. При нехватке кислорода у человека автоматически возникает тревожное состояние и срабатывает инстинкт самосохранения, который в данном случае проще всего удовлетворить возвратом к курению. Если не впадать в истерику, то стимулировать дыхательный центр можно с помощью препарата «Кордиамин». Это диэтиламид никотиновой кислоты, являющийся дыхательным аналептиком. В самые тяжкие моменты можно накапать в стакан капель 30, разбавить водой и выпить. Но не более 5 раз в день, иначе может подскочить давление;", "3) никотин успокаивает и стабилизирует нервную систему. При отказе от него могут возникнуть повышенная возбудимость, раздражительность, быстрая утомляемость, невозможность сосредоточиться на чем-то, периодически может падать давление и т. д. Чтобы сгладить все эти негативы, можно использовать валерьянку и кофе. Кофе пить чуть крепче или чаще, а экстракт валерианы в таблетках пропить курсом по 2 таблетки 3 раза в день в течение двух-трех недель;", "4) после курения усиливается перистальтика кишечника (специальные его сокращения, которые способствуют перемещению съеденного на выход) — естественно, при отмене табака кишечник может начать бастовать. Посему нужно временно снизить потребление легкоусвояемой белковой пищи и булок, налечь на овощи, включить в рацион недозрелые бананы, чернослив, свеклу, кефир и т. д. После обильной трапезы обязательно принимать фестал или другие ферментативные препараты;", "5) человеческий организм — очень хитрая штука, и, раз уж в него поступает целая куча химических элементов, он начинает ими не только травиться, но и кое-что использовать. Плюс к тому начало перестройки обмена веществ — это большой стресс, и, чтобы быстрее с ним справиться, нужно начать прием витаминов. Причем обязательно в комбинации с минералами;", "6) у кого-то психическая зависимость, связанная с определенной моторикой, ритуалами и привычными действиями, проходит довольно быстро и легко, у кого-то наоборот — именно сила привычки, а не физический дискомфорт заставляет снова взяться за сигарету. В любом случае на первое время рот надо чем-то занять. Похожее раздражение слизистой оболочки полости рта, глотки и трахеи можно вызвать употреблением самого жестокомятного «Тик-така» или других похожих конфет, а моторную недостачу можно восполнить поеданием семечек. Только расщелкивать их надо обязательно руками." };
				TextBox1.Lines = lines;
			}
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			MyProject.Forms.Results.ShowDialog();
		}
	}
}
