namespace Actividad5.VISTA.Actividad5VISTAS
{
    partial class DetalleVentaInterfaz
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(207, 459);
            button1.Name = "button1";
            button1.Size = new Size(130, 44);
            button1.TabIndex = 8;
            button1.Text = "DATOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(377, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(569, 514);
            dataGridView1.TabIndex = 7;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 381);
            button2.Name = "button2";
            button2.Size = new Size(130, 44);
            button2.TabIndex = 12;
            button2.Text = "INSERTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(207, 381);
            button3.Name = "button3";
            button3.Size = new Size(130, 44);
            button3.TabIndex = 13;
            button3.Text = "EDITAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 459);
            button4.Name = "button4";
            button4.Size = new Size(130, 44);
            button4.TabIndex = 14;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 23);
            textBox4.TabIndex = 18;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(120, 221);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(217, 23);
            textBox5.TabIndex = 19;
            // 
            // button5
            // 
            button5.Location = new Point(253, 12);
            button5.Name = "button5";
            button5.Size = new Size(118, 23);
            button5.TabIndex = 20;
            button5.Text = "SELECCIONAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(253, 58);
            button6.Name = "button6";
            button6.Size = new Size(118, 23);
            button6.TabIndex = 21;
            button6.Text = "SELECCIONAR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 22;
            label1.Text = "ID VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 67);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 23;
            label2.Text = "ID PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 120);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 24;
            label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 25;
            label4.Text = "PRECIO UNITARIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 229);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 26;
            label5.Text = "TOTAL DETALLE";
            // 
            // DetalleVentaInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 538);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "DetalleVentaInterfaz";
            Text = "DetalleVentaInterfaz";
            Load += DetalleVentaInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}