
namespace AcademiaBaile.Vistas
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalsa = new System.Windows.Forms.Button();
            this.btnOrdenarPorProfesor = new System.Windows.Forms.Button();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlPersonaliado11 = new AcademiaBaile.ControlPersonaliado1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacion.Location = new System.Drawing.Point(342, 57);
            this.lblFacturacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(260, 37);
            this.lblFacturacion.TabIndex = 2;
            this.lblFacturacion.Text = "FACTURACION";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(759, 471);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(126, 59);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(589, 471);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(126, 59);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalsa
            // 
            this.btnSalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalsa.Location = new System.Drawing.Point(388, 471);
            this.btnSalsa.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalsa.Name = "btnSalsa";
            this.btnSalsa.Size = new System.Drawing.Size(161, 59);
            this.btnSalsa.TabIndex = 6;
            this.btnSalsa.Text = "Mostrar Salsa";
            this.btnSalsa.UseVisualStyleBackColor = true;
            this.btnSalsa.Click += new System.EventHandler(this.btnSalsa_Click);
            // 
            // btnOrdenarPorProfesor
            // 
            this.btnOrdenarPorProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarPorProfesor.Location = new System.Drawing.Point(95, 471);
            this.btnOrdenarPorProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenarPorProfesor.Name = "btnOrdenarPorProfesor";
            this.btnOrdenarPorProfesor.Size = new System.Drawing.Size(248, 59);
            this.btnOrdenarPorProfesor.TabIndex = 7;
            this.btnOrdenarPorProfesor.Text = "Ordenar por Profesor";
            this.btnOrdenarPorProfesor.UseVisualStyleBackColor = true;
            this.btnOrdenarPorProfesor.Click += new System.EventHandler(this.btnOrdenarPorProfesor_Click);
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(438, 111);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(213, 21);
            this.cmbClientes.TabIndex = 9;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged_1);
            this.cmbClientes.SelectionChangeCommitted += new System.EventHandler(this.cmbClientes_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(710, 256);
            this.dataGridView1.TabIndex = 10;
            // 
            // controlPersonaliado11
            // 
            this.controlPersonaliado11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.controlPersonaliado11.Location = new System.Drawing.Point(598, 43);
            this.controlPersonaliado11.Name = "controlPersonaliado11";
            this.controlPersonaliado11.Size = new System.Drawing.Size(348, 63);
            this.controlPersonaliado11.TabIndex = 11;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.controlPersonaliado11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdenarPorProfesor);
            this.Controls.Add(this.btnSalsa);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblFacturacion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacturacion;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalsa;
        private System.Windows.Forms.Button btnOrdenarPorProfesor;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ControlPersonaliado1 controlPersonaliado11;
    }
}