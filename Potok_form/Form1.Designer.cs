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
			this.components = new System.ComponentModel.Container();
			this.lbThread = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbThreadRun = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCreateThread = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lbThread
			// 
			this.lbThread.FormattingEnabled = true;
			this.lbThread.Location = new System.Drawing.Point(12, 31);
			this.lbThread.Name = "lbThread";
			this.lbThread.Size = new System.Drawing.Size(206, 303);
			this.lbThread.TabIndex = 0;
			this.lbThread.DoubleClick += new System.EventHandler(this.lbThread_DoubleClick);
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
			this.lbThreadRun.DoubleClick += new System.EventHandler(this.lbThreadRun_DoubleClick);
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
			this.btnCreateThread.Location = new System.Drawing.Point(12, 384);
			this.btnCreateThread.Name = "btnCreateThread";
			this.btnCreateThread.Size = new System.Drawing.Size(438, 23);
			this.btnCreateThread.TabIndex = 4;
			this.btnCreateThread.Text = "Add new  Create Thread to ListBox";
			this.btnCreateThread.UseVisualStyleBackColor = true;
			this.btnCreateThread.Click += new System.EventHandler(this.btnCreateThread_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(300, 352);
			this.label3.MinimumSize = new System.Drawing.Size(150, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(244, 351);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "count = ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 351);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "sec = ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(58, 352);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "label6";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 419);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCreateThread);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbThreadRun);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbThread);
			this.Name = "Form1";
			this.Text = "Form Work Thread";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.ListBox lbThread;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbThreadRun;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCreateThread;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Timer timer1;
		}
	}

