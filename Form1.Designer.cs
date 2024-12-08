namespace practice5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            bittechBox = new GroupBox();
            comboBox1 = new ComboBox();
            bittechList = new ListBox();
            mikrpech = new GroupBox();
            firmaBox = new GroupBox();
            tsenaBox = new GroupBox();
            powerBox = new GroupBox();
            colorBox = new GroupBox();
            holodBox = new GroupBox();
            tsena1Box = new GroupBox();
            volumeBox = new GroupBox();
            power1Box = new GroupBox();
            firma1Box = new GroupBox();
            textfirma = new TextBox();
            texttsena = new TextBox();
            textpower = new TextBox();
            textcolor = new TextBox();
            textfirma1 = new TextBox();
            texttsena1 = new TextBox();
            textvolume = new TextBox();
            textpower1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            bittechBox.SuspendLayout();
            mikrpech.SuspendLayout();
            firmaBox.SuspendLayout();
            tsenaBox.SuspendLayout();
            powerBox.SuspendLayout();
            colorBox.SuspendLayout();
            holodBox.SuspendLayout();
            tsena1Box.SuspendLayout();
            volumeBox.SuspendLayout();
            power1Box.SuspendLayout();
            firma1Box.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            bittechBox.Controls.Add(holodBox);
            bittechBox.Controls.Add(mikrpech);
            bittechBox.Controls.Add(comboBox1);
            bittechBox.Location = new Point(63, 21);
            bittechBox.Name = "groupBox1";
            bittechBox.Size = new Size(647, 278);
            bittechBox.TabIndex = 1;
            bittechBox.TabStop = false;
            bittechBox.Text = "Бытовая техника";
            //bittech.Enter += bittech_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Items.AddRange(new object[] {
                "Микроволновая печь",
                "Холодильник"});

            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bittechList
            // 
            bittechList.FormattingEnabled = true;
            bittechList.ItemHeight = 20;
            bittechList.Location = new Point(63, 358);
            bittechList.Name = "bittechList";
            bittechList.Size = new Size(647, 124);
            bittechList.TabIndex = 2;
           // bittechList.SelectedIndexChanged += bittechList_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            mikrpech.Controls.Add(tsenaBox);
            mikrpech.Controls.Add(powerBox);
            mikrpech.Controls.Add(colorBox);
            mikrpech.Controls.Add(firmaBox);
            mikrpech.Location = new Point(6, 72);
            mikrpech.Name = "groupBox2";
            mikrpech.Size = new Size(311, 188);
            mikrpech.TabIndex = 4;
            mikrpech.TabStop = false;
            mikrpech.Text = "Микроволновая печь";
            // 
            // groupBox3
            // 
            firmaBox.Controls.Add(textfirma);
            firmaBox.Location = new Point(15, 37);
            firmaBox.Name = "groupBox3";
            firmaBox.Size = new Size(136, 55);
            firmaBox.TabIndex = 0;
            firmaBox.TabStop = false;
            firmaBox.Text = "Фирма";
            // 
            // groupBox4
            // 
            tsenaBox.Controls.Add(texttsena);
            tsenaBox.Location = new Point(159, 37);
            tsenaBox.Name = "groupBox4";
            tsenaBox.Size = new Size(136, 55);
            tsenaBox.TabIndex = 1;
            tsenaBox.TabStop = false;
            tsenaBox.Text = "Цена";
            // 
            // groupBox5
            // 
            powerBox.Controls.Add(textpower);
            powerBox.Location = new Point(15, 115);
            powerBox.Name = "powerBox";
            powerBox.Size = new Size(136, 55);
            powerBox.TabIndex = 1;
            powerBox.TabStop = false;
            powerBox.Text = "Мощность";
            // 
            // groupBox6
            // 
            colorBox.Controls.Add(textcolor);
            colorBox.Location = new Point(159, 115);
            colorBox.Name = "groupBox6";
            colorBox.Size = new Size(136, 55);
            colorBox.TabIndex = 1;
            colorBox.TabStop = false;
            colorBox.Text = "Цвет";
            // 
            // groupBox7
            // 
            holodBox.Controls.Add(tsena1Box);
            holodBox.Controls.Add(volumeBox);
            holodBox.Controls.Add(power1Box);
            holodBox.Controls.Add(firma1Box);
            holodBox.Location = new Point(330, 72);
            holodBox.Name = "groupBox7";
            holodBox.Size = new Size(311, 188);
            holodBox.TabIndex = 5;
            holodBox.TabStop = false;
            holodBox.Text = "Холодильник";
            // 
            // groupBox8
            // 
            tsena1Box.Controls.Add(texttsena1);
            tsena1Box.Location = new Point(159, 37);
            tsena1Box.Name = "groupBox8";
            tsena1Box.Size = new Size(136, 55);
            tsena1Box.TabIndex = 1;
            tsena1Box.TabStop = false;
            tsena1Box.Text = "Цена";
            // 
            // groupBox9
            // 
            volumeBox.Controls.Add(textvolume);
            volumeBox.Location = new Point(15, 115);
            volumeBox.Name = "groupBox9";
            volumeBox.Size = new Size(136, 55);
            volumeBox.TabIndex = 1;
            volumeBox.TabStop = false;
            volumeBox.Text = "Объем";
            // 
            // groupBox10
            // 
            power1Box.Controls.Add(textpower1);
            power1Box.Location = new Point(159, 115);
            power1Box.Name = "groupBox10";
            power1Box.Size = new Size(136, 55);
            power1Box.TabIndex = 1;
            power1Box.TabStop = false;
            power1Box.Text = "Мощность";
            // 
            // groupBox11
            // 
            firma1Box.Controls.Add(textfirma1);
            firma1Box.Location = new Point(15, 37);
            firma1Box.Name = "groupBox11";
            firma1Box.Size = new Size(136, 55);
            firma1Box.TabIndex = 0;
            firma1Box.TabStop = false;
            firma1Box.Text = "Фирма";
            // 
            // textBox1
            // 
            textfirma.Location = new Point(6, 22);
            textfirma.Name = "textBox1";
            textfirma.Size = new Size(125, 27);
            textfirma.TabIndex = 0;
            //textBox1.TextChanged += textBox1_TextChanged;
            // 
            // texttsena
            // 
            texttsena.Location = new Point(5, 22);
            texttsena.Name = "textBox2";
            texttsena.Size = new Size(125, 27);
            texttsena.TabIndex = 1;
            // 
            // textBox3
            // 
            textpower.Location = new Point(6, 22);
            textpower.Name = "textBox3";
            textpower.Size = new Size(125, 27);
            textpower.TabIndex = 2;
            // 
            // textBox4
            // 
            textcolor.Location = new Point(5, 22);
            textcolor.Name = "textBox4";
            textcolor.Size = new Size(125, 27);
            textcolor.TabIndex = 3;
            // 
            // textBox5
            // 
            textfirma1.Location = new Point(5, 22);
            textfirma1.Name = "textBox5";
            textfirma1.Size = new Size(125, 27);
            textfirma1.TabIndex = 4;
            // 
            // textBox6
            // 
            texttsena1.Location = new Point(6, 22);
            texttsena1.Name = "textBox6";
            texttsena1.Size = new Size(125, 27);
            texttsena1.TabIndex = 5;
            // 
            // textBox7
            // 
            textvolume.Location = new Point(6, 22);
            textvolume.Name = "textBox7";
            textvolume.Size = new Size(125, 27);
            textvolume.TabIndex = 6;
            // 
            // textBox8
            // 
            textpower1.Location = new Point(6, 22);
            textpower1.Name = "textBox8";
            textpower1.Size = new Size(125, 27);
            textpower1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(63, 323);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(buttonAdd_Click);
            // 
            // button2
            // 
            button2.Location = new Point(196, 323);
            button2.Name = "button2";
            button2.Size = new Size(115, 29);
            button2.TabIndex = 4;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(buttonClear_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bittechList);
            Controls.Add(bittechBox);
            Name = "Form1";
            Text = "Form1";
            bittechBox.ResumeLayout(false);
            mikrpech.ResumeLayout(false);
            firmaBox.ResumeLayout(false);
            firmaBox.PerformLayout();
            tsenaBox.ResumeLayout(false);
            tsenaBox.PerformLayout();
            powerBox.ResumeLayout(false);
            powerBox.PerformLayout();
            colorBox.ResumeLayout(false);
            colorBox.PerformLayout();
            holodBox.ResumeLayout(false);
            tsena1Box.ResumeLayout(false);
            tsena1Box.PerformLayout();
            volumeBox.ResumeLayout(false);
            volumeBox.PerformLayout();
            power1Box.ResumeLayout(false);
            power1Box.PerformLayout();
            firma1Box.ResumeLayout(false);
            firma1Box.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox bittechBox;
        private ComboBox comboBox1;
        private ListBox bittechList;
        private GroupBox mikrpech;
        private GroupBox tsenaBox;
        private GroupBox powerBox;
        private GroupBox colorBox;
        private GroupBox firmaBox;
        private GroupBox holodBox;
        private GroupBox tsena1Box;
        private GroupBox volumeBox;
        private GroupBox power1Box;
        private GroupBox firma1Box;
        private TextBox textfirma;
        private TextBox texttsena1;
        private TextBox textvolume;
        private TextBox textpower1;
        private TextBox textfirma1;
        private TextBox texttsena;
        private TextBox textpower;
        private TextBox textcolor;
        private Button button1;
        private Button button2;
    }
}