﻿
namespace ClotheShop
{
    partial class QuotationForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CotizadorExpress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.vSeparator = new System.Windows.Forms.Label();
            this.hTopSeparator = new System.Windows.Forms.Label();
            this.hBottomSeparator = new System.Windows.Forms.Label();
            this.priceGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.premiumRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.stockGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.garmentsGroup = new System.Windows.Forms.GroupBox();
            this.maoCollarCheckBox = new System.Windows.Forms.CheckBox();
            this.pantTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.shortSleeveCheckBox = new System.Windows.Forms.CheckBox();
            this.pantRadiobutton = new System.Windows.Forms.RadioButton();
            this.shirtRadioButton = new System.Windows.Forms.RadioButton();
            this.quoteButton = new System.Windows.Forms.Button();
            this.records = new System.Windows.Forms.LinkLabel();
            this.direction = new System.Windows.Forms.Label();
            this.shopName = new System.Windows.Forms.Label();
            this.codSeller = new System.Windows.Forms.Label();
            this.sellerName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.priceGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.stockGroup.SuspendLayout();
            this.garmentsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CotizadorExpress
            // 
            this.CotizadorExpress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CotizadorExpress.AutoSize = true;
            this.CotizadorExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CotizadorExpress.ForeColor = System.Drawing.Color.White;
            this.CotizadorExpress.Location = new System.Drawing.Point(189, 26);
            this.CotizadorExpress.MaximumSize = new System.Drawing.Size(700, 600);
            this.CotizadorExpress.Name = "CotizadorExpress";
            this.CotizadorExpress.Size = new System.Drawing.Size(295, 39);
            this.CotizadorExpress.TabIndex = 0;
            this.CotizadorExpress.Text = "Cotizador Express";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.vSeparator);
            this.panel1.Controls.Add(this.hTopSeparator);
            this.panel1.Controls.Add(this.hBottomSeparator);
            this.panel1.Controls.Add(this.priceGroup);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.stockGroup);
            this.panel1.Controls.Add(this.garmentsGroup);
            this.panel1.Controls.Add(this.quoteButton);
            this.panel1.Controls.Add(this.records);
            this.panel1.Controls.Add(this.direction);
            this.panel1.Controls.Add(this.shopName);
            this.panel1.Controls.Add(this.codSeller);
            this.panel1.Controls.Add(this.sellerName);
            this.panel1.Location = new System.Drawing.Point(-23, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 689);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(373, 574);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(235, 38);
            this.textBox2.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.White;
            this.priceLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.priceLabel.Location = new System.Drawing.Point(327, 577);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(29, 31);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "$";
            // 
            // vSeparator
            // 
            this.vSeparator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vSeparator.Location = new System.Drawing.Point(230, 36);
            this.vSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.vSeparator.Name = "vSeparator";
            this.vSeparator.Size = new System.Drawing.Size(10, 44);
            this.vSeparator.TabIndex = 13;
            // 
            // hTopSeparator
            // 
            this.hTopSeparator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hTopSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hTopSeparator.Location = new System.Drawing.Point(20, 36);
            this.hTopSeparator.Name = "hTopSeparator";
            this.hTopSeparator.Size = new System.Drawing.Size(679, 10);
            this.hTopSeparator.TabIndex = 12;
            // 
            // hBottomSeparator
            // 
            this.hBottomSeparator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hBottomSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hBottomSeparator.Location = new System.Drawing.Point(20, 80);
            this.hBottomSeparator.Name = "hBottomSeparator";
            this.hBottomSeparator.Size = new System.Drawing.Size(679, 10);
            this.hBottomSeparator.TabIndex = 11;
            // 
            // priceGroup
            // 
            this.priceGroup.Controls.Add(this.label3);
            this.priceGroup.Controls.Add(this.label2);
            this.priceGroup.Controls.Add(this.amountTextBox);
            this.priceGroup.Controls.Add(this.priceTextBox);
            this.priceGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceGroup.Location = new System.Drawing.Point(373, 425);
            this.priceGroup.Name = "priceGroup";
            this.priceGroup.Size = new System.Drawing.Size(260, 100);
            this.priceGroup.TabIndex = 10;
            this.priceGroup.TabStop = false;
            this.priceGroup.Text = "Precio unitario y Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant.";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(169, 42);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(66, 23);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(27, 42);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(66, 23);
            this.priceTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.premiumRadioButton);
            this.groupBox1.Controls.Add(this.standardRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calidad de Prenda";
            // 
            // premiumRadioButton
            // 
            this.premiumRadioButton.AutoSize = true;
            this.premiumRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premiumRadioButton.Location = new System.Drawing.Point(164, 45);
            this.premiumRadioButton.Name = "premiumRadioButton";
            this.premiumRadioButton.Size = new System.Drawing.Size(81, 21);
            this.premiumRadioButton.TabIndex = 11;
            this.premiumRadioButton.Text = "Premium";
            this.premiumRadioButton.UseVisualStyleBackColor = true;
            this.premiumRadioButton.CheckedChanged += new System.EventHandler(this.premiumRadioButton_CheckedChanged);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Checked = true;
            this.standardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardRadioButton.Location = new System.Drawing.Point(36, 45);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(84, 21);
            this.standardRadioButton.TabIndex = 10;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            // 
            // stockGroup
            // 
            this.stockGroup.Controls.Add(this.textBox1);
            this.stockGroup.Controls.Add(this.stockLabel);
            this.stockGroup.Location = new System.Drawing.Point(79, 304);
            this.stockGroup.Name = "stockGroup";
            this.stockGroup.Size = new System.Drawing.Size(554, 70);
            this.stockGroup.TabIndex = 8;
            this.stockGroup.TabStop = false;
            this.stockGroup.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 1;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(36, 29);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(129, 17);
            this.stockLabel.TabIndex = 0;
            this.stockLabel.Text = "Unidades en stock:";
            // 
            // garmentsGroup
            // 
            this.garmentsGroup.Controls.Add(this.maoCollarCheckBox);
            this.garmentsGroup.Controls.Add(this.pantTypeCheckBox);
            this.garmentsGroup.Controls.Add(this.shortSleeveCheckBox);
            this.garmentsGroup.Controls.Add(this.pantRadiobutton);
            this.garmentsGroup.Controls.Add(this.shirtRadioButton);
            this.garmentsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garmentsGroup.Location = new System.Drawing.Point(79, 133);
            this.garmentsGroup.Name = "garmentsGroup";
            this.garmentsGroup.Size = new System.Drawing.Size(554, 155);
            this.garmentsGroup.TabIndex = 7;
            this.garmentsGroup.TabStop = false;
            this.garmentsGroup.Text = "Prenda";
            this.garmentsGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maoCollarCheckBox
            // 
            this.maoCollarCheckBox.AutoSize = true;
            this.maoCollarCheckBox.Location = new System.Drawing.Point(411, 38);
            this.maoCollarCheckBox.Name = "maoCollarCheckBox";
            this.maoCollarCheckBox.Size = new System.Drawing.Size(97, 21);
            this.maoCollarCheckBox.TabIndex = 9;
            this.maoCollarCheckBox.Text = "Cuello Mao";
            this.maoCollarCheckBox.UseVisualStyleBackColor = true;
            this.maoCollarCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // pantTypeCheckBox
            // 
            this.pantTypeCheckBox.AutoSize = true;
            this.pantTypeCheckBox.Location = new System.Drawing.Point(242, 93);
            this.pantTypeCheckBox.Name = "pantTypeCheckBox";
            this.pantTypeCheckBox.Size = new System.Drawing.Size(71, 21);
            this.pantTypeCheckBox.TabIndex = 8;
            this.pantTypeCheckBox.Text = "Chupín";
            this.pantTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // shortSleeveCheckBox
            // 
            this.shortSleeveCheckBox.AutoSize = true;
            this.shortSleeveCheckBox.Location = new System.Drawing.Point(242, 38);
            this.shortSleeveCheckBox.Name = "shortSleeveCheckBox";
            this.shortSleeveCheckBox.Size = new System.Drawing.Size(108, 21);
            this.shortSleeveCheckBox.TabIndex = 7;
            this.shortSleeveCheckBox.Text = "Manga Corta";
            this.shortSleeveCheckBox.UseVisualStyleBackColor = true;
            // 
            // pantRadiobutton
            // 
            this.pantRadiobutton.AutoSize = true;
            this.pantRadiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantRadiobutton.Location = new System.Drawing.Point(36, 93);
            this.pantRadiobutton.Name = "pantRadiobutton";
            this.pantRadiobutton.Size = new System.Drawing.Size(82, 21);
            this.pantRadiobutton.TabIndex = 6;
            this.pantRadiobutton.Text = "Pantalón";
            this.pantRadiobutton.UseVisualStyleBackColor = true;
            // 
            // shirtRadioButton
            // 
            this.shirtRadioButton.AutoSize = true;
            this.shirtRadioButton.Checked = true;
            this.shirtRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shirtRadioButton.Location = new System.Drawing.Point(36, 38);
            this.shirtRadioButton.Name = "shirtRadioButton";
            this.shirtRadioButton.Size = new System.Drawing.Size(72, 21);
            this.shirtRadioButton.TabIndex = 5;
            this.shirtRadioButton.TabStop = true;
            this.shirtRadioButton.Text = "Camisa";
            this.shirtRadioButton.UseVisualStyleBackColor = true;
            // 
            // quoteButton
            // 
            this.quoteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quoteButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.quoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quoteButton.FlatAppearance.BorderSize = 2;
            this.quoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteButton.ForeColor = System.Drawing.Color.White;
            this.quoteButton.Location = new System.Drawing.Point(79, 564);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(203, 63);
            this.quoteButton.TabIndex = 6;
            this.quoteButton.Text = "Cotizar";
            this.quoteButton.UseVisualStyleBackColor = false;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // records
            // 
            this.records.AutoSize = true;
            this.records.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.records.LinkColor = System.Drawing.Color.DarkOrchid;
            this.records.Location = new System.Drawing.Point(539, 46);
            this.records.Name = "records";
            this.records.Size = new System.Drawing.Size(143, 17);
            this.records.TabIndex = 4;
            this.records.TabStop = true;
            this.records.Text = "Historial Cotizaciones";
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.direction.Location = new System.Drawing.Point(510, 9);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(172, 17);
            this.direction.TabIndex = 3;
            this.direction.Text = "Dirección de la Tienda";
            this.direction.Click += new System.EventHandler(this.direction_Click);
            // 
            // shopName
            // 
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.shopName.Location = new System.Drawing.Point(35, 9);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(119, 17);
            this.shopName.TabIndex = 2;
            this.shopName.Text = "Nombre Tienda";
            // 
            // codSeller
            // 
            this.codSeller.AutoSize = true;
            this.codSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codSeller.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.codSeller.Location = new System.Drawing.Point(247, 46);
            this.codSeller.Name = "codSeller";
            this.codSeller.Size = new System.Drawing.Size(126, 17);
            this.codSeller.TabIndex = 1;
            this.codSeller.Text = "Código Vendeedor";
            this.codSeller.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // sellerName
            // 
            this.sellerName.AutoSize = true;
            this.sellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.sellerName.Location = new System.Drawing.Point(35, 46);
            this.sellerName.Name = "sellerName";
            this.sellerName.Size = new System.Drawing.Size(189, 17);
            this.sellerName.TabIndex = 0;
            this.sellerName.Text = "Nombre y Apellido Vendedor";
            this.sellerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuotationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(671, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CotizadorExpress);
            this.MaximumSize = new System.Drawing.Size(687, 780);
            this.Name = "QuotationForm";
            this.Text = "Cotizador Express";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.priceGroup.ResumeLayout(false);
            this.priceGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.stockGroup.ResumeLayout(false);
            this.stockGroup.PerformLayout();
            this.garmentsGroup.ResumeLayout(false);
            this.garmentsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CotizadorExpress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sellerName;
        private System.Windows.Forms.Label codSeller;
        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.LinkLabel records;
        private System.Windows.Forms.GroupBox garmentsGroup;
        private System.Windows.Forms.RadioButton shirtRadioButton;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.CheckBox maoCollarCheckBox;
        private System.Windows.Forms.CheckBox pantTypeCheckBox;
        private System.Windows.Forms.CheckBox shortSleeveCheckBox;
        private System.Windows.Forms.RadioButton pantRadiobutton;
        private System.Windows.Forms.GroupBox stockGroup;
        private System.Windows.Forms.GroupBox priceGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton premiumRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label hBottomSeparator;
        private System.Windows.Forms.Label vSeparator;
        private System.Windows.Forms.Label hTopSeparator;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label priceLabel;
    }
}

