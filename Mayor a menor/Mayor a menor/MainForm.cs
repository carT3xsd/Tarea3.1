/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 25/11/2026
 * Hora: 08:17 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mayor_a_menor
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
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
			
		    try
		    {
		        string[] partes = txtNumeros.Text.Split(',');
		        int[] numeros = new int[partes.Length];
		
		        for (int i = 0; i < partes.Length; i++)
		        {
		            numeros[i] = int.Parse(partes[i].Trim());
		        }
		
		        int[] menorAMayor = (int[])numeros.Clone();
		        Array.Sort(menorAMayor);
		
		        int[] mayorAMenor = (int[])menorAMayor.Clone();
		        Array.Reverse(mayorAMenor);
		
		        lblMenorMayor.Text = "Menor a mayor: " + string.Join(", ", menorAMayor);
		        lblMayorMenor.Text = "Mayor a menor: " + string.Join(", ", mayorAMenor);
		    }
		    catch
		    {
		        MessageBox.Show("Ingresa números válidos separados por comas (ejemplo: 10, 5, 8, 2).");
		    }
		}
	}
}
