
namespace FormsApp
{
	partial class PointForm
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
			this.listBox = new System.Windows.Forms.ListBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox
			// 
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(44, 28);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(450, 277);
			this.listBox.TabIndex = 0;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(60, 311);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(104, 48);
			this.btnCreate.TabIndex = 1;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(170, 311);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(104, 48);
			this.btnSort.TabIndex = 2;
			this.btnSort.Text = "Sort";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(280, 311);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 48);
			this.button3.TabIndex = 3;
			this.button3.Text = "Serialize";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(390, 311);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(104, 48);
			this.button4.TabIndex = 4;
			this.button4.Text = "Deserialize";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// PointForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 397);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.listBox);
			this.Name = "PointForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listBox;
	}
}

