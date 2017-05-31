namespace Potok_form
	{
	partial class Form1
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if(disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			this.lbThread = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbThreadRun = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCreateThread = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbThread
			// 
			this.lbThread.FormattingEnabled = true;
			this.lbThread.Location = new System.Drawing.Point(12, 31);
			this.lbThread.Name = "lbThread";
			this.lbThread.Size = new System.Drawing.Size(206, 303);
			this.lbThread.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Double Click For Run";
			// 
			// lbThreadRun
			// 
			this.lbThreadRun.FormattingEnabled = true;
			this.lbThreadRun.Location = new System.Drawing.Point(244, 31);
			this.lbThreadRun.Name = "lbThreadRun";
			this.lbThreadRun.Size = new System.Drawing.Size(206, 303);
			this.lbThreadRun.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(252, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Double Click For Stop";
			// 
			// btnCreateThread
			// 
			this.btnCreateThread.Location = new System.Drawing.Point(12, 369);
			this.btnCreateThread.Name = "btnCreateThread";
			this.btnCreateThread.Size = new System.Drawing.Size(438, 23);
			this.btnCreateThread.TabIndex = 4;
			this.btnCreateThread.Text = "Add new  Create Thread to ListBox";
			this.btnCreateThread.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 419);
			this.Controls.Add(this.btnCreateThread);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbThreadRun);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbThread);
			this.Name = "Form1";
			this.Text = "Form Work Thread";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.ListBox lbThread;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbThreadRun;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCreateThread;
		}
	}

