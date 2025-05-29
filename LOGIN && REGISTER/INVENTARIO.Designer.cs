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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            Stock_btn = new Button();
            Precio_txt = new TextBox();
            textbox = new Label();
            Agregar_btn = new Button();
            Categoria_cmb = new ComboBox();
            Stock_txt = new TextBox();
            Producto_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(393, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(379, 412);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-150, 88);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Stock_btn);
            panel1.Controls.Add(Precio_txt);
            panel1.Controls.Add(textbox);
            panel1.Controls.Add(Agregar_btn);
            panel1.Controls.Add(Categoria_cmb);
            panel1.Controls.Add(Stock_txt);
            panel1.Controls.Add(Producto_txt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 412);
            panel1.TabIndex = 1;
            // 
            // Stock_btn
            // 
            Stock_btn.Location = new Point(212, 220);
            Stock_btn.Name = "Stock_btn";
            Stock_btn.Size = new Size(96, 28);
            Stock_btn.TabIndex = 10;
            Stock_btn.Text = "Calcular Stock";
            Stock_btn.UseVisualStyleBackColor = true;
            // 
            // Precio_txt
            // 
            Precio_txt.Location = new Point(143, 155);
            Precio_txt.Name = "Precio_txt";
            Precio_txt.Size = new Size(206, 23);
            Precio_txt.TabIndex = 9;
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Font = new Font("Segoe UI", 12F);
            textbox.Location = new Point(21, 155);
            textbox.Name = "textbox";
            textbox.Size = new Size(56, 21);
            textbox.TabIndex = 8;
            textbox.Text = "Precio:";
            // 
            // Agregar_btn
            // 
            Agregar_btn.Location = new Point(35, 220);
            Agregar_btn.Name = "Agregar_btn";
            Agregar_btn.Size = new Size(96, 28);
            Agregar_btn.TabIndex = 7;
            Agregar_btn.Text = "Agregar";
            Agregar_btn.UseVisualStyleBackColor = true;
            // 
            // Categoria_cmb
            // 
            Categoria_cmb.FormattingEnabled = true;
            Categoria_cmb.Items.AddRange(new object[] { "Dispositivos de entretenimiento", "Dispositivos de comunicación", "Herramientas eléctricas y electrónicas", "Aparatos de intercambio de temperatura", "Computadoras" });
            Categoria_cmb.Location = new Point(143, 85);
            Categoria_cmb.Name = "Categoria_cmb";
            Categoria_cmb.Size = new Size(206, 23);
            Categoria_cmb.TabIndex = 6;
            // 
            // Stock_txt
            // 
            Stock_txt.Location = new Point(143, 120);
            Stock_txt.Name = "Stock_txt";
            Stock_txt.Size = new Size(206, 23);
            Stock_txt.TabIndex = 5;
            // 
            // Producto_txt
            // 
            Producto_txt.Location = new Point(143, 46);
            Producto_txt.Name = "Producto_txt";
            Producto_txt.Size = new Size(206, 23);
            Producto_txt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 118);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 2;
            label4.Text = "Stock:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 1;
            label3.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 48);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 0;
            label2.Text = "Producto:";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(69, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 127);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(106, 10);
            label5.Name = "label5";
            label5.Size = new Size(158, 21);
            label5.TabIndex = 12;
            label5.Text = "HOME APPLIANCES";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // INVENTARIO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "INVENTARIO";
            Text = "INVENTARIO";
            Load += INVENTARIO_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox Precio_txt;
        private Label textbox;
        private Button Agregar_btn;
        private ComboBox Categoria_cmb;
        private TextBox Stock_txt;
        private TextBox Producto_txt;
        private Button Stock_btn;
        private Label label5;
        private PictureBox pictureBox1;
    }
}