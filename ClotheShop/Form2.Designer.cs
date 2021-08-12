
namespace ClotheShop
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Premium = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MangaCorta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CuelloMao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chupin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.FechaHora,
            this.Código,
            this.Prenda,
            this.Premium,
            this.MangaCorta,
            this.CuelloMao,
            this.Chupin,
            this.Cantidad,
            this.Total});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(590, 629);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Tag = "";
            this.Id.Text = "Id";
            this.Id.Width = 26;
            // 
            // FechaHora
            // 
            this.FechaHora.Text = "Fecha         Hora";
            this.FechaHora.Width = 109;
            // 
            // Código
            // 
            this.Código.Text = "Cód.";
            this.Código.Width = 53;
            // 
            // Prenda
            // 
            this.Prenda.Text = "Prenda";
            this.Prenda.Width = 48;
            // 
            // Premium
            // 
            this.Premium.Text = "Premium";
            this.Premium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Premium.Width = 54;
            // 
            // MangaCorta
            // 
            this.MangaCorta.Text = "Manga Corta";
            this.MangaCorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MangaCorta.Width = 73;
            // 
            // CuelloMao
            // 
            this.CuelloMao.Text = "Cuello Mao";
            this.CuelloMao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CuelloMao.Width = 71;
            // 
            // Chupin
            // 
            this.Chupin.Text = "Chupín";
            this.Chupin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Chupin.Width = 55;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cant.";
            this.Cantidad.Width = 39;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 85;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(614, 699);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Historial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader FechaHora;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader Prenda;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Premium;
        private System.Windows.Forms.ColumnHeader MangaCorta;
        private System.Windows.Forms.ColumnHeader CuelloMao;
        private System.Windows.Forms.ColumnHeader Chupin;
    }
}