/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 26/11/2026
 * Hora: 07:46 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class Menor_a_mayor_y_menor_a_mayor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresa la serie de numeros: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ejemplo: \"2, 4, 70, 80, 90, 6\"";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(260, 52);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(301, 22);
			this.textBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(234, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Numeros de mayor a menor: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 242);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(234, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Numeros de menor a mayor:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Menor_a_mayor_y_menor_a_mayor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 477);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Menor_a_mayor_y_menor_a_mayor";
			this.Text = "Menor_a_mayor_y_menor_a_mayor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
