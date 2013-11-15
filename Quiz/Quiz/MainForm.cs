/*
 * Created by SharpDevelop.
 * User: jmanu_000
 * Date: 31/10/2013
 * Time: 07:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int Acierto =0;
			
			
			if(this.RadioDf.Checked){
				Acierto++;
			}
			if(this.checkPortugal.Checked){
				
				Acierto++;
			}
			if(this.checkMacedonia.Checked){
				
				Acierto++;
			}
			
			if(this.checkRUnido.Checked){
				
				Acierto++;
			}
		
			
				if (CantidadEstados.Value == 32){
			
					
			Acierto++;
		}
			
			string fecha=monthCalendar1.SelectionStart.Date.ToShortDateString();
				 if(fecha=="07/05/1945"){
				 	Acierto++;
				 }
				 
			MessageBox.Show("Codigo:  "+TextCodigo.Text+"\n"+"Nombre:  "+TextNombre.Text+"\n"+"Aciertos: "+Acierto);
		}
		void CheckRUnidoCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void RadioDfCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void MonthCalendar1DateChanged(object sender, DateRangeEventArgs e)
		{
			
			   




		}
	}
}
