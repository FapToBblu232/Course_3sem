namespace Course_3sem
{
    partial class Form1
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
            lbPerson = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // lbPerson
            // 
            lbPerson.FormattingEnabled = true;
            lbPerson.ItemHeight = 25;
            lbPerson.Location = new Point(377, 29);
            lbPerson.Name = "lbPerson";
            lbPerson.Size = new Size(843, 429);
            lbPerson.TabIndex = 0;
            lbPerson.SelectedIndexChanged += lbPerson_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 4;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 72);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 109);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 6;
            label3.Text = "Отчество";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(195, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 146);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 8;
            label4.Text = "Город";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(195, 177);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 183);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 10;
            label5.Text = "Улица";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 220);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 11;
            label6.Text = "Номер дома";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(195, 214);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(195, 251);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 257);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 14;
            label7.Text = "Номер телефона";
            // 
            // button1
            // 
            button1.Location = new Point(28, 321);
            button1.Name = "button1";
            button1.Size = new Size(317, 36);
            button1.TabIndex = 15;
            button1.Text = "Внести";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(28, 363);
            button2.Name = "button2";
            button2.Size = new Size(317, 36);
            button2.TabIndex = 16;
            button2.Text = "Найти по данным";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 405);
            button3.Name = "button3";
            button3.Size = new Size(317, 36);
            button3.TabIndex = 17;
            button3.Text = "Вывести всех";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1246, 109);
            button4.Name = "button4";
            button4.Size = new Size(269, 40);
            button4.TabIndex = 18;
            button4.Text = "Сортировать по фамилии";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1246, 155);
            button5.Name = "button5";
            button5.Size = new Size(269, 40);
            button5.TabIndex = 19;
            button5.Text = "Сортировать по городу";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1246, 201);
            button6.Name = "button6";
            button6.Size = new Size(269, 40);
            button6.TabIndex = 20;
            button6.Text = "Сортировать по улице";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1246, 247);
            button7.Name = "button7";
            button7.Size = new Size(269, 40);
            button7.TabIndex = 21;
            button7.Text = "Изменить номер телефона";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1246, 293);
            button8.Name = "button8";
            button8.Size = new Size(269, 40);
            button8.TabIndex = 22;
            button8.Text = "Удалить\r\n";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 492);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbPerson);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbPerson;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
