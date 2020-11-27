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
			this.btnClear = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCursor = new System.Windows.Forms.Button();
			this.tText = new System.Windows.Forms.TextBox();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnMovedCursor = new System.Windows.Forms.Button();
			this.lbText = new System.Windows.Forms.Label();
			this.lbWidth = new System.Windows.Forms.Label();
			this.nWidth = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.nHeight = new System.Windows.Forms.NumericUpDown();
			this.btnColorOutline = new System.Windows.Forms.Button();
			this.btnFill = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.canvasBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
			this.SuspendLayout();
			// 
			// canvasBox
			// 
			this.canvasBox.BackColor = System.Drawing.Color.White;
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
			this.btnRectangle.Location = new System.Drawing.Point(415, 12);
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
			this.btnEllipse.Location = new System.Drawing.Point(481, 12);
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
			this.btnConnection.Location = new System.Drawing.Point(547, 12);
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
			this.btnActor.Location = new System.Drawing.Point(613, 12);
			this.btnActor.Name = "btnActor";
			this.btnActor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnActor.Size = new System.Drawing.Size(60, 50);
			this.btnActor.TabIndex = 5;
			this.btnActor.UseVisualStyleBackColor = true;
			this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
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
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
			// tText
			// 
			this.tText.Location = new System.Drawing.Point(1032, 84);
			this.tText.Name = "tText";
			this.tText.Size = new System.Drawing.Size(124, 20);
			this.tText.TabIndex = 12;
			// 
			// btnConfirm
			// 
			this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnConfirm.Location = new System.Drawing.Point(1032, 313);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(124, 26);
			this.btnConfirm.TabIndex = 13;
			this.btnConfirm.Text = "Сохранить";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// btnMovedCursor
			// 
			this.btnMovedCursor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMovedCursor.BackgroundImage")));
			this.btnMovedCursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMovedCursor.Location = new System.Drawing.Point(350, 12);
			this.btnMovedCursor.Name = "btnMovedCursor";
			this.btnMovedCursor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnMovedCursor.Size = new System.Drawing.Size(60, 50);
			this.btnMovedCursor.TabIndex = 14;
			this.btnMovedCursor.UseVisualStyleBackColor = true;
			this.btnMovedCursor.Click += new System.EventHandler(this.btnMovedCursor_Click);
			// 
			// lbText
			// 
			this.lbText.AutoSize = true;
			this.lbText.Location = new System.Drawing.Point(1032, 68);
			this.lbText.Name = "lbText";
			this.lbText.Size = new System.Drawing.Size(37, 13);
			this.lbText.TabIndex = 15;
			this.lbText.Text = "Текст";
			// 
			// lbWidth
			// 
			this.lbWidth.AutoSize = true;
			this.lbWidth.Location = new System.Drawing.Point(1032, 111);
			this.lbWidth.Name = "lbWidth";
			this.lbWidth.Size = new System.Drawing.Size(46, 13);
			this.lbWidth.TabIndex = 16;
			this.lbWidth.Text = "Ширина";
			// 
			// nWidth
			// 
			this.nWidth.Location = new System.Drawing.Point(1032, 127);
			this.nWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nWidth.Name = "nWidth";
			this.nWidth.Size = new System.Drawing.Size(124, 20);
			this.nWidth.TabIndex = 18;
			this.nWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1032, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Высота";
			// 
			// nHeight
			// 
			this.nHeight.Location = new System.Drawing.Point(1032, 175);
			this.nHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nHeight.Name = "nHeight";
			this.nHeight.Size = new System.Drawing.Size(124, 20);
			this.nHeight.TabIndex = 20;
			this.nHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// btnColorOutline
			// 
			this.btnColorOutline.FlatAppearance.BorderSize = 5;
			this.btnColorOutline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnColorOutline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnColorOutline.Location = new System.Drawing.Point(1032, 211);
			this.btnColorOutline.Name = "btnColorOutline";
			this.btnColorOutline.Size = new System.Drawing.Size(124, 45);
			this.btnColorOutline.TabIndex = 21;
			this.btnColorOutline.Text = "Обводка";
			this.btnColorOutline.UseVisualStyleBackColor = true;
			this.btnColorOutline.Click += new System.EventHandler(this.btnColorOutline_Click);
			// 
			// btnFill
			// 
			this.btnFill.FlatAppearance.BorderSize = 5;
			this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFill.Location = new System.Drawing.Point(1032, 262);
			this.btnFill.Name = "btnFill";
			this.btnFill.Size = new System.Drawing.Size(124, 45);
			this.btnFill.TabIndex = 22;
			this.btnFill.Text = "Заливка";
			this.btnFill.UseVisualStyleBackColor = true;
			this.btnFill.Click += new System.EventHandler(this.btnFill_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 587);
			this.Controls.Add(this.btnFill);
			this.Controls.Add(this.btnColorOutline);
			this.Controls.Add(this.nHeight);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nWidth);
			this.Controls.Add(this.lbWidth);
			this.Controls.Add(this.lbText);
			this.Controls.Add(this.btnMovedCursor);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.tText);
			this.Controls.Add(this.btnCursor);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnActor);
			this.Controls.Add(this.btnConnection);
			this.Controls.Add(this.btnEllipse);
			this.Controls.Add(this.btnRectangle);
			this.Controls.Add(this.canvasBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.canvasBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox canvasBox;
		private System.Windows.Forms.Button btnRectangle;
		private System.Windows.Forms.Button btnEllipse;
		private System.Windows.Forms.Button btnConnection;
		private System.Windows.Forms.Button btnActor;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCursor;
		private System.Windows.Forms.TextBox tText;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnMovedCursor;
		private System.Windows.Forms.Label lbText;
		private System.Windows.Forms.Label lbWidth;
		private System.Windows.Forms.NumericUpDown nWidth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nHeight;
		private System.Windows.Forms.Button btnColorOutline;
		private System.Windows.Forms.Button btnFill;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}

