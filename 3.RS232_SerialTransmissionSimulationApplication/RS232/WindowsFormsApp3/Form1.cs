using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp3
{ 

    public partial class Form1 : Form
    {
        //int licz = 0;
        string resultBinIn;
        
        char[] resultbinchar;

        string[,] tabela = { 
            { "NUL", "00000000" }, //0
            { "SOH", "00000001" }, 
            { "STX", "00000010" }, 
            { "ETX", "00000011" }, 
            { "EOT", "00000100" }, 
            { "ENQ", "00000101" }, 
            { "ACK", "00000110" }, 
            { "BEL", "00000111" }, 
            { "BS",  "00001000" }, 
            { "HT",  "00001001" }, 
            { "LF",  "00001010" }, 
            { "VT",  "00001011" }, 
            { "FF",  "00001100" }, 
            { "CR",  "00001101" },
            { "SO",  "00001110" },
            { "SI",  "00001111" },
            { "DLE", "00010000" },
            { "DC1", "00010001" },
            { "DC2", "00010010" },
            { "DC3", "00010011" },
            { "DC4", "00010100" },
            { "NAK", "00010101" },
            { "SYN", "00010110" },
            { "ETB", "00010111" },
            { "CAN", "00011000" },
            { "EM",  "00011001" },
            { "SUB", "00011010" },
            { "ESC", "00011011" },
            { "FS",  "00011100" },
            { "GS",  "00011101" },
            { "RS",  "00011110" },
            { "US",  "00011111" }, //31
            { " ",   "00100000" },
            { "!",   "00100001" },
            { "\"",  "00100010" },
            { "#",   "00100011" },
            { "$",   "00100100" },
            { "%",   "00100101" },
            { "&",   "00100110" },
            { "'",   "00100111" },
            { "(",   "00101000" },
            { ")",   "00101001" },
            { "*",   "00101010" },
            { "+",   "00101011" },
            { ",",   "00101100" },
            { "-",   "00101101" },
            { ".",   "00101110" },
            { "/",   "00101111" },
            { "0",   "00110000" },
            { "1",   "00110001" },
            { "2",   "00110010" },
            { "3",   "00110011" },
            { "4",   "00110100" },
            { "5",   "00110101" },
            { "6",   "00110110" },
            { "7",   "00110111" },
            { "8",   "00111000" },
            { "9",   "00111001" },
            { ":",   "00111010" },
            { ";",   "00111011" },
            { "<",   "00111100" },
            { "=",   "00111101" },
            { ">",   "00111110" },
            { "?",   "00111111" },
            { "@",   "01000000" },
            { "A",   "01000001" },
            { "B",   "01000010" },
            { "C",   "01000011" },
            { "D",   "01000100" },
            { "E",   "01000101" },
            { "F",   "01000110" },
            { "G",   "01000111" },
            { "H",   "01001000" },
            { "I",   "01001001" },
            { "J",   "01001010" },
            { "K",   "01001011" },
            { "L",   "01001100" },
            { "M",   "01001101" },
            { "N",   "01001110" },
            { "O",   "01001111" },
            { "P",   "01010000" },
            { "Q",   "01010001" },
            { "R",   "01010010" },
            { "S",   "01010011" },
            { "T",   "01010100" },
            { "U",   "01010101" },
            { "V",   "01010110" },
            { "W",   "01010111" },
            { "X",   "01011000" },
            { "Y",   "01011001" },
            { "Z",   "01011010" },
            { "[",   "01011011" },
            { @"\ ", "01011100" },
            { "]",   "01011101" },
            { "^",   "01011110" },
            { "_",   "01011111" },
            { "`",   "01100000" },
            { "a",   "01100001" },
            { "b",   "01100010" },
            { "c",   "01100011" },
            { "d",   "01100100" },
            { "e",   "01100101" },
            { "f",   "01100110" },
            { "g",   "01100111" },
            { "h",   "01101000" },
            { "i",   "01101001" },
            { "j",   "01101010" },
            { "k",   "01101011" },
            { "l",   "01101100" },
            { "m",   "01101101" },
            { "n",   "01101110" },
            { "o",   "01101111" },
            { "p",   "01110000" },
            { "q",   "01110001" },
            { "r",   "01110010" },
            { "s",   "01110011" },
            { "t",   "01110100" },
            { "u",   "01110101" },
            { "v",   "01110110" },
            { "w",   "01110111" },
            { "x",   "01111000" },
            { "y",   "01111001" },
            { "z",   "01111010" },
            { "{",   "01111011" },
            { "|",   "01111100" },
            { "}",   "01111101" },
            { "~",   "01111110" },
            { "DEL", "01111111" },}; // 127
        int ile_znakow;

    public Form1()
        {
            InitializeComponent();
        }
        
        private void StrzalkaDol(object sender, EventArgs e)
        {

        }

        private void trzalkaGora(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendClick(object sender, EventArgs e)
        {
            OutDisplay.Text = "";
            int resultBinOut;

            int zlicz = 1;
            for (int i=0; i<ile_znakow; i++)
            {
                string resultstring = null;
                
                for (int j=0; j<8;j++)
                {                    
                    resultstring = resultstring + System.Convert.ToString(resultbinchar[j + zlicz]);                    
                }
                resultBinOut = Int32.Parse(resultstring); // konwertacja binarnego stringa na int

                int decimalValue = 0; // konwertacja binarnego inta na decymalny int
                int base1 = 1;
                while (resultBinOut > 0)
                {
                    int reminder = resultBinOut % 10;
                    resultBinOut = resultBinOut / 10;
                    decimalValue += reminder * base1;
                    base1 = base1 * 2;
                }

                byte[] intBytes = BitConverter.GetBytes(decimalValue); // konwertacja dec int na byte dec
                Array.Reverse(intBytes);
                byte[] result = intBytes;

                byte[] bytes = BitConverter.GetBytes(decimalValue);

                var newText = Encoding.ASCII.GetString(bytes); // konwertacja z byte do znaków za pomocą ASCII

                OutDisplay.Text = OutDisplay.Text + newText.ToString();
                zlicz = 8 + zlicz + 3;
            }
        }

        private void sprawdz_slowniczek(char[] inputchar)
        {
            string[] slowniczekString =
                { "test", "piwo", "sesja", "egzamin", "kolokwium", "zaliczenie" };

            char[][] slowniczekChar = slowniczekString.Select(item => item.ToArray()).ToArray();
            int slowniczekLength = slowniczekString.Length;
            int inputCharLength = inputchar.Length;

            for (int s=0; s < slowniczekLength; s++) // szuka wszystkie grubieństwa zamieszczone w słowniku
            {
                bool znaleziono_slowo = false;
                bool czysto = false;
                bool znaleziono_litere = false;
                int slowkoLength = slowniczekString[s].Length;               
                    
                while (znaleziono_slowo == false && czysto == false)
                {
                    if (inputCharLength >= slowkoLength) // ZABIEZPIECZENIE: WEJŚCIE JEST DŁUŻSZE OD NIEŁADNEGO SŁOWA!!!
                    {                                   // inputchar - tabela 1xn pojedynczych liter całego stringu który podaliśmy na wejściu 
                        for (int i = 0; i < inputCharLength; i++)
                        {                            
                            if (inputchar[i] == slowniczekChar[s][0]) // ZMIENIĆ
                            {                                
                                znaleziono_litere = true;
                                while (znaleziono_litere == true)// szuka ciąg liter, z których składa się to słowo
                                {
                                    if ((inputCharLength - i) >= slowkoLength)
                                    {
                                        for (int l = 1; l < slowkoLength; l++)
                                        {
                                            if (inputchar[i + l] == slowniczekChar[s][l])
                                            {
                                                znaleziono_litere = true;
                                            }
                                            else
                                            {
                                                znaleziono_litere = false;
                                            }
                                        }

                                        if (znaleziono_litere == true)
                                        {
                                            Console.WriteLine("Znalazłem brzydkie słowo!!!");
                                            znaleziono_litere = false;
                                            znaleziono_slowo = true;
                                            czysto = false;

                                            for (int k=0; k < slowkoLength; k++)
                                            {
                                                inputchar[i + k] = '*';
                                            }
                                        }
                                    }
                                    else
                                    {
                                        znaleziono_litere = false;
                                    }
                                }
                            }
                        }
                    }
                                                         
                    if(znaleziono_slowo == false)
                    {
                        czysto = true;
                        Console.WriteLine("Czysto");
                        znaleziono_slowo = false;
                        znaleziono_litere = false;                         
                    }           
                }                 
            }
        }

        private void ConvertClick(object sender, EventArgs e)
        {
            BinDisplay.Text = "";
            OutDisplay.Text = "";

            string input = InDisplay.Text; // to co napisaliśmy w okienku, wpisujemy jednym ciągiem do stringa
            char[] inputchar = InDisplay.Text.ToCharArray(); // tworzymy ciąg charów, który będzie potrzebny  
                                                             // przy sprawdzeniu słownika grubiaństw
            sprawdz_slowniczek(inputchar);
            string nowyinput = new string(inputchar); // po sprawdzeniu "grubiaństw" i ewentualnym cenzurowaniu 
                                                      // otrzymamy inne dane niż te które na początku były na wejściu

            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(nowyinput); // konwertacja ASCII, na wyjściu uzyskujemy w postać DEC


            int m = 0;
            foreach (var value in ASCIIvalues)
            {
                resultBinIn = System.Convert.ToString(value, 2).PadLeft(8, '0'); // konwertacja DEC 
                                                                                 // do BIN pojedynczego znaku                                 
                string start = "1"; // dodajemy z przodu bit startu = 1, i dwa bity stopu = 11
                string stop = "11";    

                BinDisplay.AppendText(start);
                BinDisplay.Select(m*11, start.Length + m*11);
                BinDisplay.SelectionColor = Color.Red;

                BinDisplay.AppendText(resultBinIn);
                BinDisplay.Select(start.Length + m * 11, resultBinIn.Length + m * 11);
                BinDisplay.SelectionColor = Color.Black;

                BinDisplay.AppendText(stop);
                BinDisplay.Select(resultBinIn.Length+1 + m * 11, stop.Length + m * 11);
                BinDisplay.SelectionColor = Color.Red;
                m++;
                // Console.WriteLine(result);
            }

            resultbinchar = BinDisplay.Text.ToCharArray(); //to co uzyskaliśmy w okienku konwertacji, 
                                                           // wkładamy do tabeli charów (do nośnika danych)
            int resultbinLength = resultbinchar.Length; 
            ile_znakow = resultbinLength / 11; // mówi ile mamy zadekodowanych znaków w binarnej tabeli charów
        }

        private void RestartClick(object sender, EventArgs e)
        {
            BinDisplay.Text = "";
            InDisplay.Text = "";
            OutDisplay.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OutDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void BinDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
