namespace Actividad5.VISTA.Actividad5VISTAS
{
    partial class VentaInterfaz
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
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 394);
            button1.Name = "button1";
            button1.Size = new Size(101, 44);
            button1.TabIndex = 11;
            button1.Text = "INSERTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 93);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 10;
            label2.Text = "FECHA VENTA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 9;
            label1.Text = "TOTAL VENTA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(218, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(416, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(368, 426);
            dataGridView1.TabIndex = 6;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(146, 394);
            button2.Name = "button2";
            button2.Size = new Size(94, 44);
            button2.TabIndex = 12;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(266, 394);
            button3.Name = "button3";
            button3.Size = new Size(98, 44);
            button3.TabIndex = 13;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // VentaInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "VentaInterfaz";
            Text = "VentaInterfaz";
            Load += VentaInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
    }
}