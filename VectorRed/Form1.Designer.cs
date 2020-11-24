namespace VectorRed
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.canvasBox = new System.Windows.Forms.PictureBox();
			this.btnRectangle = new System.Windows.Forms.Button();
			this.btnEllipse = new System.Windows.Forms.Button();
			this.btnConnection = new System.Windows.Forms.Button();
			this.btnActor = new System.Windows.Forms.Button();
			this.btnColor = new System.Windows.Forms.Button();
			this.btnFill = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCursor = new System.Windows.Forms.Button();
			this.text = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
			this.SuspendLayout();
			// 
			// canvasBox
			// 
			this.canvasBox.Location = new System.Drawing.Point(12, 68);
			this.canvasBox.Name = "canvasBox";
			this.canvasBox.Size = new System.Drawing.Size(1014, 507);
			this.canvasBox.TabIndex = 0;
			this.canvasBox.TabStop = false;
			this.canvasBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.canvasBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.canvasBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// btnRectangle
			// 
			this.btnRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRectangle.BackgroundImage")));
			this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRectangle.Location = new System.Drawing.Point(349, 12);
			this.btnRectangle.Name = "btnRectangle";
			this.btnRectangle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnRectangle.Size = new System.Drawing.Size(60, 50);
			this.btnRectangle.TabIndex = 2;
			this.btnRectangle.UseVisualStyleBackColor = true;
			this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
			// 
			// btnEllipse
			// 
			this.btnEllipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEllipse.BackgroundImage")));
			this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEllipse.Location = new System.Drawing.Point(415, 12);
			this.btnEllipse.Name = "btnEllipse";
			this.btnEllipse.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnEllipse.Size = new System.Drawing.Size(60, 50);
			this.btnEllipse.TabIndex = 3;
			this.btnEllipse.UseVisualStyleBackColor = true;
			this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
			// 
			// btnConnection
			// 
			this.btnConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnection.BackgroundImage")));
			this.btnConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnConnection.Location = new System.Drawing.Point(481, 12);
			this.btnConnection.Name = "btnConnection";
			this.btnConnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnConnection.Size = new System.Drawing.Size(60, 50);
			this.btnConnection.TabIndex = 4;
			this.btnConnection.UseVisualStyleBackColor = true;
			this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
			// 
			// btnActor
			// 
			this.btnActor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActor.BackgroundImage")));
			this.btnActor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnActor.Location = new System.Drawing.Point(547, 12);
			this.btnActor.Name = "btnActor";
			this.btnActor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnActor.Size = new System.Drawing.Size(60, 50);
			this.btnActor.TabIndex = 5;
			this.btnActor.UseVisualStyleBackColor = true;
			this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
			// 
			// btnColor
			// 
			this.btnColor.BackColor = System.Drawing.SystemColors.Control;
			this.btnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColor.BackgroundImage")));
			this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnColor.Location = new System.Drawing.Point(657, 12);
			this.btnColor.Name = "btnColor";
			this.btnColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnColor.Size = new System.Drawing.Size(60, 50);
			this.btnColor.TabIndex = 6;
			this.btnColor.Tag = "1";
			this.btnColor.UseVisualStyleBackColor = false;
			// 
			// btnFill
			// 
			this.btnFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFill.BackgroundImage")));
			this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFill.Location = new System.Drawing.Point(723, 12);
			this.btnFill.Name = "btnFill";
			this.btnFill.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnFill.Size = new System.Drawing.Size(60, 50);
			this.btnFill.TabIndex = 7;
			this.btnFill.Tag = "1";
			this.btnFill.UseVisualStyleBackColor = true;
			this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClear.Location = new System.Drawing.Point(141, 12);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(86, 50);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Очистить";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnLoad
			// 
			this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLoad.Location = new System.Drawing.Point(10, 38);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(125, 24);
			this.btnLoad.TabIndex = 9;
			this.btnLoad.Text = "Загрузить";
			this.btnLoad.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(10, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(125, 24);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCursor
			// 
			this.btnCursor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCursor.BackgroundImage")));
			this.btnCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCursor.Location = new System.Drawing.Point(284, 12);
			this.btnCursor.Name = "btnCursor";
			this.btnCursor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnCursor.Size = new System.Drawing.Size(60, 50);
			this.btnCursor.TabIndex = 11;
			this.btnCursor.UseVisualStyleBackColor = true;
			this.btnCursor.Click += new System.EventHandler(this.btnCursor_Click);
			// 
			// text
			// 
			this.text.Location = new System.Drawing.Point(1032, 68);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(124, 20);
			this.text.TabIndex = 12;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnConfirm.Location = new System.Drawing.Point(1032, 94);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(124, 26);
			this.btnConfirm.TabIndex = 13;
			this.btnConfirm.Text = "Сохранить";
			this.btnConfirm.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 587);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.text);
			this.Controls.Add(this.btnCursor);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnFill);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.btnActor);
			this.Controls.Add(this.btnConnection);
			this.Controls.Add(this.btnEllipse);
			this.Controls.Add(this.btnRectangle);
			this.Controls.Add(this.canvasBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox canvasBox;
		private System.Windows.Forms.Button btnRectangle;
		private System.Windows.Forms.Button btnEllipse;
		private System.Windows.Forms.Button btnConnection;
		private System.Windows.Forms.Button btnActor;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.Button btnFill;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCursor;
		private System.Windows.Forms.TextBox text;
		private System.Windows.Forms.Button btnConfirm;
	}
}

