/*
 * Creado por SharpDevelop.
 * Usuario: lopza
 * Fecha: 26/11/2026
 * Hora: 02:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Programa3.
	/// </summary>
	public partial class Programa3 : Form
	{
		public Programa3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnInvertirClick(object sender, EventArgs e)
		{
			string palabra = txtPalabra.Text;
            string reves = "";
            
            for (int i = palabra.Length -1; i >=0; i--)
            {
            	reves=reves + palabra[i];
            }
            
            lblRespuesta.Text = "𝙰𝚕 𝚛𝚎𝚟𝚎́𝚜: " + reves;
		}
	}
}
