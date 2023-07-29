using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_jez_owoce
{
    public partial class Owoce : Form
    {
        bool idzLewo, idzPrawo;
        int predkosc; // prędkość spadania owoców
        int punkty; // zdobyte punkty
        int zdobyto; // zdobyto owoców
        int stracono; // stracono owoców
        int zycie_gracza;
        // na sam początek gracz ma 3 życia 
        //(-1 życie to 2 stracone owoce)

        
        Random randX = new Random(); // położenie X owoców
        Random randY = new Random(); // położenie Y owoców

        // po straceniu owoca pojawia się plama
        PictureBox plama = new PictureBox();

        public Owoce()
        {
            InitializeComponent();
            Restart();
        }

        // jak załącza się timer, wykonują się działania w f-cji TimerGry
        private void TimerGry(object sender, EventArgs e)
        {
            ile_punktow.Text = "Zdobyto owoców: " + zdobyto;
            ile_stracono.Text = "Stracono owoców: " + stracono;
            zycie.Text = "Życie: ";
            pkt.Text = "Pukty: " + punkty;


            // jeśli nacisnięto strzałki, jeż przemieszcza się o 12 pikseli, jeśli nie napotkano się na ścianę
            if (idzLewo == true && gracz.Left > 0)
            {
                gracz.Left -= 12;
                gracz.Image = Properties.Resources.jez2; // zmienia obrazek jeża na lustrzany
            }
            if (idzPrawo == true && gracz.Left + gracz.Width < this.ClientSize.Width)
            {
                gracz.Left += 12;
                gracz.Image = Properties.Resources.jez1; // zmienia obrazek jeża na lustrzany
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "owoce")
                {
                    x.Top += predkosc; // owoce poruszają się z prędkością predkosc
           
                    // jeśli owoce spadły na ziemię, to zamieniają się w plamy
                    if(x.Top + x.Height +20 > this.ClientSize.Height)
                    {
                        plama.Visible = true;
                        plama.Image = Properties.Resources.plama2;
                        plama.Location = x.Location; // plama pojawia się na miejscu owoca który spadł
                        plama.Height = 60; //parametry obrazka plamy
                        plama.Width = 60;
                        this.plama.SizeMode = PictureBoxSizeMode.Zoom; 
                        plama.BackColor = Color.Transparent;

                         this.Controls.Add(plama); //dodano plamę do wyświetlanej gry         

                        x.Top = randY.Next(80,300) * (-1); // jeśli owoc spadł to generuje się nowy na górze
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        stracono += 1;// traci się punkty i życie gracza
                        punkty -= 1;

                        if (punkty <= 0)
                        {
                            punkty = 0;
                        }

                        zycie_gracza -= 1;

                        switch (zycie_gracza) // gracz ma 3 życia (-1 życie jeśli spadną 2 owoce)
                        {
                            case 5:
                                zycie3.Image = Properties.Resources.truskawka_pol;
                                break;
                            case 4:
                                zycie3.Visible = false;
                                break;
                            case 3:
                                zycie2.Image = Properties.Resources.truskawka_pol;
                                break;
                            case 2:
                                zycie2.Visible = false;
                                break;
                            case 1:
                                zycie1.Image = Properties.Resources.truskawka_pol;
                                break;
                            case 0:
                                zycie1.Visible = false;
                                break;
                            default:
                                break;
                        }                     

                        gracz.Image = Properties.Resources.jez3;// zmienia się obrazek jeża gdy gracz straci owoc
                    }

                    if(gracz.Bounds.IntersectsWith(x.Bounds)) 
                        // jeśli gracz dotknie owoc, to gracz zdobywa owoc
                    {
                        x.Top = randY.Next(80, 300) * (-1); // owoc generuje się na góre
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        zdobyto += 1; // naliczają się pukty za zdobyty owoc
                        punkty += 1;
                    }
                }
            }
            // po przekroczeniu x zdobytych owoców zwiększa się prędkość spadania owoców
            if(zdobyto >= 10)
            {
                predkosc = 5;
            } 

            if (zdobyto >= 20)
            {
                predkosc = 7;
            }

            if (zdobyto > 30)
            {
                predkosc = 10;
            }

            if (zdobyto > 40)
            {
                predkosc = 13;
            }

            // jeśli gracz stracił wszystkie życia, koniec gry
            if (zycie_gracza <= 0)
            {
                ile_punktow.Text = "Zdobyto owoców: " + zdobyto;
                ile_stracono.Text = "Stracono owoców: " + stracono;
                pkt.Text = "Pukty: " + punkty;
                zycie.Text = "Życie: 0";
                gracz.Image = Properties.Resources.jez3;

                timer.Stop(); // timer stop
                MessageBox.Show("Koniec Gry!" + Environment.NewLine + "Zmęczyłeś jeża :(" 
                    + Environment.NewLine + "Naciśnij OK żeby spróbować ponownie.");
                Restart();
            }
        }

        // f-cje pozwalające na przemieszczenie jeża za pomocą klawiatury
        private void NaDole(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                idzLewo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                idzPrawo = true;
            }

        }
        private void NaGorze(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                idzLewo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                idzPrawo = false;
            }
        }

        // f-cja restartuje grę
        private void Restart()
        {
            // wszystkie obiekty ktore są owocami są przesunięte w górę
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "owoce")
                {
                    x.Top = randY.Next(80, 300) * -1; // położenie Y owoców (rand)
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width); 
                    // położenie X owoców (rand)
                }
            }

            // gracz znajduje się po środku
            gracz.Left = this.ClientSize.Width / 2;
            gracz.Image = Properties.Resources.jez1;

            // zerujemy zmienne
            punkty = 0;
            zdobyto = 0;
            stracono = 0;
            predkosc = 4;
            zycie_gracza = 6;

            // jeż stoi w miejscu
            idzLewo = false;
            idzPrawo = false;

            // wznawiamy życie gracza (x3 truskawki)
            zycie3.Image = Properties.Resources.truskawka;
            zycie3.Visible = true;
            zycie2.Image = Properties.Resources.truskawka;
            zycie2.Visible = true;
            zycie1.Image = Properties.Resources.truskawka;
            zycie1.Visible = true;
            // usuwamy plamę
            plama.Visible = false;
            // timer gry start
            timer.Start();
        }
    }
}
