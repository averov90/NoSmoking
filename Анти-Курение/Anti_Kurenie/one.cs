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
	public class one : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

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
		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		[CompilerGenerated]
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[CompilerGenerated]
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[field: AccessedThroughProperty("PictureBox1")]
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("TextBox1")]
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		public one()
		{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.one));
			PictureBox1 = new System.Windows.Forms.PictureBox();
			TextBox1 = new System.Windows.Forms.TextBox();
			ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
			КопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			КопироватьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			Button2 = new System.Windows.Forms.Button();
			Button3 = new System.Windows.Forms.Button();
			Button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			ContextMenuStrip1.SuspendLayout();
			TableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			PictureBox1.Location = new System.Drawing.Point(12, 12);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new System.Drawing.Size(463, 575);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			TextBox1.BackColor = System.Drawing.SystemColors.Window;
			TextBox1.ContextMenuStrip = ContextMenuStrip1;
			TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			TextBox1.Location = new System.Drawing.Point(12, 12);
			TextBox1.Multiline = true;
			TextBox1.Name = "TextBox1";
			TextBox1.ReadOnly = true;
			TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			TextBox1.Size = new System.Drawing.Size(463, 575);
			TextBox1.TabIndex = 2;
			TextBox1.Text = resources.GetString("TextBox1.Text");
			TextBox1.Visible = false;
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
			TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			TableLayoutPanel1.ColumnCount = 2;
			TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69f));
			TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31f));
			TableLayoutPanel1.Controls.Add(Button2, 0, 0);
			TableLayoutPanel1.Controls.Add(Button3, 1, 0);
			TableLayoutPanel1.Location = new System.Drawing.Point(12, 581);
			TableLayoutPanel1.Name = "TableLayoutPanel1";
			TableLayoutPanel1.RowCount = 1;
			TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			TableLayoutPanel1.Size = new System.Drawing.Size(463, 32);
			TableLayoutPanel1.TabIndex = 7;
			Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button2.Location = new System.Drawing.Point(3, 6);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(313, 23);
			Button2.TabIndex = 3;
			Button2.Text = "Почему 1 год?";
			Button2.UseVisualStyleBackColor = true;
			Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button3.Location = new System.Drawing.Point(322, 6);
			Button3.Name = "Button3";
			Button3.Size = new System.Drawing.Size(138, 23);
			Button3.TabIndex = 4;
			Button3.Text = "Просмотр фильма";
			Button3.UseVisualStyleBackColor = true;
			Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button1.Location = new System.Drawing.Point(12, 587);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(463, 23);
			Button1.TabIndex = 6;
			Button1.Text = "Почему нужно бросать курить?";
			Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.AppWorkspace;
			base.ClientSize = new System.Drawing.Size(487, 617);
			base.Controls.Add(Button1);
			base.Controls.Add(TextBox1);
			base.Controls.Add(PictureBox1);
			base.Controls.Add(TableLayoutPanel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(492, 225);
			base.Name = "one";
			Text = "Почему 1 год? ";
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ContextMenuStrip1.ResumeLayout(false);
			TableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			if (Operators.CompareString(MyProject.Forms.start.inf[4], "close", TextCompare: false) == 0)
			{
				Button3.Enabled = false;
			}
			TextBox1.Visible = true;
			Button1.Visible = false;
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

		private void Button2_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			TextBox1.Visible = false;
			Button1.Visible = true;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "/Вред курения.mp4"))
			{
				Process.Start(Application.StartupPath + "/Вред курения.mp4");
			}
			else
			{
				Interaction.MsgBox("Фильм не найден!", MsgBoxStyle.OkOnly, "Ошибка");
			}
		}
	}
}
