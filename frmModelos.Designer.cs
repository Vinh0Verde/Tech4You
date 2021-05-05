
namespace Tech4You
{
    partial class frmModelos
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
            System.Windows.Forms.Button btnEliminar;
            System.Windows.Forms.Button btnInserir;
            System.Windows.Forms.Button btnFechar;
            this.btnEditar = new System.Windows.Forms.Button();
            this.lvModelos = new System.Windows.Forms.ListView();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbbMarcas = new System.Windows.Forms.ComboBox();
            btnEliminar = new System.Windows.Forms.Button();
            btnInserir = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            btnEliminar.Location = new System.Drawing.Point(472, 132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(112, 54);
            btnEliminar.TabIndex = 56;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInserir
            // 
            btnInserir.BackColor = System.Drawing.SystemColors.ControlLight;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            btnInserir.Location = new System.Drawing.Point(472, 12);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new System.Drawing.Size(112, 54);
            btnInserir.TabIndex = 53;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnFechar
            // 
            btnFechar.BackColor = System.Drawing.SystemColors.ControlLight;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFechar.ForeColor = System.Drawing.SystemColors.ControlText;
            btnFechar.Location = new System.Drawing.Point(472, 380);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(112, 54);
            btnFechar.TabIndex = 59;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(472, 72);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 54);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lvModelos
            // 
            this.lvModelos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvModelos.HideSelection = false;
            this.lvModelos.Location = new System.Drawing.Point(16, 124);
            this.lvModelos.Name = "lvModelos";
            this.lvModelos.Size = new System.Drawing.Size(350, 163);
            this.lvModelos.TabIndex = 54;
            this.lvModelos.UseCompatibleStateImageBehavior = false;
            this.lvModelos.DoubleClick += new System.EventHandler(this.lvMarcas_DoubleClick);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(16, 89);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(348, 29);
            this.txtModelo.TabIndex = 52;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(12, 65);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(66, 21);
            this.lblModelo.TabIndex = 51;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 21);
            this.lblMarca.TabIndex = 57;
            this.lblMarca.Text = "Marca:";
            // 
            // cbbMarcas
            // 
            this.cbbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMarcas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMarcas.FormattingEnabled = true;
            this.cbbMarcas.Location = new System.Drawing.Point(16, 33);
            this.cbbMarcas.Name = "cbbMarcas";
            this.cbbMarcas.Size = new System.Drawing.Size(344, 29);
            this.cbbMarcas.TabIndex = 58;
            // 
            // frmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 446);
            this.Controls.Add(btnFechar);
            this.Controls.Add(this.cbbMarcas);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lvModelos);
            this.Controls.Add(btnInserir);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmModelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModelos";
            this.Load += new System.EventHandler(this.frmModelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListView lvModelos;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbbMarcas;
    }
}