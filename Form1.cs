using Microsoft.VisualBasic.Devices;

namespace practice5
{
    public partial class Form1 : Form
    {
        List<Bittech> Bittech = new List<Bittech>();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Bittech newBittech = null;


                if (comboBox1.SelectedIndex == 0) //  
                {
                    string firma = textfirma.Text.Trim();
                    int tsena = Convert.ToInt32(texttsena.Text.Trim());
                    int power = int.Parse(textpower.Text.Trim());
                    string color = textcolor.Text.Trim();
                    newBittech = new Mikrpech(firma, tsena, color, power);
                }
                else if (comboBox1.SelectedIndex == 1) // 
                {
                    string firma1 = textfirma1.Text.Trim();
                    int tsena1 = Convert.ToInt32(texttsena1.Text.Trim());
                    int volume = int.Parse(textvolume.Text);
                    int power1 = int.Parse(textpower1.Text);
                    newBittech = new Holodilnik(firma1, tsena1, volume, power1);
                }

                if (newBittech != null)
                {
                    Bittech.Add(newBittech);
                    UpdateEquipmentList();
                    MessageBox.Show("Устройство добавлено успешно!", "Информация");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении устройства. Выберите корректный тип устройства.", "Ошибка");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных. Проверьте введённые значения.", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Bittech.Clear();
            UpdateEquipmentList();
        }

        private void UpdateEquipmentList()
        {
            bittechList.Items.Clear();
            foreach (var device in Bittech)
            {
                bittechList.Items.Add(device.PrintInfo());
            }
        }

        private void ClearFields()
        {
            textfirma.Clear();
            texttsena1.Clear();
            textvolume.Clear();
            textpower1.Clear();
            textfirma1.Clear();
            texttsena.Clear();
            textpower.Clear();
            textcolor.Clear();
        }

        private void comptech_select_SelectedIndexChanged(object sender, EventArgs e)
        {   
            mikrpech.Enabled = comboBox1.SelectedIndex == 0;
            holodBox.Enabled = comboBox1.SelectedIndex == 1;
        }
    
    }
    public class Bittech
    {
        private string firma;
        private int tsena;
        public string Firma
        {
            get { return firma; }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Введено некорректное значение фирмы. ");
                }
                else
                {
                    firma = value;
                }
            }
        }
        public int Tsena
        {
            get { return tsena; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Цена указана неверно.\n");
                }
                else { tsena = value; }
            }
        }
        public Bittech(string fir = "Firma", int tsen = 9000)
        {
            Firma = fir;
            Tsena = tsen;
        }

        public virtual string PrintInfo()
        {
            return Firma + Tsena.ToString();
        }

    }
    public class Mikrpech : Bittech
    {
        private string color;
        private int power;
        public string Color
        {
            get { return color; }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Введено некорректное значение цвета. ");
                }
                else
                {
                    color = value;
                }
            }
        }
        public int Power
        {
            get { return power; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Мощность указана неверно.\n");
                }
                else
                { power = value; }
            }
        }
        public Mikrpech(string fir = "Dexp", int tsen = 10000, string col = "белый", int power = 700)
        {
            Firma = fir;
            Tsena = tsen;
            Power = power;
            Color = col;

        }

        public override string PrintInfo()
        {
            return $"Фирма: {Firma} Цена: {Tsena} Цвет: {Color} Мощность: {Power}";
        }
    }
    public class Holodilnik : Bittech
    {
        private int volume;
        private int power;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Объем указан неверно.\n");
                }
                else
                {
                    volume = value;
                }
            }
        }
        public int Power
        {
            get { return power; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Мощность указана неверно.\n");
                }
                else { power = value; }
            }
        }
        public Holodilnik(string fir = "Samsung", int tsen = 10000, int volume = 100, int power = 700)
        {
            Firma = fir;
            Tsena = tsen;
            Volume = volume;
            Power = power;
        }

        public override string PrintInfo()
        {
            return $"Фирма: {Firma} Цена: {Tsena} Объем: {Volume} Мощность: {Power}";
        }
    }

}