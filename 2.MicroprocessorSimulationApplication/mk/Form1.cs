using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace mk
{
    public partial class Form1 : Form
    {
        int step = 0;
        bool pierwszy_r = false;
        bool drugi_r = false;
        bool liczba = false;
        bool instr = false;
        int linijka = 0;
        bool nowa_linija = false;
        int convert_number = 0;
        int reszta = 0;
        int numeracja_l = 1;
        int edytuj_l = 0;
        string newLine = Environment.NewLine;
        string binary_num;

        bool dodaj = false;
        bool odejmij = false;
        bool przesun = false;
        bool przekroczono_zakr = false;

        int r = 0;

        int axx = 0;
        int bxx = 0;
        int cxx = 0;
        int dxx = 0;
        bool h_mode = false;
        bool s_mode = false;
        int r1_to_r2 = 0;
        bool edytowanie;
        string jeden = "";
        string dwa = "";
        string edytowana_l = "";

        List<String> step_wynik = new List<String>();
        List<String> step_komenda = new List<String>();

        List<String> ins = new List<String>();
        List<String> reg1 = new List<String>();
        List<String> reg2 = new List<String>();
        List<int> licz3 = new List<int>();
        List<bool> r2 =  new List<bool>();
        List<bool> li = new List<bool>();
        List<int> reszt = new List<int>();



        public Form1()
        {
            InitializeComponent();
            numeracja_linii.Text = numeracja_linii.Text + numeracja_l.ToString() + newLine;
            string Dir = Environment.CurrentDirectory;
            openFileDialog1.InitialDirectory = Dir; // @"C:\";
        }

        private void reset()
        {
            step = 0;
            pierwszy_r = false;
            drugi_r = false;
            liczba = false;
            instr = false;
            linijka = 0;
            nowa_linija = false;
            convert_number = 0;
            reszta = 0;
            numeracja_l = 1;
            edytuj_l = 0;
            step_komenda.Clear();
            step_wynik.Clear();
            binary_num = "";

            dodaj = false;
            odejmij = false;
            przesun = false;
            przekroczono_zakr = false;

            r = 0;

            axx = 0;
            bxx = 0;
            cxx = 0;
            dxx = 0;
            h_mode = false;
            s_mode = false;
            r1_to_r2 = 0;
            edytowanie = false;
            jeden = "";
            dwa = "";
            edytowana_l = "";

            ins.Clear();
            reg1.Clear();
            reg2.Clear();
            licz3.Clear();
            r2.Clear();
            li.Clear();
            reszt.Clear();

            numeracja_linii.Text = numeracja_l.ToString() + newLine;
            instrukcje.Text = "";
            wpisz_do_rejestru(ah, al, 0);
            wpisz_do_rejestru(bh, bl, 0);
            wpisz_do_rejestru(ch, cl, 0);
            wpisz_do_rejestru(dh, dl, 0);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rozkaz_SelectedIndexChanged(object sender, EventArgs e)
        {
            uwagi.Text = "Wybrano instrukcję";
            if(edytowanie == false)
            {
                instrukcje.Text = instrukcje.Text.Substring(0, 0 + linijka);
                instrukcje.Text = instrukcje.Text + rozkaz.Text + " ";
                instr = true;
            }
            if(edytowanie == true)
            {
                edytowana_l = rozkaz.Text + " ";
            }

            switch (rozkaz.Text)
            {
                case "mov":
                    przesun = true;

                    break;
                case "add":
                    dodaj = true;
                    break;
                case "sub":
                    odejmij = true;
                    break;
                default:
                    break;
            }

        }

        private void register1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instr == true)
            {
                if (edytowanie == false)
                {
                    if (pierwszy_r == false)
                    {
                        instrukcje.Text = instrukcje.Text + register1.Text + ", ";
                        pierwszy_r = true;
                    }
                    else
                    {
                        instrukcje.Text = instrukcje.Text.Substring(0, 4 + linijka);
                        instrukcje.Text = instrukcje.Text + register1.Text + ", ";
                    }
                }

                if (edytowanie == true)
                {
                    edytowana_l = edytowana_l + register1.Text + ", ";
                }
                uwagi.Text = "Wybrano rejestr";
            }



        }

        private void register2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pierwszy_r == true)
            {
                if(edytowanie == false)
                {
                    if (drugi_r == false)
                    {
                        instrukcje.Text = instrukcje.Text + register2.Text;
                        nowa_linija = true;
                        drugi_r = true;
                        reszta = 2;
                    }
                    else
                    {
                        instrukcje.Text = instrukcje.Text.Substring(0, 8 + linijka);
                        instrukcje.Text = instrukcje.Text + register2.Text;
                        nowa_linija = true;
                        reszta = 2;
                    }
                }             

                if (edytowanie == true)
                {
                    edytowana_l = edytowana_l + register1.Text + register2.Text;
                    reszta = 2;
                }
                uwagi.Text = "Wybrano rejestr, możesz również podać liczbę";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void wykonaj_przesuniecie(bool rej2, bool liczb, string r1, string r2, int l3)
        {
            if (rej2 == true)
            {
                switch (r2)
                {
                    case "ax":
                        r1_to_r2 = axx;
                        break;
                    case "bx":
                        r1_to_r2 = bxx;
                        break;
                    case "cx":
                        r1_to_r2 = cxx;
                        break;
                    case "dx":
                        r1_to_r2 = dxx;
                        break;
                    default:
                        break;
                }
            }
            if (liczb == true)
            {
                r1_to_r2 = l3;
            }
            switch (r1)
            {
                case "ax":
                    axx = r1_to_r2;
                    step_wynik.Add(axx.ToString());
                    step_komenda.Add("1");
                    break;
                case "bx":
                    bxx = r1_to_r2;
                    step_wynik.Add(bxx.ToString());
                    step_komenda.Add("2");
                    break;
                case "cx":
                    cxx = r1_to_r2;
                    step_wynik.Add(cxx.ToString());
                    step_komenda.Add("3");
                    break;
                case "dx":
                    dxx = r1_to_r2;
                    step_wynik.Add(dxx.ToString());
                    step_komenda.Add("4");
                    break;
                default:
                    break;
            }
            przesun = false;
        }

        private void wykonaj_dodawanie(bool rej2, bool liczb, string r1, string r2, int l3)
        {
            // jesli drugi_r == true
            if (rej2 == true)
            {
                switch (r2)
                {
                    case "ax":
                        r1_to_r2 = axx;
                        break;
                    case "bx":
                        r1_to_r2 = bxx;
                        break;
                    case "cx":
                        r1_to_r2 = cxx;
                        break;
                    case "dx":
                        r1_to_r2 = dxx;
                        break;
                    default:
                        break;
                }
            }
            // jesli liczba == true
            if (liczb == true)
            {                
                r1_to_r2 = l3; // l3 == convert_number!!!!!!!!!!!
            }

            switch (r1)
            {
                case "ax":
                    if ((axx + r1_to_r2) < 65536 && (axx + r1_to_r2) >= 0)
                    {
                        axx = axx + r1_to_r2;
                        step_wynik.Add(axx.ToString());
                        step_komenda.Add("1");
                        //wpisz_do_rejestru(ah, al, axx);
                    }
                    else przekroczono_zakres();
                    break;
                case "bx":
                    if ((bxx + r1_to_r2) < 65536 && (bxx + r1_to_r2) >= 0)
                    {
                        bxx = bxx + r1_to_r2;
                        step_wynik.Add(bxx.ToString());
                        step_komenda.Add("2");
                        //wpisz_do_rejestru(bh, bl, bxx);
                    }
                    else przekroczono_zakres();
                    break;
                case "cx":
                    if ((bxx + r1_to_r2) < 65536 && (bxx + r1_to_r2) >= 0)
                    {
                        cxx = cxx + r1_to_r2;
                        step_wynik.Add(cxx.ToString());
                        step_komenda.Add("3");
                        //wpisz_do_rejestru(ch, cl, cxx);
                    }
                    else przekroczono_zakres();
                    break;
                case "dx":
                    if ((bxx + r1_to_r2) < 65536 && (bxx + r1_to_r2) >= 0)
                    {
                        dxx = dxx + r1_to_r2;
                        step_wynik.Add(dxx.ToString());
                        step_komenda.Add("4");
                        //wpisz_do_rejestru(dh, dl, dxx);
                    }
                    else przekroczono_zakres();
                    break;
                default:
                    break;
            }

            if (przekroczono_zakr == false)
            {
                dodaj = false;
            }

        }

        private void wykonaj_odejmowanie(bool rej2, bool liczb, string r1, string r2, int l3)
        {
            if (rej2 == true)
            {
                switch (r2)
                {
                    case "ax":
                        r1_to_r2 = axx;
                        break;
                    case "bx":
                        r1_to_r2 = bxx;
                        break;
                    case "cx":
                        r1_to_r2 = cxx;
                        break;
                    case "dx":
                        r1_to_r2 = dxx;
                        break;
                    default:
                        break;
                }
            }

            if (liczb == true)
            {
                r1_to_r2 = l3;
            }

            switch (r1)
            {
                case "ax":
                    if ((axx - r1_to_r2) >= 0)
                    {
                        axx = axx - r1_to_r2;
                        step_wynik.Add(axx.ToString());
                        step_komenda.Add("1");
                        //wpisz_do_rejestru(ah, al, axx);
                    }
                    else ujemny_zakres();
                    break;
                case "bx":
                    if ((bxx - r1_to_r2) >= 0)
                    {
                        bxx = bxx - r1_to_r2;
                        step_wynik.Add(bxx.ToString());
                        step_komenda.Add("2");
                        //wpisz_do_rejestru(bh, bl, bxx);
                    }
                    else ujemny_zakres();
                    break;
                case "cx":
                    if ((bxx - r1_to_r2) >= 0)
                    {
                        cxx = cxx - r1_to_r2;
                        step_wynik.Add(cxx.ToString());
                        step_komenda.Add("3");
                       // wpisz_do_rejestru(ch, cl, cxx);
                    }
                    else ujemny_zakres();
                    break;
                case "dx":
                    if ((bxx - r1_to_r2) >= 0)
                    {
                        dxx = dxx - r1_to_r2;
                        step_wynik.Add(dxx.ToString());
                        step_komenda.Add("4");
                        //wpisz_do_rejestru(dh, dl, dxx);
                    }
                    else ujemny_zakres();
                    break;
                default:
                    break;
            }

            if (przekroczono_zakr == false)
            {
                odejmij = false;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (nowa_linija == true && instr == true && pierwszy_r == true && (drugi_r == true || liczba == true))
            {
                if (edytowanie == true)
                {

                    //ins[]=rozkaz.Text;
                    //reg1[]=register1.Text;

                    if (drugi_r == true)
                    {
                        //reg2[]=register2.Text;
                       // licz3[]=0;
                        //r2[]=true;
                       // li[]=false;
                    }
                    else if (liczba == true)
                    {
                       // licz3[]=convert_number;
                       // reg2[]="0";
                       // //r2[]=false;
                       // li[]=true;
                    }

                    instrukcje.Text = jeden + newLine + edytowana_l + newLine + dwa;

                    linijka = linijka + 10 + reszta;////////
                    reszt.Add(linijka);////////////

                    wykonaj_obliczenia();
                    instr = false;
                    pierwszy_r = false;
                    drugi_r = false;
                    liczba = false;
                    reszta = 0;

                    jeden = "";
                    dwa = "";
                    edytowanie = false;

                }
                if(edytowanie == false)
                {
                    ins.Add(rozkaz.Text);
                    reg1.Add(register1.Text);

                    if (drugi_r == true)
                    {
                        reg2.Add(register2.Text);
                        licz3.Add(0);
                        r2.Add(true);
                        li.Add(false);
                    }
                    else if (liczba == true)
                    {
                        licz3.Add(convert_number);
                        reg2.Add("0");
                        r2.Add(false);
                        li.Add(true);
                    }

                    if (przesun == true)
                    {
                        wykonaj_przesuniecie(drugi_r, liczba, register1.Text, register2.Text, convert_number);
                    }

                    if (dodaj == true)
                    {
                        wykonaj_dodawanie(drugi_r, liczba, register1.Text, register2.Text, convert_number);
                    }

                    if (odejmij == true)
                    {
                        wykonaj_odejmowanie(drugi_r, liczba, register1.Text, register2.Text, convert_number);
                    }

                    if (przekroczono_zakr == false)
                    {
                        instrukcje.AppendText(Environment.NewLine);
                        nowa_linija = false;
                        linijka = linijka + 10 + reszta;
                        reszt.Add(linijka);
                        r++;

                        instr = false;
                        pierwszy_r = false;
                        drugi_r = false;
                        liczba = false;
                        reszta = 0;

                        numeracja_l++;
                        numeracja_linii.Text = numeracja_linii.Text + numeracja_l.ToString() + newLine;
                    }
                    else
                    {
                        instrukcje.Text = instrukcje.Text.Substring(0, 8 + linijka - 8);
                        nowa_linija = false;
                        dodaj = false;
                        odejmij = false;
                        przesun = false;

                        instr = false;
                        pierwszy_r = false;
                        drugi_r = false;
                        liczba = false;
                        reszta = 0;

                        przekroczono_zakr = false;
                    }
                }                
            }
        }

        private void wpisz_do_rejestru(Label h, Label l, int wyn)
        {
            binary_num = Convert.ToString(wyn, 2);
            binary_num = binary_num.PadLeft(16, '0');

            int chunkSize = 8;
            int stringLength = binary_num.Length;
            for (int i = 0; i < stringLength; i += chunkSize)// petla wykonuje sie 2 razy
            {
                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
                {
                    if (i == 0 & (h_mode == true || s_mode == true))
                    { h.Text = (binary_num.Substring(i, chunkSize)); }

                    if (i == chunkSize & (h_mode == true || s_mode == true))
                    { l.Text = (binary_num.Substring(i, chunkSize)); }
                }
            }
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            uwagi.Text = "Możesz wpisać jedynie liczby z zakresu [0, 65535]";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (drugi_r != true)
            {
                try
                {
                    convert_number = Convert.ToInt32(this.number.Text);
                    if (convert_number < 65536 && convert_number >= 0) //256*256 = 65,536 czyli convert_number < 65,535
                    {
                        if (pierwszy_r == true)
                        {
                            if(edytowanie == false)
                            {
                                if (liczba == false)
                                {
                                    instrukcje.Text = instrukcje.Text + number.Text;
                                    liczba = true;
                                    nowa_linija = true;
                                    reszta = convert_number.ToString().Length;
                                }
                                else
                                {
                                    instrukcje.Text = instrukcje.Text.Substring(0, 8 + linijka);////////////////
                                    instrukcje.Text = instrukcje.Text + number.Text;
                                    nowa_linija = true;
                                    reszta = convert_number.ToString().Length;
                                }
                            }

                            if (edytowanie == true)
                            {
                                edytowana_l = edytowana_l + number.Text;
                                reszta = convert_number.ToString().Length;
                                //instrukcje.Text = instrukcje.Text.Substring(0, 8 + linijka);
                                //instrukcje.Text = instrukcje.Text.Substring(0, 8 + linijka);
                            }
                        }
                    }
                    else
                    {
                        uwagi.Text = "Możesz wpisać jedynie liczby z zakresu [0, 65535]";
                    }
                }
                catch (FormatException)
                {
                    uwagi.Text = "NIEPOPRAWNY FORMAT!";
                    instrukcje.Text = instrukcje.Text.Substring(0, 8);
                }
            }

        }

        private void przekroczono_zakres()
        {
            uwagi.Text = "PRZEKROCZONO ZAKRES! Spróbuj ponownie!";
            przekroczono_zakr = true;
        }

        private void ujemny_zakres()
        {
            uwagi.Text = "WYNIK NIE MOŻE BYĆ UJEMNY! Spróbuj ponownie!";
            przekroczono_zakr = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void zresetuj_Click(object sender, EventArgs e)
        {
            instrukcje.Text = instrukcje.Text.Substring(0, 0);
            reset();
            uwagi.Text = "Zresetowano urządzenie";

        }

        private void step_mode_Click(object sender, EventArgs e)
        {
            s_mode = true;
            try
            {   uwagi.Text = "Wykonywano tryb STEP MODE. " +
                    "Aby kontynuować program, zakończ tryb";
                
                if (step == 0)
                {
                    wpisz_do_rejestru(ah, al, 0);
                    wpisz_do_rejestru(bh, bl, 0);
                    wpisz_do_rejestru(ch, cl, 0);
                    wpisz_do_rejestru(dh, dl, 0);
                    wykonaj_obliczenia();
                }       
            
                if (step < numeracja_l-1)
                {
                    aktualna_lin.Text = (step+1).ToString();
                    int wynik = Convert.ToInt32(this.step_wynik[step]);

                    switch (step_komenda[step])
                    {
                        case "1":
                            wpisz_do_rejestru(ah, al, wynik);
                            break;
                        case "2":
                            wpisz_do_rejestru(bh, bl, wynik);
                            break;
                        case "3":
                            wpisz_do_rejestru(ch, cl, wynik);
                            break;
                        case "4":
                            wpisz_do_rejestru(dh, dl, wynik);
                            break;
                        default:
                            break;
                    }
                    step++;
                    {
                        confirm.Click -= confirm_Click;
                        holistic_mode.Click -= holistic_mode_Click;
                        button4.Click -= button4_Click;
                        zresetuj.Click -= zresetuj_Click;
                        rozkaz.Enabled = false;
                        register1.Enabled = false;
                        register2.Enabled = false;
                    } // blokowanie możliwości naciśnięcia innych przycisków
                }
                else
                {
                    {
                        confirm.Click += confirm_Click;
                        holistic_mode.Click += holistic_mode_Click;
                        button4.Click += button4_Click;
                        zresetuj.Click += zresetuj_Click;
                        rozkaz.Enabled = true;
                        register1.Enabled = true;
                        register2.Enabled = true;
                        step = 0;
                        aktualna_lin.Text = "x";
                        uwagi.Text = "Zakończono tryb STEP MODE";
                    } // wyzwalanie przycisków
                } // wyzwalanie przycisków
            }
            catch (FormatException)
            {
                uwagi.Text = "Niewporawdzono żadnej instrukcji!";
                instrukcje.Text = instrukcje.Text.Substring(0, 8);
            }
            s_mode = false;
        }

        private void holistic_mode_Click(object sender, EventArgs e)
        {
            h_mode = true;
            try
            {   uwagi.Text = "Wykonano tryb HOLISTIC MODE";
                int wynik;
                wykonaj_obliczenia();
                wpisz_do_rejestru(ah, al, 0);
                wpisz_do_rejestru(bh, bl, 0);
                wpisz_do_rejestru(ch, cl, 0);
                wpisz_do_rejestru(dh, dl, 0);
                wykonaj_obliczenia();

                for (int i = 0; i < numeracja_l - 1; i++)
                {                    
                    wynik = Convert.ToInt32(this.step_wynik[i]);
                    switch (step_komenda[i])
                    {
                        case "1":
                            wpisz_do_rejestru(ah, al, wynik);
                            break;
                        case "2":
                            wpisz_do_rejestru(bh, bl, wynik);
                            break;
                        case "3":
                            wpisz_do_rejestru(ch, cl, wynik);
                            break;
                        case "4":
                            wpisz_do_rejestru(dh, dl, wynik);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                uwagi.Text = "Nie wporawdzono żadnej instrukcji!";
                instrukcje.Text = instrukcje.Text.Substring(0, 8);
            }
            h_mode = false;
        }

        private void wykonaj_obliczenia()
        {
            step_komenda.Clear();
            step_wynik.Clear();
            for (int i = 0; i < numeracja_l - 1; i++)
            {
                switch (ins[i])
                {
                    case "mov":
                        przesun = true;
                        break;
                    case "add":
                        dodaj = true;
                        break;
                    case "sub":
                        odejmij = true;
                        break;
                    default:
                        break;
                }

                if (przesun == true)
                {
                    wykonaj_przesuniecie(r2[i], li[i], 
                          reg1[i], reg2[i], licz3[i]);
                    przesun = false;
                }

                if (dodaj == true)
                {
                    wykonaj_dodawanie(r2[i], li[i], reg1[i], reg2[i], licz3[i]);
                    dodaj = false;
                }

                if (odejmij == true)
                {
                    wykonaj_odejmowanie(r2[i], li[i], reg1[i], reg2[i], licz3[i]);
                    odejmij = false;
                }
            }
        }

        private void ToFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileNameBox.Text + ".txt")) // If file does not exists
            {
                File.Create(FileNameBox.Text + ".txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText(FileNameBox.Text + ".txt"))
                { sw.WriteLine(instrukcje.Text); } // Write text to .txt file   
            }
            else // If file already exists
            {   // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(FileNameBox.Text + ".txt"))
                { sw.WriteLine(instrukcje.Text); }// Write text to .txt file
            }
        }

        private void FromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   reset();
                System.IO.StreamReader sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
                //string lines = sr.ReadToEnd();
                string[] line = sr.ReadToEnd().Split('\n');
                int number_of_lines = 0;
                instrukcje.Text = null;
                numeracja_linii.Text = null;
                numeracja_l = 0;

                while (true)
                {   try
                    {   string a = line[number_of_lines];
                        numeracja_l++;
                        number_of_lines++;
                        instrukcje.Text += a;
                        instrukcje.Text += "\n";
                        linijka += a.Count()+1;
                        numeracja_linii.Text = numeracja_linii.Text + numeracja_l.ToString() + newLine;
                    }
                    catch (System.Exception eas)
                    {   break; }
                }               
            }
        }

        private void rozpocznieto_edycje()
        {
            edytowanie = true;
            if (edytuj_l == 1)
            {
                
                dwa = instrukcje.Text.Substring(reszt[edytuj_l - 1], reszt[numeracja_l - 3]);
                instrukcje.Text = "";
                instrukcje.AppendText(Environment.NewLine);
                instrukcje.Text = instrukcje.Text + dwa;
                instrukcje.AppendText(Environment.NewLine);
            }
            if (edytuj_l == numeracja_l-1)
            {
                jeden = instrukcje.Text.Substring(0, reszt[numeracja_l - 3]);
                instrukcje.Text = jeden;
            }
            else
            {
                jeden = instrukcje.Text.Substring(0, reszt[edytuj_l - 2]);
                int l = instrukcje.Text.Length;
                dwa = instrukcje.Text.Substring(reszt[edytuj_l - 1], l- reszt[edytuj_l - 1]);
                instrukcje.Text = jeden;
                instrukcje.AppendText(Environment.NewLine);
                instrukcje.Text = instrukcje.Text + dwa;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        { /*
            try
            {                
                edytuj_l = Convert.ToInt32(this.edytuj.Text);
                if (edytuj_l <= numeracja_l && edytuj_l>=1)
                {
                    uwagi.Text = "Rozpocznięto edycję";
                    rozpocznieto_edycje();
                }
                else
                {
                    uwagi.Text = "NIEPOPRAWNY ZAKRES! Zakres linijek możliwych do edycji: " + numeracja_l;
                    edytuj.Text = instrukcje.Text.Substring(0, 0);
                }
            }
                
            catch (FormatException)
            {
               uwagi.Text = "NIEPOPRAWNY FORMAT! Zakres linijek możliwych do edycji: " + numeracja_l;
               edytuj.Text = instrukcje.Text.Substring(0, 0);
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
