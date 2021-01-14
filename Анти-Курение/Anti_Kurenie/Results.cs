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
	public class Results : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

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
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		[CompilerGenerated]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[AccessedThroughProperty("ListBox1")]
		private ListBox _ListBox1;

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
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[CompilerGenerated]
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[CompilerGenerated]
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		[CompilerGenerated]
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		[CompilerGenerated]
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		[CompilerGenerated]
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		[CompilerGenerated]
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		private short[] states_dat;

		private short add_days;

		[field: AccessedThroughProperty("PictureBox1")]
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		internal virtual ComboBox ComboBox1
		{
			[CompilerGenerated]
			get
			{
				return _ComboBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox1_SelectedIndexChanged;
				ComboBox comboBox = _ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_ComboBox1 = value;
				comboBox = _ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		internal virtual ListBox ListBox1
		{
			[CompilerGenerated]
			get
			{
				return _ListBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ListBox1_SelectedIndexChanged;
				ListBox listBox = _ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= value2;
				}
				_ListBox1 = value;
				listBox = _ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		[field: AccessedThroughProperty("Label16")]
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label17")]
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		public Results()
		{
			base.Shown += Results_Shown;
			states_dat = new short[1];
			add_days = 0;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.Results));
			PictureBox1 = new System.Windows.Forms.PictureBox();
			Button1 = new System.Windows.Forms.Button();
			Button2 = new System.Windows.Forms.Button();
			Label1 = new System.Windows.Forms.Label();
			ComboBox1 = new System.Windows.Forms.ComboBox();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			ListBox1 = new System.Windows.Forms.ListBox();
			Label5 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			Button3 = new System.Windows.Forms.Button();
			Label16 = new System.Windows.Forms.Label();
			Label17 = new System.Windows.Forms.Label();
			Label12 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			Label4 = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			Label7 = new System.Windows.Forms.Label();
			Label13 = new System.Windows.Forms.Label();
			Label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			PictureBox1.Location = new System.Drawing.Point(12, 12);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new System.Drawing.Size(400, 220);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			PictureBox1.TabIndex = 2;
			PictureBox1.TabStop = false;
			Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button1.Location = new System.Drawing.Point(12, 238);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(34, 24);
			Button1.TabIndex = 3;
			Button1.Text = "+";
			Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			ToolTip1.SetToolTip(Button1, "Увеличить размер окна.");
			Button1.UseVisualStyleBackColor = true;
			Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button2.Location = new System.Drawing.Point(12, 268);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(34, 24);
			Button2.TabIndex = 4;
			Button2.Text = "-";
			Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			ToolTip1.SetToolTip(Button2, "Уменьшить размер окна.");
			Button2.UseVisualStyleBackColor = true;
			Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label1.AutoSize = true;
			Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label1.Location = new System.Drawing.Point(52, 238);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(228, 16);
			Label1.TabIndex = 5;
			Label1.Text = "Режим маштабирования графика:";
			ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			ComboBox1.FormattingEnabled = true;
			ComboBox1.Items.AddRange(new object[3] { "Показать всю статистику", "Показать 200 статистических разделов", "Показать 10 статистических разделов" });
			ComboBox1.Location = new System.Drawing.Point(55, 268);
			ComboBox1.Name = "ComboBox1";
			ComboBox1.Size = new System.Drawing.Size(225, 21);
			ComboBox1.TabIndex = 6;
			ToolTip1.SetToolTip(ComboBox1, "Режим маштабирования графика.");
			ListBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			ListBox1.Enabled = false;
			ListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			ListBox1.FormattingEnabled = true;
			ListBox1.HorizontalScrollbar = true;
			ListBox1.ItemHeight = 16;
			ListBox1.Location = new System.Drawing.Point(12, 324);
			ListBox1.Name = "ListBox1";
			ListBox1.Size = new System.Drawing.Size(58, 68);
			ListBox1.TabIndex = 9;
			ToolTip1.SetToolTip(ListBox1, "Здесь вам нужо выбрать номер графика.");
			Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label5.AutoSize = true;
			Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label5.Location = new System.Drawing.Point(286, 275);
			Label5.Name = "Label5";
			Label5.Size = new System.Drawing.Size(75, 16);
			Label5.TabIndex = 11;
			Label5.Text = "Позиция: -";
			ToolTip1.SetToolTip(Label5, "Здесь указана позиция графика (используется при маштабировании).");
			Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label9.AutoSize = true;
			Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label9.Location = new System.Drawing.Point(235, 308);
			Label9.Name = "Label9";
			Label9.Size = new System.Drawing.Size(12, 16);
			Label9.TabIndex = 15;
			Label9.Text = "-";
			ToolTip1.SetToolTip(Label9, "Здесь указано ваше общее состояние (от самого начала до текущего времени).");
			Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label10.AutoSize = true;
			Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label10.Location = new System.Drawing.Point(235, 324);
			Label10.Name = "Label10";
			Label10.Size = new System.Drawing.Size(12, 16);
			Label10.TabIndex = 16;
			Label10.Text = "-";
			ToolTip1.SetToolTip(Label10, "Здесь указано ваше состояние относительно 1 половины всех данных состояния.");
			Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label8.BackColor = System.Drawing.Color.Silver;
			Label8.Location = new System.Drawing.Point(96, 306);
			Label8.Name = "Label8";
			Label8.Size = new System.Drawing.Size(20, 20);
			Label8.TabIndex = 20;
			ToolTip1.SetToolTip(Label8, "Цветограмма.");
			Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Button3.Enabled = false;
			Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button3.Location = new System.Drawing.Point(343, 376);
			Button3.Name = "Button3";
			Button3.Size = new System.Drawing.Size(79, 24);
			Button3.TabIndex = 23;
			Button3.Text = "Добавить";
			Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			ToolTip1.SetToolTip(Button3, "Продлить график на указанное колличество дней.");
			Button3.UseVisualStyleBackColor = true;
			Label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label16.AutoSize = true;
			Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label16.Location = new System.Drawing.Point(147, 380);
			Label16.Name = "Label16";
			Label16.Size = new System.Drawing.Size(116, 16);
			Label16.TabIndex = 24;
			Label16.Text = "Добавить дней: -";
			ToolTip1.SetToolTip(Label16, "Здесь указано колличество дней, которое будет добавлено к вашему графику после нажатия на кнопку \"Добавить\".");
			Label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label17.AutoSize = true;
			Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label17.Location = new System.Drawing.Point(103, 360);
			Label17.Name = "Label17";
			Label17.Size = new System.Drawing.Size(237, 16);
			Label17.TabIndex = 25;
			Label17.Text = "Необходимость добавления дней: -";
			ToolTip1.SetToolTip(Label17, "Здесь указана необходимость добавления дней в отношении к 4 (2/4 = 50%).");
			Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label12.AutoSize = true;
			Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label12.Location = new System.Drawing.Point(251, 342);
			Label12.Name = "Label12";
			Label12.Size = new System.Drawing.Size(12, 16);
			Label12.TabIndex = 27;
			Label12.Text = "-";
			ToolTip1.SetToolTip(Label12, "Здесь указано ваше состояние относительно предыдущих данных состояния.");
			Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label2.AutoSize = true;
			Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label2.Location = new System.Drawing.Point(286, 238);
			Label2.Name = "Label2";
			Label2.Size = new System.Drawing.Size(113, 32);
			Label2.TabIndex = 7;
			Label2.Text = "Статистических\r\nданных:";
			Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label3.AutoSize = true;
			Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label3.Location = new System.Drawing.Point(340, 254);
			Label3.Name = "Label3";
			Label3.Size = new System.Drawing.Size(12, 16);
			Label3.TabIndex = 8;
			Label3.Text = "-";
			Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label4.AutoSize = true;
			Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label4.Location = new System.Drawing.Point(12, 292);
			Label4.Name = "Label4";
			Label4.Size = new System.Drawing.Size(76, 32);
			Label4.TabIndex = 10;
			Label4.Text = "Страницы \r\nграфика:";
			Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label6.AutoSize = true;
			Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label6.Location = new System.Drawing.Point(94, 292);
			Label6.Name = "Label6";
			Label6.Size = new System.Drawing.Size(81, 16);
			Label6.TabIndex = 12;
			Label6.Text = "Состояние:";
			Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label7.AutoSize = true;
			Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label7.Location = new System.Drawing.Point(115, 308);
			Label7.Name = "Label7";
			Label7.Size = new System.Drawing.Size(125, 16);
			Label7.TabIndex = 13;
			Label7.Text = "Общее состояние:";
			Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label13.AutoSize = true;
			Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label13.Location = new System.Drawing.Point(103, 324);
			Label13.Name = "Label13";
			Label13.Size = new System.Drawing.Size(137, 16);
			Label13.TabIndex = 19;
			Label13.Text = "Улучшения отн. 1 ч.:";
			Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Label11.AutoSize = true;
			Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label11.Location = new System.Drawing.Point(103, 340);
			Label11.Name = "Label11";
			Label11.Size = new System.Drawing.Size(151, 16);
			Label11.TabIndex = 26;
			Label11.Text = "Улучшения отн. пред.:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(426, 404);
			base.Controls.Add(Button3);
			base.Controls.Add(Label12);
			base.Controls.Add(Label11);
			base.Controls.Add(Label10);
			base.Controls.Add(Label17);
			base.Controls.Add(Label16);
			base.Controls.Add(Label8);
			base.Controls.Add(Label13);
			base.Controls.Add(Label9);
			base.Controls.Add(Label7);
			base.Controls.Add(Label6);
			base.Controls.Add(Label5);
			base.Controls.Add(ListBox1);
			base.Controls.Add(Label4);
			base.Controls.Add(Label3);
			base.Controls.Add(Label2);
			base.Controls.Add(ComboBox1);
			base.Controls.Add(Label1);
			base.Controls.Add(Button2);
			base.Controls.Add(Button1);
			base.Controls.Add(PictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Results";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Просмотр графика";
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void Renovate_grafic(short mode, short position)
		{
			Pen pen = new Pen(Brushes.Black);
			Font font = new Font("Arial", 5f);
			Bitmap image = new Bitmap(200, 110);
			Graphics graphics = Graphics.FromImage(image);
			pen.Width = 1f;
			checked
			{
				switch (mode)
				{
				case 0:
					if (states_dat.Length > 200)
					{
						short num2 = 1;
						int num6 = (int)Math.Round(Conversion.Int((double)states_dat.Length / 200.0) + 1.0);
						short[] array3 = new short[1];
						Array.Resize(ref array3, 0);
						int num7 = states_dat.Length - 1;
						int num8 = num6;
						for (int k = 0; ((num8 >> 31) ^ k) <= ((num8 >> 31) ^ num7) && k < states_dat.Length; k += num8)
						{
							int num9 = 0;
							int num10 = 0;
							int num11 = num6 - 1;
							for (int l = 0; l <= num11 && k + l != states_dat.Length; l++)
							{
								num9 += states_dat[k + l];
								num10++;
							}
							Array.Resize(ref array3, array3.Length + 1);
							array3[array3.Length - 1] = (short)Math.Round(Math.Round((double)num9 / (double)num10));
							num9 = 0;
							num10 = 0;
						}
						graphics.Clear(Color.WhiteSmoke);
						graphics.DrawLine(Pens.LimeGreen, 0, 6, 200, 6);
						graphics.DrawString("Хорошо!", font, Brushes.LimeGreen, 0f, 6f);
						graphics.DrawLine(Pens.Green, 0, 26, 200, 26);
						graphics.DrawString("Нормально.", font, Brushes.Green, 0f, 26f);
						graphics.DrawLine(Pens.Goldenrod, 0, 46, 200, 46);
						graphics.DrawString("Не очень хорошо.", font, Brushes.Goldenrod, 0f, 46f);
						graphics.DrawLine(Pens.DarkGoldenrod, 0, 66, 200, 66);
						graphics.DrawString("Плохо.", font, Brushes.DarkGoldenrod, 0f, 66f);
						graphics.DrawLine(Pens.Red, 0, 86, 200, 86);
						graphics.DrawString("Очень плохо.", font, Brushes.Red, 0f, 86f);
						graphics.DrawLine(Pens.DarkRed, 0, 106, 200, 106);
						graphics.DrawString("Ужас!", font, Brushes.DarkRed, 0f, 100f);
						graphics.DrawRectangle(Pens.Gray, 0, 0, 199, 109);
						int num12 = array3.Length - 1;
						for (int m = 1; m <= num12; m++)
						{
							graphics.DrawLine(pen, (m - 1) * num2, 105 - array3[m - 1] * 20, (m - 1) * num2 + num2, 105 - array3[m] * 20);
						}
						PictureBox1.Image = image;
					}
					else if (states_dat.Length > 0)
					{
						short num2 = (short)Math.Round(Math.Round(200.0 / (double)states_dat.Length));
						graphics.Clear(Color.WhiteSmoke);
						graphics.DrawLine(Pens.LimeGreen, 0, 6, 200, 6);
						graphics.DrawString("Хорошо!", font, Brushes.LimeGreen, 0f, 6f);
						graphics.DrawLine(Pens.Green, 0, 26, 200, 26);
						graphics.DrawString("Нормально.", font, Brushes.Green, 0f, 26f);
						graphics.DrawLine(Pens.Goldenrod, 0, 46, 200, 46);
						graphics.DrawString("Не очень хорошо.", font, Brushes.Goldenrod, 0f, 46f);
						graphics.DrawLine(Pens.DarkGoldenrod, 0, 66, 200, 66);
						graphics.DrawString("Плохо.", font, Brushes.DarkGoldenrod, 0f, 66f);
						graphics.DrawLine(Pens.Red, 0, 86, 200, 86);
						graphics.DrawString("Очень плохо.", font, Brushes.Red, 0f, 86f);
						graphics.DrawLine(Pens.DarkRed, 0, 106, 200, 106);
						graphics.DrawString("Ужас!", font, Brushes.DarkRed, 0f, 100f);
						graphics.DrawRectangle(Pens.Gray, 0, 0, 199, 109);
						int num13 = states_dat.Length - 1;
						for (int n = 1; n <= num13; n++)
						{
							graphics.DrawLine(pen, (n - 1) * num2, 105 - states_dat[n - 1] * 20, (n - 1) * num2 + num2, 105 - states_dat[n] * 20);
						}
						PictureBox1.Image = image;
					}
					break;
				case 1:
				{
					short[] array2 = new short[1];
					int num4 = 0;
					while (num4 + position != states_dat.Length)
					{
						Array.Resize(ref array2, num4 + 1);
						array2[num4] = states_dat[num4 + position];
						num4++;
						if (num4 > 199)
						{
							break;
						}
					}
					Interaction.MsgBox("");
					short num2 = 1;
					graphics.Clear(Color.WhiteSmoke);
					graphics.DrawLine(Pens.LimeGreen, 0, 6, 200, 6);
					graphics.DrawString("Хорошо!", font, Brushes.LimeGreen, 0f, 6f);
					graphics.DrawLine(Pens.Green, 0, 26, 200, 26);
					graphics.DrawString("Нормально.", font, Brushes.Green, 0f, 26f);
					graphics.DrawLine(Pens.Goldenrod, 0, 46, 200, 46);
					graphics.DrawString("Не очень хорошо.", font, Brushes.Goldenrod, 0f, 46f);
					graphics.DrawLine(Pens.DarkGoldenrod, 0, 66, 200, 66);
					graphics.DrawString("Плохо.", font, Brushes.DarkGoldenrod, 0f, 66f);
					graphics.DrawLine(Pens.Red, 0, 86, 200, 86);
					graphics.DrawString("Очень плохо.", font, Brushes.Red, 0f, 86f);
					graphics.DrawLine(Pens.DarkRed, 0, 106, 200, 106);
					graphics.DrawString("Ужас!", font, Brushes.DarkRed, 0f, 100f);
					graphics.DrawRectangle(Pens.Gray, 0, 0, 199, 109);
					int num5 = array2.Length - 1;
					for (int j = 1; j <= num5; j++)
					{
						graphics.DrawLine(pen, (j - 1) * num2, 105 - array2[j - 1] * 20, (j - 1) * num2 + num2, 105 - array2[j] * 20);
					}
					PictureBox1.Image = image;
					break;
				}
				case 2:
				{
					short[] array = new short[1];
					int num = 0;
					while (num + position != states_dat.Length)
					{
						Array.Resize(ref array, num + 1);
						array[num] = states_dat[num + position];
						num++;
						if (num > 9)
						{
							break;
						}
					}
					short num2 = 20;
					graphics.Clear(Color.WhiteSmoke);
					graphics.DrawLine(Pens.LimeGreen, 0, 6, 200, 6);
					graphics.DrawString("Хорошо!", font, Brushes.LimeGreen, 0f, 6f);
					graphics.DrawLine(Pens.Green, 0, 26, 200, 26);
					graphics.DrawString("Нормально.", font, Brushes.Green, 0f, 26f);
					graphics.DrawLine(Pens.Goldenrod, 0, 46, 200, 46);
					graphics.DrawString("Не очень хорошо.", font, Brushes.Goldenrod, 0f, 46f);
					graphics.DrawLine(Pens.DarkGoldenrod, 0, 66, 200, 66);
					graphics.DrawString("Плохо.", font, Brushes.DarkGoldenrod, 0f, 66f);
					graphics.DrawLine(Pens.Red, 0, 86, 200, 86);
					graphics.DrawString("Очень плохо.", font, Brushes.Red, 0f, 86f);
					graphics.DrawLine(Pens.DarkRed, 0, 106, 200, 106);
					graphics.DrawString("Ужас!", font, Brushes.DarkRed, 0f, 100f);
					graphics.DrawRectangle(Pens.Gray, 0, 0, 199, 109);
					int num3 = array.Length - 1;
					for (int i = 1; i <= num3; i++)
					{
						graphics.DrawLine(pen, (i - 1) * num2, 105 - array[i - 1] * 20, (i - 1) * num2 + num2, 105 - array[i] * 20);
					}
					PictureBox1.Image = image;
					break;
				}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Results_Shown(object sender, EventArgs e)
		{
			FileSystem.FileClose(2);
			string[] array = File.ReadAllLines(Application.StartupPath + "/MyComplex.dat");
			FileSystem.FileOpen(2, Application.StartupPath + "/MyComplex.dat", OpenMode.Binary);
			Array.Resize(ref states_dat, 0);
			string[] array2 = array;
			checked
			{
				foreach (string text in array2)
				{
					if (text.IndexOf("Состояние: Хорошо! Со всем справляюсь!") > -1)
					{
						Array.Resize(ref states_dat, states_dat.Length + 1);
						states_dat[states_dat.Length - 1] = 5;
					}
					else if (text.IndexOf("Состояние: Нормально. Тяжело, но справляюсь.") > -1)
					{
						Array.Resize(ref states_dat, states_dat.Length + 1);
						states_dat[states_dat.Length - 1] = 4;
					}
					else if (text.IndexOf("Состояние: Не очень хорошо. Справляюсь, но не со всем.") > -1)
					{
						Array.Resize(ref states_dat, states_dat.Length + 1);
						states_dat[states_dat.Length - 1] = 3;
					}
					else if (text.IndexOf("Состояние: Плохо. Еле-еле что-то делаю.") > -1)
					{
						Array.Resize(ref states_dat, states_dat.Length + 1);
						states_dat[states_dat.Length - 1] = 2;
					}
					else if (text.IndexOf("Состояние: Очень плохо. Не могу ничего поделать.") > -1)
					{
						Array.Resize(ref states_dat, states_dat.Length + 1);
						states_dat[states_dat.Length - 1] = 1;
					}
					else if (text.IndexOf("Состояние: Ужас! Без сигарет - жить не могу!") > -1)
					{
						Array.Resize(ref states_dat, states_dat.Length + 1);
						states_dat[states_dat.Length - 1] = 0;
					}
				}
				Label3.Text = Conversions.ToString(states_dat.Length);
				Label5.Text = "Позиция: " + Conversions.ToString(1);
				ComboBox1.SelectedIndex = 0;
				ListBox1.Items.Clear();
				Renovate_grafic(0, 0);
				short num = 0;
				short[] array3 = new short[3];
				if (states_dat.Length > 0)
				{
					int num2 = states_dat.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						num = (short)unchecked(num + states_dat[j]);
					}
					switch ((short)Math.Round(Math.Round((double)num / (double)states_dat.Length)))
					{
					case 5:
						Label9.Text = "Хорошо!";
						Label8.BackColor = Color.LimeGreen;
						array3[0] = 5;
						break;
					case 4:
						Label9.Text = "Нормально.";
						Label8.BackColor = Color.Green;
						states_dat[states_dat.Length - 1] = 4;
						array3[0] = 4;
						break;
					case 3:
						Label9.Text = "Не очень хорошо.";
						Label8.BackColor = Color.Goldenrod;
						array3[0] = 3;
						break;
					case 2:
						Label9.Text = "Плохо.";
						Label8.BackColor = Color.DarkGoldenrod;
						array3[0] = 2;
						break;
					case 1:
						Label9.Text = "Очень плохо.";
						Label8.BackColor = Color.Red;
						array3[0] = 1;
						break;
					case 0:
						Label9.Text = "Ужас!";
						Label8.BackColor = Color.DarkRed;
						array3[0] = 0;
						break;
					}
				}
				num = 0;
				array3[1] = 5;
				if (states_dat.Length > 1)
				{
					short[] array4 = new short[2];
					int num3 = (int)Math.Round(Conversion.Int((double)states_dat.Length / 2.0) - 1.0);
					for (int k = 0; k <= num3; k++)
					{
						num = (short)unchecked(num + states_dat[k]);
					}
					array4[0] = (short)Math.Round(Math.Round((double)num / Conversion.Int((double)states_dat.Length / 2.0)));
					num = 0;
					int num4 = (int)Math.Round(Conversion.Int((double)states_dat.Length / 2.0));
					int num5 = states_dat.Length - 1;
					for (int l = num4; l <= num5; l++)
					{
						num = (short)unchecked(num + states_dat[l]);
					}
					array4[1] = (short)Math.Round(Math.Round((double)num / ((double)states_dat.Length - Conversion.Int((double)states_dat.Length / 2.0))));
					if (array4[0] < array4[1])
					{
						Label10.Text = "Улучшение";
						array3[1] = 5;
					}
					else if (array4[0] > array4[1])
					{
						Label10.Text = "Ухудшение";
						array3[1] = array4[1];
					}
					else
					{
						Label10.Text = "Стабильность";
						array3[1] = array4[1];
					}
				}
				array3[2] = 5;
				if (states_dat.Length > 1)
				{
					if (states_dat[states_dat.Length - 2] < states_dat[states_dat.Length - 1])
					{
						Label12.Text = "Улучшение";
						array3[2] = 5;
					}
					else if (states_dat[states_dat.Length - 2] > states_dat[states_dat.Length - 1])
					{
						Label12.Text = "Ухудшение";
						array3[2] = states_dat[states_dat.Length - 1];
					}
					else
					{
						Label12.Text = "Стабильность";
						array3[2] = states_dat[states_dat.Length - 1];
					}
				}
				if (states_dat.Length > 0)
				{
					num = 0;
					num = (short)unchecked(num + array3[0]);
					num = (short)unchecked(num + array3[1]);
					num = (short)unchecked(num + array3[2]);
					num = (short)Math.Round(Math.Round((double)num / 3.0));
					switch (num)
					{
					case 5:
						Label17.Text = "Необходимость добавления дней: 0 / 4";
						break;
					case 4:
						Label17.Text = "Необходимость добавления дней: 0 / 4";
						break;
					case 3:
						Label17.Text = "Необходимость добавления дней: 0.5 / 4";
						break;
					case 2:
						Label17.Text = "Необходимость добавления дней: 1 / 4";
						break;
					case 1:
						Label17.Text = "Необходимость добавления дней: 1.5 / 4";
						break;
					case 0:
						Label17.Text = "Необходимость добавления дней: 2 / 4";
						break;
					}
					switch (num)
					{
					case 5:
						Label16.Text = "Добавить дней: 0";
						add_days = 0;
						break;
					case 4:
						Label16.Text = "Добавить дней: 0";
						add_days = 0;
						break;
					case 3:
						Label16.Text = "Добавить дней: 0";
						add_days = 0;
						break;
					case 2:
						Label16.Text = "Добавить дней: 1";
						add_days = 1;
						Button3.Enabled = true;
						break;
					case 1:
						Label16.Text = "Добавить дней: 1";
						add_days = 1;
						Button3.Enabled = true;
						break;
					case 0:
						Label16.Text = "Добавить дней: 2";
						add_days = 2;
						Button3.Enabled = true;
						break;
					}
				}
			}
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			checked
			{
				if ((ComboBox1.SelectedIndex == 1) & (states_dat.Length >= 200))
				{
					ListBox1.Items.Clear();
					if (states_dat.Length > 200)
					{
						if (states_dat.Length > 200)
						{
							int num = (int)Math.Round(Conversion.Int((double)states_dat.Length / 200.0));
							for (int i = 0; i <= num; i++)
							{
								ListBox1.Items.Add(i + 1);
							}
						}
						else
						{
							ListBox1.Items.Add(1);
						}
						ListBox1.SelectedIndex = 0;
						Label5.Text = "Позиция: " + Conversions.ToString(1) + "/" + Conversions.ToString(ListBox1.Items.Count);
						ListBox1.Enabled = true;
					}
					Renovate_grafic(1, 0);
				}
				else if ((ComboBox1.SelectedIndex == 2) & (states_dat.Length >= 10))
				{
					ListBox1.Items.Clear();
					if (states_dat.Length > 10)
					{
						if (states_dat.Length > 10)
						{
							int num2 = (int)Math.Round(Conversion.Int((double)states_dat.Length / 10.0));
							for (int j = 0; j <= num2; j++)
							{
								ListBox1.Items.Add(j + 1);
							}
						}
						else
						{
							ListBox1.Items.Add(1);
						}
						ListBox1.SelectedIndex = 0;
						Label5.Text = "Позиция: " + Conversions.ToString(1) + "/" + Conversions.ToString(ListBox1.Items.Count);
						ListBox1.Enabled = true;
					}
					Renovate_grafic(2, 0);
				}
				else if (ComboBox1.SelectedIndex == 0)
				{
					ListBox1.Items.Clear();
					ListBox1.Enabled = false;
					Label5.Text = "Позиция: " + Conversions.ToString(1);
					Renovate_grafic(0, 0);
				}
				else
				{
					Interaction.MsgBox("Вы не можете выбрать этот режим маштабирования!", MsgBoxStyle.OkOnly, "Сообщение");
					ComboBox1.SelectedIndex = 0;
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				if ((base.Width < MyProject.Computer.Screen.Bounds.Width - 100) & (base.Height < MyProject.Computer.Screen.Bounds.Height - 100))
				{
					if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
					{
						MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
					}
					base.Width += 200;
					base.Height += 110;
				}
			}
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				if ((base.Width > 432) & (base.Height > 432))
				{
					if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
					{
						MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
					}
					base.Width -= 200;
					base.Height -= 110;
				}
			}
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			checked
			{
				if (ComboBox1.SelectedIndex == 1)
				{
					Label5.Text = "Позиция: " + Conversions.ToString(ListBox1.SelectedIndex + 1) + "/" + Conversions.ToString(ListBox1.Items.Count);
					Renovate_grafic(1, (short)(ListBox1.SelectedIndex * 200));
				}
				else if (ComboBox1.SelectedIndex == 2)
				{
					Label5.Text = "Позиция: " + Conversions.ToString(ListBox1.SelectedIndex + 1) + "/" + Conversions.ToString(ListBox1.Items.Count);
					Renovate_grafic(2, (short)(ListBox1.SelectedIndex * 10));
				}
			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			if (Interaction.MsgBox("Вы уверены, что хотите добавить " + Conversions.ToString((int)add_days) + " дней к вашему графику?\nПосле нажатия кнопки 'Да', к вашему графику будет добавлено " + Conversions.ToString((int)add_days) + " дней.", MsgBoxStyle.YesNo, "Сообщение") == MsgBoxResult.Yes)
			{
				MyProject.Forms.start.data[2] = Conversions.ToString(DateAndTime.DateValue(MyProject.Forms.start.data[2]).AddDays(add_days));
				MyProject.Forms.start.Register(": Добавлено дней к графику: " + Conversions.ToString((int)add_days) + ".; ");
				Interaction.MsgBox("К вашему графику было успешно добавлено " + Conversions.ToString((int)add_days) + " дней.", MsgBoxStyle.OkOnly, "Сообщение");
			}
		}
	}
}
