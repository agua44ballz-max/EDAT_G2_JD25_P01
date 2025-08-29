namespace NumerosAleatorios
{
    partial class frmEmpleado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(26, 341);
            button1.Name = "button1";
            button1.Size = new Size(381, 35);
            button1.TabIndex = 0;
            button1.Text = "Generar datos aleatorios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(richTextBox3);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(26, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 314);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(126, 147);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "femenino\r\n";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(126, 172);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "masculino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(81, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(76, 25);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(63, 231);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(143, 25);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(81, 53);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(289, 25);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(66, 274);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Seguro medico";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 8;
            label1.Text = "numero";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 9;
            label2.Text = "nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 104);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 10;
            label3.Text = "fecha de nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 205);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "grupo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 241);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "sueldo";
            label5.Click += label5_Click;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 404);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "frmEmpleado";
            Text = "Form1";
            Load += frmEmpleado_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
