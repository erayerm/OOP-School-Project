using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NDP_Projesi
{

    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            CanBarlariYollama();
            TimerYollama();
            ParaYollama();
           
        }

        void ParaYollama()
        {
            TavukYumurtasiSat tavukYumurtasiNesnesi = new TavukYumurtasiSat();
            tavukYumurtasiNesnesi.TavukYumurtasiAl(butTavukYumurtasi, lblTavukYumurtaAdet,lblPara);
            OrdekYumurtasiSat ordekYumurtasiNesnesi = new OrdekYumurtasiSat();
            ordekYumurtasiNesnesi.OrdekYumurtasiAl(butOrdekYumurtasi, lblOrdekYumurtaAdet, lblPara);
            InekSutuSat inekSutuNesnesi = new InekSutuSat();
            inekSutuNesnesi.InekSutuAl(butInekSutu, lblInekSutuKg, lblPara);
            KeciSutuSat keciSutuNesnesi = new KeciSutuSat();
            keciSutuNesnesi.KeciSutuAl(butKeciSutu, lblKeciSutuKg, lblPara);

        }
        void CanBarlariYollama()
        {
            TavukYemEkle tavukNesnesi = new TavukYemEkle();
            tavukNesnesi.TavukYemEkleAl(butTavukYem, TavukProgressBar);
            OrdekYemEkle ordekNesnesi = new OrdekYemEkle();
            ordekNesnesi.OrdekYemEkleAl(butOrdekYem, OrdekProgressBar);
            InekYemEkle inekNesnesi = new InekYemEkle();
            inekNesnesi.InekYemEkleAl(butInekYem, InekProgressBar);
            KeciYemEkle keciNesnesi = new KeciYemEkle();
            keciNesnesi.KeciYemEkleAl(butKeciYem, KeciProgressBar);

        }
        void TimerYollama()
        {
            TavukCanTimer tavukTimerNesnesi = new TavukCanTimer();
            tavukTimerNesnesi.TimerAl(TimerTavukCan, TavukProgressBar,lblTavukYumurtaAdet,lblTavukDurum);
            OrdekCanTimer ordekTimerNesnesi = new OrdekCanTimer();
            ordekTimerNesnesi.TimerAl(TimerOrdekCan, OrdekProgressBar,lblOrdekYumurtaAdet,lblOrdekDurum);
            InekCanTimer inekTimerNesnesi = new InekCanTimer();
            inekTimerNesnesi.TimerAl(TimerInekCan, InekProgressBar, lblInekSutuKg, lblInekDurum);
            KeciCanTimer keciTimerNesnesi = new KeciCanTimer();
            keciTimerNesnesi.TimerAl(TimerKeciCan, KeciProgressBar,lblKeciSutuKg,lblKeciDurum);

            GecenSureSinifi gecenSureNesnesi = new GecenSureSinifi();
            gecenSureNesnesi.GecenSureTimerAl(TimerGecenSure,lblGecenSureDegisken);

        }
    }


    public class GecenSureSinifi
    {
        protected Timer timerGecenSure;

        protected Label labelGecenSure;
        protected int sayac = 0;
        public void GecenSureTimerAl(Timer tim,Label lab)
        {
            timerGecenSure = tim;
            labelGecenSure = lab;
            tim.Start();
            tim.Tick += new System.EventHandler(TimerGecenSure_Tick);
        }
        private void TimerGecenSure_Tick(object sender, EventArgs e)
        {
            sayac++;
            labelGecenSure.Text = sayac + " SN";
        }
    }

    public abstract class TimerAldırma
    {
        
        public abstract void TimerAl(Timer tim, ProgressBar bar, Label lab, Label lab2);
    }

    public class TavukYemEkle
    {
        protected ProgressBar canBari;
        public void TavukYemEkleAl(Button but,ProgressBar bar)
        {
            but.Click += new EventHandler(But_TavukYemEkle);
            canBari = bar;
        }
        public void But_TavukYemEkle(object sender, EventArgs e)
        {
            if(canBari.Value != 0) {
                canBari.Value = 100;
            }
        }
    }
    public class TavukCanTimer :TimerAldırma
    {
        protected Timer timer;
        protected Label yumurtaAdeti;
        protected Label yasamDurumu;
        protected ProgressBar canBari;
        protected int sayac=0;
        public string[] yumurtaDizisi;




        public override void TimerAl(Timer tim, ProgressBar bar, Label lab,Label lab2)
        {
            yumurtaAdeti = lab;
            yasamDurumu = lab2;
            canBari = bar;
            timer = tim;
            tim.Start();
            tim.Tick += new System.EventHandler(TimerTavukCan_Tick);
        }
        private void TimerTavukCan_Tick(object sender, EventArgs e)
        {
            yumurtaDizisi = yumurtaAdeti.Text.Split(' ');

            sayac++;
            if (sayac % 3 == 0 && sayac != 0)
            {
                yumurtaAdeti.Text = Convert.ToString(Convert.ToInt32(yumurtaDizisi[0])+1) + " ADET";
            }
            if (canBari.Value != 0) {
                canBari.Value = canBari.Value - 2;
            }
            else 
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = @"C:\Users\asus\source\repos\NDP_Projesi\NDP_Projesi\tavuk.wav";
                sound.Play();
                yasamDurumu.Text = "ÖLDÜ";
                timer.Stop();
            }
        }

    }
    public class TavukYumurtasiSat
    {
        protected Label yumurtaSayisiLabeli;
        protected Label paraLabeli;
        public string[] yumurtaDizisi;
        public string[] parayiOgren;
        public void TavukYumurtasiAl(Button but,Label lab,Label lab2)
        {
            but.Click += new EventHandler(But_TavukPara);
            yumurtaSayisiLabeli = lab;
            paraLabeli = lab2;
        }
        public void But_TavukPara(object sender,EventArgs e)
        {
            yumurtaDizisi = yumurtaSayisiLabeli.Text.Split(' ');
            parayiOgren = paraLabeli.Text.Split(' ');
            paraLabeli.Text = Convert.ToString(Convert.ToInt32(yumurtaDizisi[0]) + Convert.ToInt32(parayiOgren[0])) +" TL";
            yumurtaSayisiLabeli.Text = "0 ADET";

            
        }
    }
    
    public class OrdekYemEkle
    {
        protected ProgressBar canBari;
        public void OrdekYemEkleAl(Button but, ProgressBar bar)
        {
            but.Click += new EventHandler(But_OrdekYemEkle);
            canBari = bar;
        }
        private void But_OrdekYemEkle(object sender, EventArgs e)
        {
            if (canBari.Value != 0)
            {
                canBari.Value = 100;
            }
        }
    }
    public class OrdekCanTimer :TimerAldırma
    {
        protected Timer timer;
        protected Label yumurtaAdeti;
        protected Label yasamDurumu;
        protected ProgressBar canBari;
        protected int sayac=0;
        public string[] yumurtaDizisi;
        public override void TimerAl(Timer tim, ProgressBar bar,Label lab,Label lab2)
        {
            yumurtaAdeti = lab;
            yasamDurumu = lab2;
            canBari = bar;
            timer = tim;
            tim.Start();
            tim.Tick += new System.EventHandler(TimerOrdekCan_Tick);
        }
        private void TimerOrdekCan_Tick(object sender, EventArgs e)
        {
            yumurtaDizisi = yumurtaAdeti.Text.Split(' ');

            sayac++;
            if (sayac % 5 == 0 && sayac != 0)
            {
                yumurtaAdeti.Text = Convert.ToString(Convert.ToInt32(yumurtaDizisi[0]) + 1) + " ADET";
            }
            if (canBari.Value != 0)
            {
                if (canBari.Value == 1)
                {
                    canBari.Value = canBari.Value - 1;
                }
                else
                {
                    canBari.Value = canBari.Value - 3;
                }
                
            }
            else
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = @"C:\Users\asus\source\repos\NDP_Projesi\NDP_Projesi\ordek.wav";
                sound.Play();
                yasamDurumu.Text = "ÖLDÜ";
                timer.Stop();
            }
        }
    }
    public class OrdekYumurtasiSat 
    {
        protected Label yumurtaSayisiLabeli;
        protected Label paraLabeli;
        public string[] yumurtaDizisi;
        public string[] paraDizisi;
        public void OrdekYumurtasiAl(Button but, Label lab, Label lab2)
        {
            but.Click += new EventHandler(But_OrdekPara);
            yumurtaSayisiLabeli = lab;
            paraLabeli = lab2;
        }
        public void But_OrdekPara(object sender, EventArgs e)
        {
            yumurtaDizisi = yumurtaSayisiLabeli.Text.Split(' ');
            paraDizisi = paraLabeli.Text.Split(' ');
            paraLabeli.Text = Convert.ToString(3*Convert.ToInt32(yumurtaDizisi[0]) + Convert.ToInt32(paraDizisi[0])) + " TL";
            yumurtaSayisiLabeli.Text = "0 ADET";


        }
    }

    public class InekYemEkle
    {
        protected ProgressBar canBari;
        public void InekYemEkleAl(Button but, ProgressBar bar)
        {
            but.Click += new EventHandler(But_InekYemEkle);
            canBari = bar;
        }
        private void But_InekYemEkle(object sender, EventArgs e)
        {
            if (canBari.Value != 0)
            {
                canBari.Value = 100;
            }

        }

    }
    public class InekCanTimer: TimerAldırma
    {
        protected Timer timer;
        protected Label sutAdeti;
        protected Label yasamDurumu;
        protected ProgressBar canBari;
        protected int sayac=0;
        public string[] sutSayisiniOgren1;
        public override void TimerAl(Timer tim, ProgressBar bar,Label lab,Label lab2)
        {
            sutAdeti = lab;
            yasamDurumu = lab2;
            canBari = bar;
            timer = tim;
            tim.Start();
            tim.Tick += new System.EventHandler(TimerInekCan_Tick);
        }

        private void TimerInekCan_Tick(object sender, EventArgs e)
        {
            sutSayisiniOgren1 = sutAdeti.Text.Split(' ');

            sayac++;
            if (sayac % 8 == 0 && sayac != 0)
            {
                sutAdeti.Text = Convert.ToString(Convert.ToInt32(sutSayisiniOgren1[0]) + 1) + " KG";
            }
            if (canBari.Value != 0)
            {
                if(canBari.Value == 4)
                {
                    canBari.Value = canBari.Value - 4;
                }
                else
                {
                    canBari.Value = canBari.Value - 8;
                }
                
            }
            else
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = @"C:\Users\asus\source\repos\NDP_Projesi\NDP_Projesi\inek.wav";
                sound.Play();
                yasamDurumu.Text = "ÖLDÜ";
                timer.Stop();
            }
        }

    }
    public class InekSutuSat 
    {
        protected Label sutSayisiLabeli;
        protected Label paraLabeli;
        public string[] sutDizisi;
        public string[] paraDizisi;
        public void InekSutuAl(Button but, Label lab, Label lab2)
        {
            but.Click += new EventHandler(But_InekPara);
            sutSayisiLabeli = lab;
            paraLabeli = lab2;
        }
        public void But_InekPara(object sender, EventArgs e)
        {
            sutDizisi = sutSayisiLabeli.Text.Split(' ');
            paraDizisi = paraLabeli.Text.Split(' ');
            paraLabeli.Text = Convert.ToString(5*Convert.ToInt32(sutDizisi[0]) + Convert.ToInt32(paraDizisi[0])) + " TL";
            sutSayisiLabeli.Text = "0 KG";


        }
    }

    public class KeciYemEkle
    {
        protected ProgressBar keciCanBari;
        public void KeciYemEkleAl(Button but, ProgressBar bar)
        {
            but.Click += new EventHandler(But_KeciYemEkle);
            keciCanBari = bar;
        }
        private void But_KeciYemEkle(object sender, EventArgs e)
        {
            if (keciCanBari.Value != 0)
            {
                keciCanBari.Value = 100;
            }

        }

    }
    public class KeciCanTimer : TimerAldırma
    {
        protected Timer timer;
        protected Label sutAdeti;
        protected Label yasamDurumu;
        protected ProgressBar canBari;
        protected int sayac=0;
        public string[] sutSayisiniOgren1;
        public override void TimerAl(Timer tim, ProgressBar bar, Label lab,Label lab2)
        {
            sutAdeti = lab;
            yasamDurumu = lab2;
            canBari = bar;
            timer = tim;
            tim.Start();
            tim.Tick += new System.EventHandler(TimerKeciCan_Tick);
        }

        private void TimerKeciCan_Tick(object sender, EventArgs e)
        {
            sutSayisiniOgren1 = sutAdeti.Text.Split(' ');

            sayac++;
            if (sayac % 7 == 0 && sayac != 0)
            {
                sutAdeti.Text = Convert.ToString(Convert.ToInt32(sutSayisiniOgren1[0]) + 1) + " KG";
            }
            if (canBari.Value != 0)
            {
                if (canBari.Value == 4) {
                    canBari.Value = canBari.Value - 4;
                }
                else
                {
                    canBari.Value = canBari.Value - 6;
                }
                
            }
            else
            {
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = @"C:\Users\asus\source\repos\NDP_Projesi\NDP_Projesi\keci.wav";
                sound.Play();
                yasamDurumu.Text = "ÖLDÜ";
                timer.Stop();
            }
        }

    }
    public class KeciSutuSat 
    {
        protected Label sutSayisiLabeli;
        protected Label paraLabeli;
        public string[] sutDizisi;
        public string[] paraDizisi;
        public void KeciSutuAl(Button but, Label lab, Label lab2)
        {
            but.Click += new EventHandler(But_KeciPara);
            sutSayisiLabeli = lab;
            paraLabeli = lab2;
        }
        public void But_KeciPara(object sender, EventArgs e)
        {
            sutDizisi = sutSayisiLabeli.Text.Split(' ');
            paraDizisi = paraLabeli.Text.Split(' ');
            paraLabeli.Text = Convert.ToString(8*Convert.ToInt32(sutDizisi[0]) + Convert.ToInt32(paraDizisi[0])) + " TL";
            sutSayisiLabeli.Text = "0 KG";
        }
    }
}
