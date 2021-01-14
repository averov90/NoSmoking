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
	public class Yes : Form
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
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[CompilerGenerated]
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

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

		[field: AccessedThroughProperty("PictureBox1")]
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("ToolTip1")]
		internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		public Yes()
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.Yes));
			Label1 = new System.Windows.Forms.Label();
			Button1 = new System.Windows.Forms.Button();
			Button2 = new System.Windows.Forms.Button();
			PictureBox1 = new System.Windows.Forms.PictureBox();
			ToolTip1 = new System.Windows.Forms.ToolTip(components);
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			Label1.Font = new System.Drawing.Font("Lucida Console", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Label1.Location = new System.Drawing.Point(57, 9);
			Label1.Name = "Label1";
			Label1.Size = new System.Drawing.Size(278, 39);
			Label1.TabIndex = 0;
			Label1.Text = "Я знаю, что ты куришь, и я хочу тебе помочь!";
			Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			Button1.Location = new System.Drawing.Point(13, 53);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(273, 29);
			Button1.TabIndex = 1;
			Button1.Text = "Да, я не откажусь от помощи!";
			ToolTip1.SetToolTip(Button1, "Согласиться");
			Button1.UseVisualStyleBackColor = true;
			Button2.Location = new System.Drawing.Point(292, 53);
			Button2.Name = "Button2";
			Button2.Size = new System.Drawing.Size(43, 29);
			Button2.TabIndex = 2;
			Button2.Text = "Нет...";
			ToolTip1.SetToolTip(Button2, "Отказаться от помощи");
			Button2.UseVisualStyleBackColor = true;
			PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			PictureBox1.Location = new System.Drawing.Point(12, 11);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new System.Drawing.Size(39, 36);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 3;
			PictureBox1.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Menu;
			base.ClientSize = new System.Drawing.Size(347, 94);
			base.Controls.Add(PictureBox1);
			base.Controls.Add(Button2);
			base.Controls.Add(Button1);
			base.Controls.Add(Label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Yes";
			Text = "Анти-Курение";
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.start.data[0] = "Yes";
			MyProject.Forms.start.write();
			MyProject.Forms.start.Register(": Согласие получено.; ");
			Close();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("Мы уверены, что вам нужна наша помощь!", MsgBoxStyle.OkOnly, "Сообщение");
		}
	}
}
