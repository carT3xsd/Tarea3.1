/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 25/11/2026
 * Hora: 08:17 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Mayor_a_menor
{
	partial class MainForm
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
			this.txtNumeros = new System.Windows.Forms.TextBox();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.lblMenorMayor = new System.Windows.Forms.Label();
			this.lblMayorMenor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingrese los numeros a ordenar:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNumeros
			// 
			this.txtNumeros.Location = new System.Drawing.Point(242, 55);
			this.txtNumeros.Name = "txtNumeros";
			this.txtNumeros.Size = new System.Drawing.Size(450, 22);
			this.txtNumeros.TabIndex = 1;
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(79, 121);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(137, 43);
			this.btnOrdenar.TabIndex = 2;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// lblMenorMayor
			// 
			this.lblMenorMayor.Location = new System.Drawing.Point(27, 197);
			this.lblMenorMayor.Name = "lblMenorMayor";
			this.lblMenorMayor.Size = new System.Drawing.Size(209, 44);
			this.lblMenorMayor.TabIndex = 3;
			this.lblMenorMayor.Text = "Menor a Mayor: ";
			this.lblMenorMayor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMayorMenor
			// 
			this.lblMayorMenor.Location = new System.Drawing.Point(27, 256);
			this.lblMayorMenor.Name = "lblMayorMenor";
			this.lblMayorMenor.Size = new System.Drawing.Size(209, 44);
			this.lblMayorMenor.TabIndex = 4;
			this.lblMayorMenor.Text = "Mayor a Menor: ";
			this.lblMayorMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 418);
			this.Controls.Add(this.lblMayorMenor);
			this.Controls.Add(this.lblMenorMayor);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.txtNumeros);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Mayor a menor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblMayorMenor;
		private System.Windows.Forms.Label lblMenorMayor;
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.TextBox txtNumeros;
		private System.Windows.Forms.Label label1;
	}
}
