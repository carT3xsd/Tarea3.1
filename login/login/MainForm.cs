/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 26/11/2026
 * Time: 07:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace login
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
		
		void BtnaceptarClick(object sender, EventArgs e)
		{
			string usuario = textBox1.Text;
    		string contrasena = textBox2.Text;

   			if (usuario == "admin" && contrasena == "1234")
   			{
       		 	 MessageBox.Show("¡Bienvenido al sistema!", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        		 menu ventanaMenu = new menu();
        		 ventanaMenu.Show();
        		 this.Hide();
    		}
    		else
    		{
        		MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        		textBox1.Clear();
       		 	textBox2.Clear();
        		textBox1.Focus();
			}
    		
    		
		}
	}
}
