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
	public sealed class AbountProgramm : Form
	{
		[CompilerGenerated]
		[AccessedThroughProperty("TableLayoutPanel")]
		private TableLayoutPanel _TableLayoutPanel;

		[CompilerGenerated]
		[AccessedThroughProperty("LogoPictureBox")]
		private PictureBox _LogoPictureBox;

		[CompilerGenerated]
		[AccessedThroughProperty("LabelProductName")]
		private Label _LabelProductName;

		[CompilerGenerated]
		[AccessedThroughProperty("LabelVersion")]
		private Label _LabelVersion;

		[CompilerGenerated]
		[AccessedThroughProperty("LabelCompanyName")]
		private Label _LabelCompanyName;

		[CompilerGenerated]
		[AccessedThroughProperty("TextBoxDescription")]
		private TextBox _TextBoxDescription;

		[CompilerGenerated]
		[AccessedThroughProperty("OKButton")]
		private Button _OKButton;

		[CompilerGenerated]
		[AccessedThroughProperty("LabelCopyright")]
		private Label _LabelCopyright;

		private IContainer components;

		[CompilerGenerated]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[field: AccessedThroughProperty("TableLayoutPanel")]
		internal virtual TableLayoutPanel TableLayoutPanel { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("LogoPictureBox")]
		internal virtual PictureBox LogoPictureBox { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("LabelProductName")]
		internal virtual Label LabelProductName { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("LabelVersion")]
		internal virtual Label LabelVersion { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("LabelCompanyName")]
		internal virtual Label LabelCompanyName { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		[field: AccessedThroughProperty("TextBoxDescription")]
		internal virtual TextBox TextBoxDescription { get; [MethodImpl(MethodImplOptions.Synchronized)]
		set; }

		internal virtual Button OKButton
		{
			[CompilerGenerated]
			get
			{
				return _OKButton;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = OKButton_Click;
				Button oKButton = _OKButton;
				if (oKButton != null)
				{
					oKButton.Click -= value2;
				}
				_OKButton = value;
				oKButton = _OKButton;
				if (oKButton != null)
				{
					oKButton.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("LabelCopyright")]
		internal virtual Label LabelCopyright { get; [MethodImpl(MethodImplOptions.Synchronized)]
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

		public AbountProgramm()
		{
			base.Shown += AbountProgramm_Shown;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anti_Kurenie.AbountProgramm));
			TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			LogoPictureBox = new System.Windows.Forms.PictureBox();
			LabelProductName = new System.Windows.Forms.Label();
			LabelVersion = new System.Windows.Forms.Label();
			LabelCopyright = new System.Windows.Forms.Label();
			LabelCompanyName = new System.Windows.Forms.Label();
			TextBoxDescription = new System.Windows.Forms.TextBox();
			OKButton = new System.Windows.Forms.Button();
			Button1 = new System.Windows.Forms.Button();
			TableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
			SuspendLayout();
			TableLayoutPanel.ColumnCount = 3;
			TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33f));
			TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20f));
			TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47f));
			TableLayoutPanel.Controls.Add(LogoPictureBox, 0, 0);
			TableLayoutPanel.Controls.Add(LabelProductName, 1, 0);
			TableLayoutPanel.Controls.Add(LabelVersion, 1, 1);
			TableLayoutPanel.Controls.Add(LabelCopyright, 1, 2);
			TableLayoutPanel.Controls.Add(LabelCompanyName, 1, 3);
			TableLayoutPanel.Controls.Add(TextBoxDescription, 1, 4);
			TableLayoutPanel.Controls.Add(OKButton, 2, 5);
			TableLayoutPanel.Controls.Add(Button1, 1, 5);
			TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			TableLayoutPanel.Location = new System.Drawing.Point(9, 9);
			TableLayoutPanel.Name = "TableLayoutPanel";
			TableLayoutPanel.RowCount = 6;
			TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
			TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45f));
			TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15f));
			TableLayoutPanel.Size = new System.Drawing.Size(406, 181);
			TableLayoutPanel.TabIndex = 0;
			LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			LogoPictureBox.Image = (System.Drawing.Image)resources.GetObject("LogoPictureBox.Image");
			LogoPictureBox.Location = new System.Drawing.Point(3, 3);
			LogoPictureBox.Name = "LogoPictureBox";
			TableLayoutPanel.SetRowSpan(LogoPictureBox, 6);
			LogoPictureBox.Size = new System.Drawing.Size(127, 175);
			LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			LogoPictureBox.TabIndex = 0;
			LogoPictureBox.TabStop = false;
			TableLayoutPanel.SetColumnSpan(LabelProductName, 2);
			LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			LabelProductName.Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			LabelProductName.Location = new System.Drawing.Point(139, 0);
			LabelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			LabelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			LabelProductName.Name = "LabelProductName";
			LabelProductName.Size = new System.Drawing.Size(264, 17);
			LabelProductName.TabIndex = 0;
			LabelProductName.Text = "Имя продукта: Анти-Курение";
			LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			TableLayoutPanel.SetColumnSpan(LabelVersion, 2);
			LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			LabelVersion.Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			LabelVersion.Location = new System.Drawing.Point(139, 18);
			LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			LabelVersion.MaximumSize = new System.Drawing.Size(0, 17);
			LabelVersion.Name = "LabelVersion";
			LabelVersion.Size = new System.Drawing.Size(264, 17);
			LabelVersion.TabIndex = 0;
			LabelVersion.Text = "Версия: ---- EASY";
			LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			TableLayoutPanel.SetColumnSpan(LabelCopyright, 2);
			LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			LabelCopyright.Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			LabelCopyright.Location = new System.Drawing.Point(139, 36);
			LabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			LabelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			LabelCopyright.Name = "LabelCopyright";
			LabelCopyright.Size = new System.Drawing.Size(264, 17);
			LabelCopyright.TabIndex = 0;
			LabelCopyright.Text = "Авторские права: averov90 © 2011";
			LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			TableLayoutPanel.SetColumnSpan(LabelCompanyName, 2);
			LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			LabelCompanyName.Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			LabelCompanyName.Location = new System.Drawing.Point(139, 54);
			LabelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			LabelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
			LabelCompanyName.Name = "LabelCompanyName";
			LabelCompanyName.Size = new System.Drawing.Size(264, 17);
			LabelCompanyName.TabIndex = 0;
			LabelCompanyName.Text = "Компания: инди-dev";
			LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			TableLayoutPanel.SetColumnSpan(TextBoxDescription, 2);
			TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			TextBoxDescription.Font = new System.Drawing.Font("Lucida Console", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			TextBoxDescription.Location = new System.Drawing.Point(139, 75);
			TextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			TextBoxDescription.Multiline = true;
			TextBoxDescription.Name = "TextBoxDescription";
			TextBoxDescription.ReadOnly = true;
			TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			TextBoxDescription.Size = new System.Drawing.Size(264, 75);
			TextBoxDescription.TabIndex = 0;
			TextBoxDescription.TabStop = false;
			TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text");
			OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			OKButton.Location = new System.Drawing.Point(328, 156);
			OKButton.Name = "OKButton";
			OKButton.Size = new System.Drawing.Size(75, 22);
			OKButton.TabIndex = 0;
			OKButton.Text = "ОК";
			Button1.Location = new System.Drawing.Point(136, 156);
			Button1.Name = "Button1";
			Button1.Size = new System.Drawing.Size(40, 22);
			Button1.TabIndex = 1;
			Button1.Text = "РМ";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = OKButton;
			base.ClientSize = new System.Drawing.Size(424, 199);
			base.Controls.Add(TableLayoutPanel);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AbountProgramm";
			base.Padding = new System.Windows.Forms.Padding(9);
			base.ShowInTaskbar = false;
			Text = "О программе";
			TableLayoutPanel.ResumeLayout(false);
			TableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
			ResumeLayout(false);
		}

		private void AbountProgramm_Shown(object sender, EventArgs e)
		{
			LabelVersion.Text = "Версия: " + MyProject.Forms.start.version + " EASY";
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			Close();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (MyProject.Computer.FileSystem.FileExists(Application.StartupPath + "\\sound_click.wav"))
			{
				MyProject.Computer.Audio.Play(Application.StartupPath + "\\sound_click.wav", AudioPlayMode.Background);
			}
			if (MyProject.Forms.PM.ShowDialog() == DialogResult.OK)
			{
				MyProject.Forms.Settings.ShowDialog();
			}
		}
	}
}
