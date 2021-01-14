using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Anti_Kurenie.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Anti_Kurenie
{
	[DesignerGenerated]
	public class phon : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		public bool cansel;

		[field: AccessedThroughProperty("PictureBox1")]
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		public phon()
		{
			base.Load += phon_Load;
			base.Shown += phon_Shown;
			cansel = false;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.phon));
			PictureBox1 = new System.Windows.Forms.PictureBox();
			Timer1 = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
			SuspendLayout();
			PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			PictureBox1.Location = new System.Drawing.Point(4, 4);
			PictureBox1.Name = "PictureBox1";
			PictureBox1.Size = new System.Drawing.Size(575, 575);
			PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			PictureBox1.TabIndex = 0;
			PictureBox1.TabStop = false;
			Timer1.Enabled = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.GrayText;
			base.ClientSize = new System.Drawing.Size(578, 578);
			base.ControlBox = false;
			base.Controls.Add(PictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "phon";
			base.ShowIcon = false;
			((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
			ResumeLayout(false);
		}

		private void phon_Load(object sender, EventArgs e)
		{
			checked
			{
				base.Left = MyProject.Computer.Screen.Bounds.Left - 1;
				base.Top = MyProject.Computer.Screen.Bounds.Top - 1;
				base.Width = MyProject.Computer.Screen.Bounds.Width + 2;
				base.Height = MyProject.Computer.Screen.Bounds.Height + 2;
			}
		}

		private void phon_Shown(object sender, EventArgs e)
		{
			if (Operators.CompareString(MyProject.Forms.start.data[1], "", TextCompare: false) == 0)
			{
				MyProject.Forms.data.ShowDialog();
			}
			else
			{
				MyProject.Forms.no_smoking.ShowDialog();
			}
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (cansel)
			{
				Close();
			}
		}
	}
}
