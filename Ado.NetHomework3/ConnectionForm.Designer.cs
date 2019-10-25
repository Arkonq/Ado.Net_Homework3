namespace Ado.NetHomework3
{
	partial class ConnectionForm
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
			this.buttonConnect = new System.Windows.Forms.Button();
			this.textBoxServerName = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonConnect
			// 
			this.buttonConnect.BackColor = System.Drawing.Color.Cyan;
			this.buttonConnect.Cursor = System.Windows.Forms.Cursors.Cross;
			this.buttonConnect.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonConnect.Location = new System.Drawing.Point(297, 192);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(106, 50);
			this.buttonConnect.TabIndex = 0;
			this.buttonConnect.Text = "Подключиться";
			this.buttonConnect.UseVisualStyleBackColor = false;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// textBoxServerName
			// 
			this.textBoxServerName.BackColor = System.Drawing.Color.Cyan;
			this.textBoxServerName.Location = new System.Drawing.Point(209, 148);
			this.textBoxServerName.Name = "textBoxServerName";
			this.textBoxServerName.Size = new System.Drawing.Size(296, 20);
			this.textBoxServerName.TabIndex = 1;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label.Location = new System.Drawing.Point(226, 106);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(250, 28);
			this.label.TabIndex = 2;
			this.label.Text = "Введите имя сервера ниже";
			// 
			// ConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(737, 389);
			this.Controls.Add(this.label);
			this.Controls.Add(this.textBoxServerName);
			this.Controls.Add(this.buttonConnect);
			this.ForeColor = System.Drawing.SystemColors.Highlight;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectionForm";
			this.RightToLeftLayout = true;
			this.Text = "Подключение к БД";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.TextBox textBoxServerName;
		private System.Windows.Forms.Label label;
	}
}

