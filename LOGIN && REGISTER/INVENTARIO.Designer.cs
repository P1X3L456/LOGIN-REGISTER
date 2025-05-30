namespace LOGIN____REGISTER
{
    partial class INVENTARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INVENTARIO));
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnCalcularStock = new Button();
            txtPrecio = new TextBox();
            textbox = new Label();
            Agregar_btn = new Button();
            cmbCategoria = new ComboBox();
            txtStock = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lvwProductos = new ListView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-171, 117);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCalcularStock);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(textbox);
            panel1.Controls.Add(Agregar_btn);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 549);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(121, 13);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 12;
            label5.Text = "HOME APPLIANCES";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(79, 357);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 169);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnCalcularStock
            // 
            btnCalcularStock.Location = new Point(242, 293);
            btnCalcularStock.Margin = new Padding(3, 4, 3, 4);
            btnCalcularStock.Name = "btnCalcularStock";
            btnCalcularStock.Size = new Size(110, 37);
            btnCalcularStock.TabIndex = 10;
            btnCalcularStock.Text = "Calcular Stock";
            btnCalcularStock.UseVisualStyleBackColor = true;
            btnCalcularStock.Click += btnCalcularStock_Click_1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(163, 207);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(235, 27);
            txtPrecio.TabIndex = 9;
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Font = new Font("Segoe UI", 12F);
            textbox.Location = new Point(24, 207);
            textbox.Name = "textbox";
            textbox.Size = new Size(70, 28);
            textbox.TabIndex = 8;
            textbox.Text = "Precio:";
            // 
            // Agregar_btn
            // 
            Agregar_btn.Location = new Point(40, 293);
            Agregar_btn.Margin = new Padding(3, 4, 3, 4);
            Agregar_btn.Name = "Agregar_btn";
            Agregar_btn.Size = new Size(110, 37);
            Agregar_btn.TabIndex = 7;
            Agregar_btn.Text = "Agregar";
            Agregar_btn.UseVisualStyleBackColor = true;
            Agregar_btn.Click += Agregar_btn_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(163, 113);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(235, 28);
            cmbCategoria.TabIndex = 6;
            cmbCategoria.SelectedIndexChanged += CmbCategoria_SelectedIndexChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(163, 160);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(235, 27);
            txtStock.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 61);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 27);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += TextProducto_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 157);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 2;
            label4.Text = "Stock:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 111);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 1;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 64);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 0;
            label2.Text = "Producto:";
            label2.Click += label2_Click;
            // 
            // lvwProductos
            // 
            lvwProductos.Location = new Point(441, 29);
            lvwProductos.Margin = new Padding(3, 4, 3, 4);
            lvwProductos.Name = "lvwProductos";
            lvwProductos.Size = new Size(559, 535);
            lvwProductos.TabIndex = 13;
            lvwProductos.UseCompatibleStateImageBehavior = false;
            lvwProductos.SelectedIndexChanged += lvwProductos_SelectedIndexChanged;
            // 
            // INVENTARIO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1024, 575);
            Controls.Add(lvwProductos);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "INVENTARIO";
            Text = "INVENTARIO";
            Load += INVENTARIO_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPrecio;
        private Label textbox;
        private Button Agregar_btn;
        private ComboBox cmbCategoria;
        private TextBox txtStock;
        private TextBox txtNombre;
        private Button btnCalcularStock;
        private Label label5;
        private PictureBox pictureBox1;
        private ListView lvwProductos;
    }
}