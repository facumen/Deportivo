﻿namespace BugTracker
{
    partial class frmConsultaProductos
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
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnDetalleProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnl_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_filtros.Controls.Add(this.txtFechaHasta);
            this.pnl_filtros.Controls.Add(this.Label4);
            this.pnl_filtros.Controls.Add(this.Label3);
            this.pnl_filtros.Controls.Add(this.txtFechaDesde);
            this.pnl_filtros.Controls.Add(this.cboMarcas);
            this.pnl_filtros.Controls.Add(this.Label2);
            this.pnl_filtros.Controls.Add(this.btnConsultar);
            this.pnl_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_filtros.Location = new System.Drawing.Point(0, 0);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(852, 142);
            this.pnl_filtros.TabIndex = 1;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(374, 22);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(180, 20);
            this.txtFechaHasta.TabIndex = 13;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(302, 25);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Fecha Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Fecha desde:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(76, 22);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(181, 20);
            this.txtFechaDesde.TabIndex = 9;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // cboMarcas
            // 
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(76, 102);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(181, 21);
            this.cboMarcas.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 105);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Marca:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(753, 105);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProductos.Location = new System.Drawing.Point(0, 142);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(852, 265);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // btnDetalleProducto
            // 
            this.btnDetalleProducto.Location = new System.Drawing.Point(0, 0);
            this.btnDetalleProducto.Name = "btnDetalleProducto";
            this.btnDetalleProducto.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleProducto.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            // 
            // frmConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.btnDetalleProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.pnl_filtros);
            this.Name = "frmConsultaProductos";
            this.Text = "Consultar Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox pnl_filtros;
        internal System.Windows.Forms.MaskedTextBox txtFechaHasta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.MaskedTextBox txtFechaDesde;
        internal System.Windows.Forms.ComboBox cboMarcas;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.DataGridView dgvProductos;
        internal System.Windows.Forms.Button btnDetalleProducto;
        internal System.Windows.Forms.Button btnSalir;

    }
}