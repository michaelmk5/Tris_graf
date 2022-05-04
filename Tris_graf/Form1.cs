
namespace Tris_graf
{
    public partial class TRIS : Form
    {
        int match;
        string[] segni;
        int match_const;
        public TRIS(int partite)
        {
            InitializeComponent();
            lb_turno.Text = Turno(0);
            this.segni = NextMatch();
            this.match = partite;
            this.match_const = partite;
            lb_match.Text = "" + match;
        }
        int turno = 0, click = 0;
        string ris = "";
       
        private string Turno(int turno)
        {
            string giocatore = "";
            if (turno == 0)
                giocatore = "Player 1";
            else
                giocatore = "Player 2";
            return giocatore;
        }

        public int Vinte(string[] segni)
        {
            int vinte = 0;
            int x = int.Parse(lb_vx.Text);
            int o = int.Parse(lb_vo.Text);
            if (Comandi.Vincita(segni).Contains("X"))
            {
                x++;
                lb_vx.Text = "" + x;
            }
            else if (Comandi.Vincita(segni).Contains("O"))
            {
                o++;
                lb_vo.Text = "" + o;
            }
            return vinte;
        }

        private string[] NextMatch()
        {
            string[] segni = new string[] { "", "", "", "", "", "", "", "", "" };
            var c = Comandi.getAll(this, typeof(Button));
            click = 0;
            btn00.Text = " ";
            btn01.Text = " ";
            btn02.Text = " ";
            btn10.Text = " ";
            btn11.Text = " ";
            btn12.Text = " ";
            btn20.Text = " ";
            btn21.Text = " ";
            btn22.Text = " ";

            foreach (Button b in c)
            {
                b.Enabled = true;
            }
            //lb_risultato.Text = "";
            
            return segni;
        }
        private void StampaRisultato(string ris)
        {
            if (ris.Contains("vincitore"))
            {
                lb_risultato.Text = ris;
            }
        }
        private void Pareggio(int click)
        {
            if(click == 9)
            {
                match--;
                if (match == 0)
                {
                    var c = Comandi.getAll(this, typeof(Button));
                    foreach (Button b in c)
                    {
                        b.Enabled = false;
                    }
                    btn_reset.Enabled = true;
                    btn_reset.Visible = true;
                }
                else
                {
                    segni = NextMatch();
                }
                lb_match.Text = "" + match;
            }
        }
        private void btn01_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn01.Text = "X";
                turno = 1;
                btn01.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn01.Text = "O";
                turno = 0;
                btn01.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[1] = btn01.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn00.Text = "X";
                turno = 1;
                btn00.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn00.Text = "O";
                turno = 0;
                btn00.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[0] = btn00.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn02.Text = "X";
                turno = 1;
                btn02.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn02.Text = "O";
                turno = 0;
                btn02.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[2] = btn02.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn10.Text = "X";
                turno = 1;
                btn10.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn10.Text = "O";
                turno = 0;
                btn10.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[3] = btn10.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn11.Text = "X";
                turno = 1;
                btn11.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn11.Text = "O";
                turno = 0;
                btn11.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[4] = btn11.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn12.Text = "X";
                turno = 1;
                btn12.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn12.Text = "O";
                turno = 0;
                btn12.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[5] = btn12.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn20.Text = "X";
                turno = 1;
                btn20.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn20.Text = "O";
                turno = 0;
                btn20.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[6] = btn20.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn21.Text = "X";
                turno = 1;
                btn21.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn21.Text = "O";
                turno = 0;
                btn21.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[7] = btn21.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (turno == 0)
            {
                btn22.Text = "X";
                turno = 1;
                btn22.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            else
            {
                btn22.Text = "O";
                turno = 0;
                btn22.Enabled = false;
                lb_turno.Text = Turno(turno);
            }
            segni[8] = btn22.Text;
            ris = Comandi.Vincita(segni);
            StampaRisultato(ris);
            click++;
            Pareggio(click);
        }
        
        private void lb_risultato_TextChanged(object sender, EventArgs e)
        {
            if (lb_risultato.Text.Contains("vincitore"))
            {
                Vinte(segni);
            }
            
            match--;
            if (match == 0)
            {
                btn_reset.Visible = true;
            }
            else
            {
                segni = NextMatch();
            }
            lb_match.Text = "" + match;
        }
        
        private void lb_vx_TextChanged(object sender, EventArgs e)
        {
            /*
            switch (match_const)
            {
                case 1:
                    if (lb_vx.Text.Equals("1"))
                    {
                        lb_risultato.Text = "Il vincitore è il giocatore 1";
                        match = 0;
                    }
                    break;
                case 3:
                    if (lb_vx.Text.Equals("2"))
                    {
                        lb_risultato.Text = "Il vincitore è il giocatore 1";
                        match = 0;
                    }
                    break;
                case 5:
                    if (lb_vx.Text.Equals("3"))
                    {
                        lb_risultato.Text = "Il vincitore è il giocatore 1";
                        match = 0;
                    }
                    break;
            }*/
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Visible = false;
        }

        private void lb_vo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}