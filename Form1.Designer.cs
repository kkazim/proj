namespace proj
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tetrahedron_radio = new System.Windows.Forms.RadioButton();
            this.Cube_radio = new System.Windows.Forms.RadioButton();
            this.Empty_radio = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rotation = new System.Windows.Forms.Button();
            this.Z_angle = new System.Windows.Forms.TextBox();
            this.Y_angle = new System.Windows.Forms.TextBox();
            this.X_angle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OnLeft = new System.Windows.Forms.Button();
            this.OnRight = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dvizh = new System.Windows.Forms.Button();
            this.Y_vector = new System.Windows.Forms.TextBox();
            this.X_vector = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.izom = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(284, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 706);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Tetrahedron_radio);
            this.panel1.Controls.Add(this.Cube_radio);
            this.panel1.Controls.Add(this.Empty_radio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 89);
            this.panel1.TabIndex = 1;
            // 
            // Tetrahedron_radio
            // 
            this.Tetrahedron_radio.AutoSize = true;
            this.Tetrahedron_radio.Location = new System.Drawing.Point(4, 62);
            this.Tetrahedron_radio.Name = "Tetrahedron_radio";
            this.Tetrahedron_radio.Size = new System.Drawing.Size(112, 24);
            this.Tetrahedron_radio.TabIndex = 2;
            this.Tetrahedron_radio.TabStop = true;
            this.Tetrahedron_radio.Text = "Тетраэдр";
            this.Tetrahedron_radio.UseVisualStyleBackColor = true;
            this.Tetrahedron_radio.CheckedChanged += new System.EventHandler(this.Tetrahedron_radio_CheckedChanged);
            this.Tetrahedron_radio.Click += new System.EventHandler(this.Tetrahedron_radio_Click);
            // 
            // Cube_radio
            // 
            this.Cube_radio.AutoSize = true;
            this.Cube_radio.Location = new System.Drawing.Point(4, 32);
            this.Cube_radio.Name = "Cube_radio";
            this.Cube_radio.Size = new System.Drawing.Size(59, 24);
            this.Cube_radio.TabIndex = 1;
            this.Cube_radio.TabStop = true;
            this.Cube_radio.Text = "Куб";
            this.Cube_radio.UseVisualStyleBackColor = true;
            this.Cube_radio.CheckedChanged += new System.EventHandler(this.Cube_radio_CheckedChanged);
            this.Cube_radio.Click += new System.EventHandler(this.Cube_radio_Click);
            // 
            // Empty_radio
            // 
            this.Empty_radio.AutoSize = true;
            this.Empty_radio.Location = new System.Drawing.Point(4, 4);
            this.Empty_radio.Name = "Empty_radio";
            this.Empty_radio.Size = new System.Drawing.Size(80, 24);
            this.Empty_radio.TabIndex = 0;
            this.Empty_radio.TabStop = true;
            this.Empty_radio.Text = "Пусто";
            this.Empty_radio.UseVisualStyleBackColor = true;
            this.Empty_radio.CheckedChanged += new System.EventHandler(this.Empty_radio_CheckedChanged);
            this.Empty_radio.Click += new System.EventHandler(this.Empty_radio_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Rotation);
            this.panel3.Controls.Add(this.Z_angle);
            this.panel3.Controls.Add(this.Y_angle);
            this.panel3.Controls.Add(this.X_angle);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 126);
            this.panel3.TabIndex = 3;
            // 
            // Rotation
            // 
            this.Rotation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Rotation.Location = new System.Drawing.Point(0, 72);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(282, 52);
            this.Rotation.TabIndex = 5;
            this.Rotation.Text = "Поворот";
            this.Rotation.UseVisualStyleBackColor = true;
            this.Rotation.Click += new System.EventHandler(this.Rotation_Click);
            // 
            // Z_angle
            // 
            this.Z_angle.Location = new System.Drawing.Point(201, 26);
            this.Z_angle.Name = "Z_angle";
            this.Z_angle.Size = new System.Drawing.Size(76, 26);
            this.Z_angle.TabIndex = 4;
            // 
            // Y_angle
            // 
            this.Y_angle.Location = new System.Drawing.Point(109, 26);
            this.Y_angle.Name = "Y_angle";
            this.Y_angle.Size = new System.Drawing.Size(86, 26);
            this.Y_angle.TabIndex = 3;
            // 
            // X_angle
            // 
            this.X_angle.Location = new System.Drawing.Point(4, 26);
            this.X_angle.Name = "X_angle";
            this.X_angle.Size = new System.Drawing.Size(99, 26);
            this.X_angle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Поворот";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.OnLeft);
            this.panel4.Controls.Add(this.OnRight);
            this.panel4.Controls.Add(this.Down);
            this.panel4.Controls.Add(this.Up);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 138);
            this.panel4.TabIndex = 4;
            // 
            // OnLeft
            // 
            this.OnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.OnLeft.Location = new System.Drawing.Point(0, 44);
            this.OnLeft.Name = "OnLeft";
            this.OnLeft.Size = new System.Drawing.Size(140, 49);
            this.OnLeft.TabIndex = 3;
            this.OnLeft.Text = "Влево";
            this.OnLeft.UseVisualStyleBackColor = true;
            this.OnLeft.Click += new System.EventHandler(this.OnLeft_Click);
            // 
            // OnRight
            // 
            this.OnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.OnRight.Location = new System.Drawing.Point(146, 44);
            this.OnRight.Name = "OnRight";
            this.OnRight.Size = new System.Drawing.Size(136, 49);
            this.OnRight.TabIndex = 2;
            this.OnRight.Text = "Вправо";
            this.OnRight.UseVisualStyleBackColor = true;
            this.OnRight.Click += new System.EventHandler(this.OnRight_Click);
            // 
            // Down
            // 
            this.Down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Down.Location = new System.Drawing.Point(0, 93);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(282, 43);
            this.Down.TabIndex = 1;
            this.Down.Text = "Вниз";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Up
            // 
            this.Up.Dock = System.Windows.Forms.DockStyle.Top;
            this.Up.Location = new System.Drawing.Point(0, 0);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(282, 44);
            this.Up.TabIndex = 0;
            this.Up.Text = "Вверх";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exit.Location = new System.Drawing.Point(0, 665);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(284, 41);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dvizh);
            this.panel2.Controls.Add(this.Y_vector);
            this.panel2.Controls.Add(this.X_vector);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 126);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вектор";
            // 
            // dvizh
            // 
            this.dvizh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvizh.Location = new System.Drawing.Point(0, 72);
            this.dvizh.Name = "dvizh";
            this.dvizh.Size = new System.Drawing.Size(282, 52);
            this.dvizh.TabIndex = 5;
            this.dvizh.Text = "Двигать";
            this.dvizh.UseVisualStyleBackColor = true;
            this.dvizh.Click += new System.EventHandler(this.dvizh_Click);
            // 
            // Y_vector
            // 
            this.Y_vector.Location = new System.Drawing.Point(109, 26);
            this.Y_vector.Name = "Y_vector";
            this.Y_vector.Size = new System.Drawing.Size(97, 26);
            this.Y_vector.TabIndex = 3;
            // 
            // X_vector
            // 
            this.X_vector.Location = new System.Drawing.Point(4, 26);
            this.X_vector.Name = "X_vector";
            this.X_vector.Size = new System.Drawing.Size(99, 26);
            this.X_vector.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.izom);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 479);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 46);
            this.panel5.TabIndex = 7;
            // 
            // izom
            // 
            this.izom.Location = new System.Drawing.Point(8, 5);
            this.izom.Name = "izom";
            this.izom.Size = new System.Drawing.Size(132, 33);
            this.izom.TabIndex = 1;
            this.izom.Text = "Изометрия";
            this.izom.UseVisualStyleBackColor = true;
            this.izom.Click += new System.EventHandler(this.izom_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBox3);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 525);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 134);
            this.panel6.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Характеристики";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "20";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Длина ребра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Объем";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(99, 26);
            this.textBox2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "Площадь \r\nповерхности";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(99, 26);
            this.textBox3.TabIndex = 11;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 706);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Z_angle;
        private System.Windows.Forms.TextBox Y_angle;
        private System.Windows.Forms.TextBox X_angle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OnLeft;
        private System.Windows.Forms.Button OnRight;
        private System.Windows.Forms.Button Down;   
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Rotation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dvizh;
        private System.Windows.Forms.TextBox Y_vector;
        private System.Windows.Forms.TextBox X_vector;
        private System.Windows.Forms.RadioButton Tetrahedron_radio;
        private System.Windows.Forms.RadioButton Cube_radio;
        private System.Windows.Forms.RadioButton Empty_radio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button izom;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

