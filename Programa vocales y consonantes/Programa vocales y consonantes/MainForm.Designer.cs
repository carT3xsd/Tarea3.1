/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 26/11/2026
 * Hora: 07:32 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Programa_vocales_y_consonantes
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
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.lblConsonantes = new System.Windows.Forms.Label();
			this.lblVocales = new System.Windows.Forms.Label();
			this.btnContar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingrese la palabra: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(231, 52);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(285, 22);
			this.txtPalabra.TabIndex = 1;
			// 
			// lblConsonantes
			// 
			this.lblConsonantes.Location = new System.Drawing.Point(24, 131);
			this.lblConsonantes.Name = "lblConsonantes";
			this.lblConsonantes.Size = new System.Drawing.Size(263, 23);
			this.lblConsonantes.TabIndex = 2;
			this.lblConsonantes.Text = "Contador de consonantes: ";
			this.lblConsonantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVocales
			// 
			this.lblVocales.Location = new System.Drawing.Point(24, 194);
			this.lblVocales.Name = "lblVocales";
			this.lblVocales.Size = new System.Drawing.Size(263, 23);
			this.lblVocales.TabIndex = 3;
			this.lblVocales.Text = "Contador de vocales: ";
			this.lblVocales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnContar
			// 
			this.btnContar.Location = new System.Drawing.Point(425, 157);
			this.btnContar.Name = "btnContar";
			this.btnContar.Size = new System.Drawing.Size(127, 42);
			this.btnContar.TabIndex = 4;
			this.btnContar.Text = "Contar";
			this.btnContar.UseVisualStyleBackColor = true;
			this.btnContar.Click += new System.EventHandler(this.BtnContarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 501);
			this.Controls.Add(this.btnContar);
			this.Controls.Add(this.lblVocales);
			this.Controls.Add(this.lblConsonantes);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Programa vocales y consonantes";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnContar;
		private System.Windows.Forms.Label lblVocales;
		private System.Windows.Forms.Label lblConsonantes;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label1;
	}
}
