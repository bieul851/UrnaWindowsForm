﻿namespace UrnaWindowsForm.Interface.CadastroCargoInterface
{
    partial class CDeputadoEstadual
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
            this.txtNomeDeputadoEstadual = new System.Windows.Forms.TextBox();
            this.txtNumDeputadoEstadual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntCadastrarPresidente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNomeDeputadoEstadual
            // 
            this.txtNomeDeputadoEstadual.Location = new System.Drawing.Point(226, 218);
            this.txtNomeDeputadoEstadual.Name = "txtNomeDeputadoEstadual";
            this.txtNomeDeputadoEstadual.Size = new System.Drawing.Size(225, 20);
            this.txtNomeDeputadoEstadual.TabIndex = 23;
            // 
            // txtNumDeputadoEstadual
            // 
            this.txtNumDeputadoEstadual.Location = new System.Drawing.Point(242, 168);
            this.txtNumDeputadoEstadual.Name = "txtNumDeputadoEstadual";
            this.txtNumDeputadoEstadual.Size = new System.Drawing.Size(62, 20);
            this.txtNumDeputadoEstadual.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cadastrando Deputado Estadual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numero do Candidato: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome do Candidato: ";
            // 
            // bntCadastrarPresidente
            // 
            this.bntCadastrarPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCadastrarPresidente.Location = new System.Drawing.Point(226, 303);
            this.bntCadastrarPresidente.Name = "bntCadastrarPresidente";
            this.bntCadastrarPresidente.Size = new System.Drawing.Size(111, 36);
            this.bntCadastrarPresidente.TabIndex = 18;
            this.bntCadastrarPresidente.Text = "Cadastrar";
            this.bntCadastrarPresidente.UseVisualStyleBackColor = true;
            this.bntCadastrarPresidente.Click += new System.EventHandler(this.BntCadastrarPresidente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estado: ";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG",
            "ES",
            "BA",
            "AM",
            "AC",
            "AL",
            "GO",
            "MS",
            "DF"});
            this.ComboBox.Location = new System.Drawing.Point(135, 258);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 24;
            // 
            // CDeputadoEstadual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.txtNomeDeputadoEstadual);
            this.Controls.Add(this.txtNumDeputadoEstadual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntCadastrarPresidente);
            this.Name = "CDeputadoEstadual";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDeputadoEstadual;
        private System.Windows.Forms.TextBox txtNumDeputadoEstadual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCadastrarPresidente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox;
    }
}