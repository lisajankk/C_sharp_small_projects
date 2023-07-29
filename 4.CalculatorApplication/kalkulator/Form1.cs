using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace kalkulator
{
    public partial class Form1 : Form
    {
        private Rectangle jedenButtonOriginalRectangle;
        private Rectangle dwaButtonOriginalRectangle;
        private Rectangle trzyButtonOriginalRectangle;
        private Rectangle czteryButtonOriginalRectangle;
        private Rectangle piecButtonOriginalRectangle;
        private Rectangle szescButtonOriginalRectangle;
        private Rectangle siedemButtonOriginalRectangle;
        private Rectangle osiemButtonOriginalRectangle;
        private Rectangle dziewiecButtonOriginalRectangle;
        private Rectangle zeroButtonOriginalRectangle;
        private Rectangle dodawanieButtonOriginalRectangle;
        private Rectangle odejmowanieButtonOriginalRectangle;
        private Rectangle dzielenieButtonOriginalRectangle;
        private Rectangle mnozenieButtonOriginalRectangle;
        private Rectangle rownosieButtonOriginalRectangle;
        private Rectangle kasowanieButtonOriginalRectangle;
        private Rectangle cofanieButtonOriginalRectangle;
        private Rectangle analogClkButtonOriginalRectangle;
        private Rectangle digitalClkButtonOriginalRectangle;
        private Rectangle wyswietlZegarButtonOriginalRectangle;
        private Rectangle czarnyButtonOriginalRectangle;
        private Rectangle bialyButtonOriginalRectangle;
        private Rectangle niebieskiButtonOriginalRectangle;
        private Rectangle wybierzKolorButtonOriginalRectangle;
        private Rectangle wybierzObrazButtonOriginalRectangle;
        private Rectangle CalculatorDisplayButtonOriginalRectangle;
        private Rectangle separatorButtonOriginalRectangle;
        private Rectangle pierwiastekButtonOriginalRectangle;
        private Rectangle negacjaButtonOriginalRectangle;
        private Rectangle picbox1OriginalRectangle;
        private Rectangle picbox2OriginalRectangle;
        private Rectangle picbox3OriginalRectangle;
        private Rectangle picbox4OriginalRectangle;
        private Size originalFormSize;

        // interface
        Bitmap clock, hour, minute, second;
        public Form1()
        {
            InitializeComponent();
            clock = new Bitmap(".\\clock.png");
            hour = new Bitmap(".\\hour.png");
            minute = new Bitmap(".\\minute.png");
            second = new Bitmap(".\\second.png");
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            jedenButtonOriginalRectangle = new Rectangle(jeden.Location.X, jeden.Location.Y, jeden.Width, jeden.Height);
            dwaButtonOriginalRectangle = new Rectangle(dwa.Location.X, dwa.Location.Y, dwa.Width, dwa.Height);
            trzyButtonOriginalRectangle = new Rectangle(trzy.Location.X, trzy.Location.Y, trzy.Width, trzy.Height);
            czteryButtonOriginalRectangle = new Rectangle(cztery.Location.X, cztery.Location.Y, cztery.Width, cztery.Height);
            piecButtonOriginalRectangle = new Rectangle(piec.Location.X, piec.Location.Y, piec.Width, piec.Height);
            szescButtonOriginalRectangle = new Rectangle(szesc.Location.X, szesc.Location.Y, szesc.Width, szesc.Height);
            siedemButtonOriginalRectangle = new Rectangle(siedem.Location.X, siedem.Location.Y, siedem.Width, siedem.Height);
            osiemButtonOriginalRectangle = new Rectangle(osiem.Location.X, osiem.Location.Y, osiem.Width, osiem.Height);
            dziewiecButtonOriginalRectangle = new Rectangle(dziewiec.Location.X, dziewiec.Location.Y, dziewiec.Width, dziewiec.Height);
            zeroButtonOriginalRectangle = new Rectangle(zero.Location.X, zero.Location.Y, zero.Width, zero.Height);
            dodawanieButtonOriginalRectangle = new Rectangle(dodawanie.Location.X, dodawanie.Location.Y, dodawanie.Width, dodawanie.Height);
            odejmowanieButtonOriginalRectangle = new Rectangle(odejmowanie.Location.X, odejmowanie.Location.Y, odejmowanie.Width, odejmowanie.Height);
            dzielenieButtonOriginalRectangle = new Rectangle(dzielenie.Location.X, dzielenie.Location.Y, dzielenie.Width, dzielenie.Height);
            mnozenieButtonOriginalRectangle = new Rectangle(mnozenie.Location.X, mnozenie.Location.Y, mnozenie.Width, mnozenie.Height);
            rownosieButtonOriginalRectangle = new Rectangle(rownosie.Location.X, rownosie.Location.Y, rownosie.Width, rownosie.Height);
            kasowanieButtonOriginalRectangle = new Rectangle(kasowanie.Location.X, kasowanie.Location.Y, kasowanie.Width, kasowanie.Height);
            cofanieButtonOriginalRectangle = new Rectangle(cofanie.Location.X, cofanie.Location.Y, cofanie.Width, cofanie.Height);
            analogClkButtonOriginalRectangle = new Rectangle(analogClk.Location.X, analogClk.Location.Y, analogClk.Width, analogClk.Height);
            digitalClkButtonOriginalRectangle = new Rectangle(digitalClk.Location.X, digitalClk.Location.Y, digitalClk.Width, digitalClk.Height);
            wyswietlZegarButtonOriginalRectangle = new Rectangle(wyswietlZegar.Location.X, wyswietlZegar.Location.Y, wyswietlZegar.Width, wyswietlZegar.Height);
            czarnyButtonOriginalRectangle = new Rectangle(czarny.Location.X, czarny.Location.Y, czarny.Width, czarny.Height);
            bialyButtonOriginalRectangle = new Rectangle(bialy.Location.X, bialy.Location.Y, bialy.Width, bialy.Height);
            niebieskiButtonOriginalRectangle = new Rectangle(niebieski.Location.X, niebieski.Location.Y, niebieski.Width, niebieski.Height);
            wybierzKolorButtonOriginalRectangle = new Rectangle(wybierzKolor.Location.X, wybierzKolor.Location.Y, wybierzKolor.Width, wybierzKolor.Height);
            wybierzObrazButtonOriginalRectangle = new Rectangle(wybierzObraz.Location.X, wybierzObraz.Location.Y, wybierzObraz.Width, wybierzObraz.Height);
            CalculatorDisplayButtonOriginalRectangle = new Rectangle(CalculatorDisplay.Location.X, CalculatorDisplay.Location.Y, CalculatorDisplay.Width, CalculatorDisplay.Height);
            separatorButtonOriginalRectangle = new Rectangle(separator.Location.X, separator.Location.Y, separator.Width, separator.Height);
            pierwiastekButtonOriginalRectangle = new Rectangle(pierwiastek.Location.X, pierwiastek.Location.Y, pierwiastek.Width, pierwiastek.Height);
            negacjaButtonOriginalRectangle = new Rectangle(negacja.Location.X, negacja.Location.Y, negacja.Width, negacja.Height);
            picbox1OriginalRectangle = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
            picbox2OriginalRectangle = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width, pictureBox2.Height);
            picbox3OriginalRectangle = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Width, pictureBox3.Height);
            picbox4OriginalRectangle = new Rectangle(pictureBox4.Location.X, pictureBox4.Location.Y, pictureBox4.Width, pictureBox4.Height);
        }

        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(jedenButtonOriginalRectangle, jeden);
            resizeControl(dwaButtonOriginalRectangle, dwa);
            resizeControl(trzyButtonOriginalRectangle, trzy);
            resizeControl(czteryButtonOriginalRectangle, cztery);
            resizeControl(piecButtonOriginalRectangle, piec);
            resizeControl(szescButtonOriginalRectangle, szesc);
            resizeControl(siedemButtonOriginalRectangle, siedem);
            resizeControl(osiemButtonOriginalRectangle, osiem);
            resizeControl(dziewiecButtonOriginalRectangle, dziewiec);
            resizeControl(zeroButtonOriginalRectangle, zero);
            resizeControl(dodawanieButtonOriginalRectangle, dodawanie);
            resizeControl(odejmowanieButtonOriginalRectangle, odejmowanie);
            resizeControl(dzielenieButtonOriginalRectangle, dzielenie);
            resizeControl(mnozenieButtonOriginalRectangle, mnozenie);
            resizeControl(rownosieButtonOriginalRectangle, rownosie);
            resizeControl(kasowanieButtonOriginalRectangle, kasowanie);
            resizeControl(cofanieButtonOriginalRectangle, cofanie);
            resizeControl(analogClkButtonOriginalRectangle, analogClk);
            resizeControl(digitalClkButtonOriginalRectangle, digitalClk);
            resizeControl(wyswietlZegarButtonOriginalRectangle, wyswietlZegar);
            resizeControl(czarnyButtonOriginalRectangle, czarny);
            resizeControl(bialyButtonOriginalRectangle, bialy);
            resizeControl(niebieskiButtonOriginalRectangle, niebieski);
            resizeControl(wybierzKolorButtonOriginalRectangle, wybierzKolor);
            resizeControl(wybierzObrazButtonOriginalRectangle, wybierzObraz);
            resizeControl(CalculatorDisplayButtonOriginalRectangle, CalculatorDisplay);
            resizeControl(separatorButtonOriginalRectangle, separator);
            resizeControl(pierwiastekButtonOriginalRectangle, pierwiastek);
            resizeControl(negacjaButtonOriginalRectangle, negacja);

            resizeControl(picbox1OriginalRectangle, pictureBox1);
            resizeControl(picbox2OriginalRectangle, pictureBox2);
            resizeControl(picbox3OriginalRectangle, pictureBox3);
            resizeControl(picbox4OriginalRectangle, pictureBox4);
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        float num1, num2, result, negnum;
        char operation;
        bool dec = false;
        bool neg = false;

        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in CalculatorDisplay.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    CalculatorDisplay.Text = CalculatorDisplay.Text + ".";
                }
                dec = false;
            }
            else
            {
                if (CalculatorDisplay.Text.Equals("0") == true && CalculatorDisplay.Text != null)
                {
                    CalculatorDisplay.Text = numPressed.ToString();
                }
                else if (CalculatorDisplay.Text.Equals("-0") == true)
                {
                    CalculatorDisplay.Text = "-" + numPressed.ToString();
                }
                else if (CalculatorDisplay.Text.Equals("NaN") == true)
                {
                    CalculatorDisplay.Text = numPressed.ToString();
                }
                else
                {
                    CalculatorDisplay.Text = CalculatorDisplay.Text + numPressed.ToString();
                }
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }

        private void num1_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(CalculatorDisplay.Text);
            operation = '+';
            result = result + num1;
            CalculatorDisplay.Text = "";
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(CalculatorDisplay.Text);
            operation = '-';
            result = result - num1;
            CalculatorDisplay.Text = "";
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(CalculatorDisplay.Text);
            operation = '*';
            result = result * num1;
            CalculatorDisplay.Text = "";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(CalculatorDisplay.Text);
            operation = '/';
            result = result / num1;
            CalculatorDisplay.Text = "";
        }

        private void rowno_sie_Click(object sender, EventArgs e)
        { result = 0;
            //if(CalculatorDisplay.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(CalculatorDisplay.Text);
                        result = num1 + num2;
                        CalculatorDisplay.Text = result.ToString();
                        break;
                    case '-':
                        num2 = float.Parse(CalculatorDisplay.Text);
                        result = num1 - num2;
                        CalculatorDisplay.Text = result.ToString();
                        break;
                    case '*':
                        num2 = float.Parse(CalculatorDisplay.Text);
                        result = num1 * num2;
                        CalculatorDisplay.Text = result.ToString();
                        break;
                    case '/':
                        num2 = float.Parse(CalculatorDisplay.Text);

                        if (num2 == 0)
                        {
                            CalculatorDisplay.Text = "NaN";
                        }
                        else
                        {
                            result = num1 / num2;
                            CalculatorDisplay.Text = result.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            //CalculatorDisplay.Text = result.ToString();
        }

        private void separator_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLabel(0);
        }

        private void negacja_Click(object sender, EventArgs e)
        {
            if (neg == true || result < 0)
            {
                negnum = float.Parse(CalculatorDisplay.Text);
                negnum = negnum * (-1);
                CalculatorDisplay.Text = negnum.ToString();
                neg = false;
            }
            else
            {
                CalculatorDisplay.Text = "-" + CalculatorDisplay.Text;
                neg = true;
            }
        }

        private void pierwiastek_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(CalculatorDisplay.Text);
            if(num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                CalculatorDisplay.Text = sqrt.ToString();
            }
        }

        private void kolor_czarny_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.BackgroundImage = null;
        }

        private void kolor_bialy_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.BackgroundImage = null;
        }

        private void kolor_niebieski_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            this.BackgroundImage = null;
        }

        private void wybierz_kolor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
                this.BackgroundImage = null;
            }
        }

        private void wybierz_background_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK )
            {
                this.BackgroundImage = new Bitmap(openFileDialog.FileName);
            }
        }

        private void kasowanie_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            int stringLength = CalculatorDisplay.Text.Length;
            if(stringLength > 1)
            {
                CalculatorDisplay.Text = CalculatorDisplay.Text.Substring(0, stringLength - 1);
            }
            else
            {
                CalculatorDisplay.Text = "0";
            }
        }

        bool digital = true;
        private void zegar_analogowy_Click(object sender, EventArgs e)
        {
            digital = false;
        }

        private void zegar_cyfrowy_Click(object sender, EventArgs e)
        {
            digital = true;
        }

        private void Wynik(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    jeden.PerformClick();
                    break;
                case Keys.D1:
                    jeden.PerformClick();
                    break;

                case Keys.NumPad2:
                    dwa.PerformClick();
                    break;
                case Keys.D2:
                    dwa.PerformClick();
                    break;

                case Keys.NumPad3:
                    trzy.PerformClick();
                    break;
                case Keys.D3:
                    trzy.PerformClick();
                    break;

                case Keys.NumPad4:
                    cztery.PerformClick();
                    break;
                case Keys.D4:
                    cztery.PerformClick();
                    break;

                case Keys.NumPad5:
                    piec.PerformClick();
                    break;
                case Keys.D5:
                    piec.PerformClick();
                    break;

                case Keys.NumPad6:
                    szesc.PerformClick();
                    break;
                case Keys.D6:
                    szesc.PerformClick();
                    break;

                case Keys.NumPad7:
                    siedem.PerformClick();
                    break;
                case Keys.D7:
                    siedem.PerformClick();
                    break;

                case Keys.NumPad8:
                    osiem.PerformClick();
                    break;
                case Keys.D8:
                    osiem.PerformClick();
                    break;

                case Keys.NumPad9:
                    dziewiec.PerformClick();
                    break;
                case Keys.D9:
                    dziewiec.PerformClick();
                    break;

                case Keys.NumPad0:////////
                    zero.PerformClick();
                    break;
                case Keys.D0:
                    zero.PerformClick();
                    break;

                case Keys.Divide:
                    dzielenie.PerformClick();
                    break;
                case Keys.Multiply:
                    mnozenie.PerformClick();
                    break;
                case Keys.Subtract:
                    odejmowanie.PerformClick();
                    break;
                case Keys.Add:
                    dodawanie.PerformClick();
                    break;
                default:
                    break;

            }
        }

        // time;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (digital == true)
            {
                this.wyswietlZegar.Text = DateTime.Now.ToString("HH:mm:ss");
                this.wyswietlZegar.Show();
                this.pictureBox1.Hide();
                this.pictureBox2.Hide();
                this.pictureBox3.Hide();
                this.pictureBox4.Hide();
            }
            else
            {
                DateTime now = DateTime.Now;
                int Hour = now.Hour;
                int Minute = now.Minute;
                int Second = now.Second;
                this.wyswietlZegar.Hide();
                this.pictureBox1.Show();
                this.pictureBox2.Show();
                this.pictureBox3.Show();
                this.pictureBox4.Show();
                Single AngleS = Second * 6;
                Single AngleM = Minute * 6 + AngleS/60;
                Single AngleH = Hour * 30 + AngleM/12;

                pictureBox1.Image = clock;
                pictureBox1.Controls.Add(pictureBox2);
                pictureBox2.Location = new Point(18, 17);
                pictureBox2.Image = rotateImage(hour, AngleH);
                pictureBox2.Controls.Add(pictureBox3);
                pictureBox3.Location = new Point(-1, 0);
                pictureBox3.Image = rotateImage(minute, AngleM);
                pictureBox3.Controls.Add(pictureBox4);
                pictureBox4.Location = new Point(0, 1);
                pictureBox4.Image = rotateImage(second, AngleS);

            }
        }

        private Bitmap rotateImage(Bitmap rotim, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotim.Width, rotim.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotim.Width/3, rotim.Height/3);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotim.Width/3, -rotim.Height/3);
                g.DrawImage(rotim, new Point(0, 0));
            }
            return rotatedImage;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    rownosie.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void wyswietl_zegar_cyfrowy(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
