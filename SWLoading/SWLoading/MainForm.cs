using SWLoading.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SWLoading
{
	public class MainForm : Form
	{
		public const float m_fChangeTime = 0.25f;

		public const float m_fChangeOpeningTime = 2f;

		public float m_fTime;

		public int m_iPointCount;

		public float m_fOpeningTime;

		private IContainer components;

		public MainForm()
		{
			this.InitializeComponent();
			base.Size = new Size(750, 430);
			base.Opacity = 0.0;
		}

		public bool Opening(float fElapsedTime)
		{
			this.m_fOpeningTime += fElapsedTime;
			if (this.m_fOpeningTime >= 2f)
			{
				return true;
			}
			if (this.m_fOpeningTime > 0f)
			{
				base.Opacity = (double)(this.m_fOpeningTime / 2f);
			}
			return false;
		}

		public void Run(float fElapsedTime)
		{
			this.m_fTime += fElapsedTime;
			if (this.m_fTime >= 0.25f)
			{
				switch (this.m_iPointCount)
				{
				case 1:
				case 2:
				case 3:
				case 4:
					IL_3A:
					this.m_iPointCount++;
					if (this.m_iPointCount > 4)
					{
						this.m_iPointCount = 0;
					}
					this.m_fTime = 0f;
					return;
				}
				goto IL_3A;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(7f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			this.BackgroundImage = Resources.splash3;
			this.BackgroundImageLayout = ImageLayout.None;
			base.ClientSize = new Size(750, 430);
			base.ControlBox = false;
			base.FormBorderStyle = FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "SWLoading";
			base.ResumeLayout(false);
		}
	}
}
