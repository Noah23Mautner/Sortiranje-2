namespace Sortiranje_vozila
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.listBoxVozila = new System.Windows.Forms.ListBox();
            this.comboBoxSortiranje = new System.Windows.Forms.ComboBox();
            this.Sortirano = new System.Windows.Forms.Label();
            this.txtSortiranaLista = new System.Windows.Forms.TextBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "GodinaProizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilometraza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(109, 6);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 26);
            this.txtMarka.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(109, 54);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 26);
            this.txtModel.TabIndex = 6;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(205, 92);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(100, 26);
            this.txtGodinaProizvodnje.TabIndex = 7;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(205, 126);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(100, 26);
            this.txtKilometraza.TabIndex = 8;
            this.txtKilometraza.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // listBoxVozila
            // 
            this.listBoxVozila.FormattingEnabled = true;
            this.listBoxVozila.ItemHeight = 20;
            this.listBoxVozila.Location = new System.Drawing.Point(482, 6);
            this.listBoxVozila.Name = "listBoxVozila";
            this.listBoxVozila.Size = new System.Drawing.Size(236, 184);
            this.listBoxVozila.TabIndex = 9;
            // 
            // comboBoxSortiranje
            // 
            this.comboBoxSortiranje.FormattingEnabled = true;
            this.comboBoxSortiranje.Location = new System.Drawing.Point(34, 204);
            this.comboBoxSortiranje.Name = "comboBoxSortiranje";
            this.comboBoxSortiranje.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSortiranje.TabIndex = 10;
            // 
            // Sortirano
            // 
            this.Sortirano.AutoSize = true;
            this.Sortirano.Location = new System.Drawing.Point(12, 281);
            this.Sortirano.Name = "Sortirano";
            this.Sortirano.Size = new System.Drawing.Size(74, 20);
            this.Sortirano.TabIndex = 11;
            this.Sortirano.Text = "Sortirano";
            // 
            // txtSortiranaLista
            // 
            this.txtSortiranaLista.Location = new System.Drawing.Point(109, 255);
            this.txtSortiranaLista.Multiline = true;
            this.txtSortiranaLista.Name = "txtSortiranaLista";
            this.txtSortiranaLista.Size = new System.Drawing.Size(217, 72);
            this.txtSortiranaLista.TabIndex = 12;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(187, 204);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(94, 33);
            this.btnSortiraj.TabIndex = 13;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Dodaj Vozilo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.txtSortiranaLista);
            this.Controls.Add(this.Sortirano);
            this.Controls.Add(this.comboBoxSortiranje);
            this.Controls.Add(this.listBoxVozila);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.ListBox listBoxVozila;
        private System.Windows.Forms.ComboBox comboBoxSortiranje;
        private System.Windows.Forms.Label Sortirano;
        private System.Windows.Forms.TextBox txtSortiranaLista;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button button2;
    }
}

