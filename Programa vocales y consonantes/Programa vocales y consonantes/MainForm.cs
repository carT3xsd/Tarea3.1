/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 26/11/2026
 * Hora: 07:32 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programa_vocales_y_consonantes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnContarClick(object sender, EventArgs e)
		{
			string palabra = txtPalabra.Text.Trim().ToLower();

			if (string.IsNullOrEmpty(palabra))
			{
			    MessageBox.Show("Por favor, escribe una palabra.");
			    return;
			}
			
			int vocales=0;
			int consonantes=0;
			
			for (int i=0; i<palabra.Length; i++)
			{
			    char c=palabra[i];
			
			    if(char.IsLetter(c))
			    {
			        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
			            c == 'á' || c == 'é' || c == 'í' || c == 'ó' || c == 'ú')
			        {
			            vocales++;
			        }
			        else
			        {
			            consonantes++;
			        }
			    }
			}
			
			lblVocales.Text = "Vocales: "+vocales;
			lblConsonantes.Text = "Consonantes: "+consonantes;
		}
	}
}
