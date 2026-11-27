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
	/// Description of Programa2.
	/// </summary>
	public partial class Programa2 : Form
	{
		public Programa2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			 // Separar los números por coma
		    string[] partes = txtNumeros.Text.Split(',');
		    int[] numeros = new int[partes.Length];
		    
		    for (int i = 0; i < partes.Length; i++)
		    {
		        numeros[i] = int.Parse(partes[i]);
		    }
		    
		    int mayor = numeros[0];
		    int menor = numeros[0];
		    int suma = 0;
		    
		    for (int i = 0; i < numeros.Length; i++)
		    {
		        if (numeros[i] > mayor)
		        {
		            mayor = numeros[i];
		        }
		        if (numeros[i] < menor)
		        {
		            menor = numeros[i];
		        }
		        suma = suma + numeros[i];
		    }
		    
		    double promedio = (double)suma / numeros.Length;
		    
		    lblMayor.Text = "Mayor: " + mayor;
		    lblMenor.Text = "Menor: " + menor;
		    lblPromedio.Text = "Promedio: " + promedio;
		}
	}
}
