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
	public class PM : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("LogoPictureBox")]
		private PictureBox _LogoPictureBox;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

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
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		private string old_text;

		[field: AccessedThroughProperty("LogoPictureBox")]
		internal virtual PictureBox LogoPictureBox { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

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

		public PM()
		{
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.PM));
			LogoPictureBox = new System.Windows.Forms.PictureBox();
			TextBox1 = new System.Windows.Forms.TextBox();
			Label1 = new System.Windows.Forms.Label();
			Button1 = new System.Windows.Forms.Button();
			Button2 = new System.Windows.Forms.Button();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
			SuspendLayout();
			LogoPictureBox.Image = (System.Drawing.Image)resources.GetObject("LogoPictureBox.Image");
			LogoPictureBox.Location = new System.Drawing.Point(12, 51);
			LogoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			LogoPictureBox.Name = "LogoPictureBox";
			LogoPictureBox.Size = new System.Drawing.Size(73, 74);
			LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			LogoPictureBox.TabIndex = 1;
			LogoPictureBox.TabStop = false;
			TextBox1.Location = new System.Drawing.Point(12, 25);
			TextBox1.MaxLength = 10;
			TextBox1.Name = "TextBox1";
			TextBox1.Size = new System.Drawing.Size(248, 20);
			TextBox1.TabIndex = 2;
			Label1.AutoSize = true;
			Label1.Location = new System.Drawing.Point(12, 9);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(255, 13);
			Label1.TabIndex = 3;
			Label1.Text = "Введите PIN-код (только цифры):";
			ToolTip1.SetToolTip(Label1, "PIN-код изначально: 0000");
			Button1.Location = new System.Drawing.Point(185, 51);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(75, 20);
			Button1.TabIndex = 4;
			Button1.Text = "ОК";
			Button1.UseVisualStyleBackColor = true;
			Button2.Location = new System.Drawing.Point(104, 51);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(75, 20);
			Button2.TabIndex = 5;
			Button2.Text = "Отмена";
			Button2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ControlLight;
			base.ClientSize = new System.Drawing.Size(272, 138);
			base.Controls.Add(Button2);
			base.Controls.Add(Button1);
			base.Controls.Add(Label1);
			base.Controls.Add(TextBox1);
			base.Controls.Add(LogoPictureBox);
			Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PM";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Переключение на режим модератора";
			((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (TextBox1.Text.ToLower().IndexOf("e") > -1)
				{
					Close();
				}
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

		private void Button2_Click(object sender, EventArgs e)
		{
			old_text = "";
			TextBox1.Text = "";
			base.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(TextBox1.Text, MyProject.Forms.start.inf[0], TextCompare: false) == 0)
			{
				if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
				{
					MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
				}
				old_text = "";
				TextBox1.Text = "";
				base.DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}
