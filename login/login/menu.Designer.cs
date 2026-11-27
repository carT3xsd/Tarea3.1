/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC43
 * Fecha: 26/11/2026
 * Hora: 07:32 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class menu
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "menu principal";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(49, 105);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(290, 55);
			this.button1.TabIndex = 1;
			this.button1.Text = "Programa que reciba un arreglo y lo muestre ordenado de mayor a menor y de menor " +
			"a mayor.";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(49, 176);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(290, 50);
			this.button2.TabIndex = 2;
			this.button2.Text = "Programa qu reciba un arreglo y encuentre el mayor, el menor y el promedio";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(49, 237);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(290, 61);
			this.button3.TabIndex = 3;
			this.button3.Text = "Programa que reciba una palabra y la imprima al reves";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(49, 304);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(290, 55);
			this.button4.TabIndex = 4;
			this.button4.Text = "Programa que reciba una palabra e indique cuantas vocales y cuantas consonantes t" +
			"iene.";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 383);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "menu";
			this.Text = "menu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
