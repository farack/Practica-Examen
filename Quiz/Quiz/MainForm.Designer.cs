/*
 * Created by SharpDevelop.
 * User: jmanu_000
 * Date: 31/10/2013
 * Time: 07:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Quiz
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
			this.Codigo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TextCodigo = new System.Windows.Forms.TextBox();
			this.TextNombre = new System.Windows.Forms.TextBox();
			this.RadioDf = new System.Windows.Forms.RadioButton();
			this.RadioGuadalajara = new System.Windows.Forms.RadioButton();
			this.RadioMonterrey = new System.Windows.Forms.RadioButton();
			this.checkPortugal = new System.Windows.Forms.CheckBox();
			this.checkChile = new System.Windows.Forms.CheckBox();
			this.checkRUnido = new System.Windows.Forms.CheckBox();
			this.checkMacedonia = new System.Windows.Forms.CheckBox();
			this.checkAustralia = new System.Windows.Forms.CheckBox();
			this.CantidadEstados = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.CantidadEstados)).BeginInit();
			this.SuspendLayout();
			// 
			// Codigo
			// 
			this.Codigo.Location = new System.Drawing.Point(300, 23);
			this.Codigo.Name = "Codigo";
			this.Codigo.Size = new System.Drawing.Size(100, 23);
			this.Codigo.TabIndex = 0;
			this.Codigo.Text = "Codigo";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(300, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(36, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Capital de Mexico";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 364);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(255, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Cantidad de estados de los que se compone Mexico";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(479, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(230, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Dia en que termino la segunda guerra mundial";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// TextCodigo
			// 
			this.TextCodigo.Location = new System.Drawing.Point(354, 20);
			this.TextCodigo.Name = "TextCodigo";
			this.TextCodigo.Size = new System.Drawing.Size(100, 20);
			this.TextCodigo.TabIndex = 5;
			// 
			// TextNombre
			// 
			this.TextNombre.Location = new System.Drawing.Point(354, 49);
			this.TextNombre.Name = "TextNombre";
			this.TextNombre.Size = new System.Drawing.Size(100, 20);
			this.TextNombre.TabIndex = 6;
			// 
			// RadioDf
			// 
			this.RadioDf.Location = new System.Drawing.Point(36, 130);
			this.RadioDf.Name = "RadioDf";
			this.RadioDf.Size = new System.Drawing.Size(47, 24);
			this.RadioDf.TabIndex = 7;
			this.RadioDf.TabStop = true;
			this.RadioDf.Text = "DF";
			this.RadioDf.UseVisualStyleBackColor = true;
			this.RadioDf.CheckedChanged += new System.EventHandler(this.RadioDfCheckedChanged);
			// 
			// RadioGuadalajara
			// 
			this.RadioGuadalajara.Location = new System.Drawing.Point(90, 130);
			this.RadioGuadalajara.Name = "RadioGuadalajara";
			this.RadioGuadalajara.Size = new System.Drawing.Size(100, 24);
			this.RadioGuadalajara.TabIndex = 8;
			this.RadioGuadalajara.TabStop = true;
			this.RadioGuadalajara.Text = "Guadalajara";
			this.RadioGuadalajara.UseVisualStyleBackColor = true;
			// 
			// RadioMonterrey
			// 
			this.RadioMonterrey.Location = new System.Drawing.Point(175, 130);
			this.RadioMonterrey.Name = "RadioMonterrey";
			this.RadioMonterrey.Size = new System.Drawing.Size(91, 24);
			this.RadioMonterrey.TabIndex = 9;
			this.RadioMonterrey.TabStop = true;
			this.RadioMonterrey.Text = "Monterrey";
			this.RadioMonterrey.UseVisualStyleBackColor = true;
			// 
			// checkPortugal
			// 
			this.checkPortugal.Location = new System.Drawing.Point(36, 199);
			this.checkPortugal.Name = "checkPortugal";
			this.checkPortugal.Size = new System.Drawing.Size(104, 24);
			this.checkPortugal.TabIndex = 10;
			this.checkPortugal.Text = "Portugal";
			this.checkPortugal.UseVisualStyleBackColor = true;
			// 
			// checkChile
			// 
			this.checkChile.Location = new System.Drawing.Point(36, 229);
			this.checkChile.Name = "checkChile";
			this.checkChile.Size = new System.Drawing.Size(49, 23);
			this.checkChile.TabIndex = 11;
			this.checkChile.Text = "Chile";
			this.checkChile.UseVisualStyleBackColor = true;
			// 
			// checkRUnido
			// 
			this.checkRUnido.Location = new System.Drawing.Point(36, 258);
			this.checkRUnido.Name = "checkRUnido";
			this.checkRUnido.Size = new System.Drawing.Size(104, 24);
			this.checkRUnido.TabIndex = 12;
			this.checkRUnido.Text = "Reino Unido";
			this.checkRUnido.UseVisualStyleBackColor = true;
			this.checkRUnido.CheckedChanged += new System.EventHandler(this.CheckRUnidoCheckedChanged);
			// 
			// checkMacedonia
			// 
			this.checkMacedonia.Location = new System.Drawing.Point(36, 288);
			this.checkMacedonia.Name = "checkMacedonia";
			this.checkMacedonia.Size = new System.Drawing.Size(104, 24);
			this.checkMacedonia.TabIndex = 13;
			this.checkMacedonia.Text = "Macedonia";
			this.checkMacedonia.UseVisualStyleBackColor = true;
			// 
			// checkAustralia
			// 
			this.checkAustralia.Location = new System.Drawing.Point(36, 318);
			this.checkAustralia.Name = "checkAustralia";
			this.checkAustralia.Size = new System.Drawing.Size(104, 24);
			this.checkAustralia.TabIndex = 14;
			this.checkAustralia.Text = "Australia";
			this.checkAustralia.UseVisualStyleBackColor = true;
			// 
			// CantidadEstados
			// 
			this.CantidadEstados.Location = new System.Drawing.Point(36, 390);
			this.CantidadEstados.Name = "CantidadEstados";
			this.CantidadEstados.Size = new System.Drawing.Size(49, 20);
			this.CantidadEstados.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(36, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Paises de Europa";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(479, 125);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 17;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1DateChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(618, 390);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Terminar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(581, 223);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 19;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 454);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CantidadEstados);
			this.Controls.Add(this.checkAustralia);
			this.Controls.Add(this.checkMacedonia);
			this.Controls.Add(this.checkRUnido);
			this.Controls.Add(this.checkChile);
			this.Controls.Add(this.checkPortugal);
			this.Controls.Add(this.RadioMonterrey);
			this.Controls.Add(this.RadioGuadalajara);
			this.Controls.Add(this.RadioDf);
			this.Controls.Add(this.TextNombre);
			this.Controls.Add(this.TextCodigo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Codigo);
			this.Name = "MainForm";
			this.Text = "Quiz";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.CantidadEstados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox TextCodigo;
		private System.Windows.Forms.TextBox TextNombre;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.RadioButton RadioDf;
		private System.Windows.Forms.RadioButton RadioGuadalajara;
		private System.Windows.Forms.RadioButton RadioMonterrey;
		private System.Windows.Forms.CheckBox checkPortugal;
		private System.Windows.Forms.CheckBox checkChile;
		private System.Windows.Forms.CheckBox checkRUnido;
		private System.Windows.Forms.CheckBox checkMacedonia;
		private System.Windows.Forms.CheckBox checkAustralia;
		private System.Windows.Forms.NumericUpDown CantidadEstados;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Codigo;
	}
}
