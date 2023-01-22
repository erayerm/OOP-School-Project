namespace NDP_Projesi
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblUrunDeposu = new System.Windows.Forms.Label();
            this.lblTavukYumurtası = new System.Windows.Forms.Label();
            this.lblTavukYumurtaAdet = new System.Windows.Forms.Label();
            this.lblInekSutu = new System.Windows.Forms.Label();
            this.lblInekSutuKg = new System.Windows.Forms.Label();
            this.lblOrdekYumurtasi = new System.Windows.Forms.Label();
            this.lblOrdekYumurtaAdet = new System.Windows.Forms.Label();
            this.lblKeciSutu = new System.Windows.Forms.Label();
            this.lblKeciSutuKg = new System.Windows.Forms.Label();
            this.ustAnaPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblGecenSureDegisken = new System.Windows.Forms.Label();
            this.lblGecenSureSabit = new System.Windows.Forms.Label();
            this.sagUstPanel = new System.Windows.Forms.Panel();
            this.butKeciSutu = new System.Windows.Forms.Button();
            this.butInekSutu = new System.Windows.Forms.Button();
            this.butOrdekYumurtasi = new System.Windows.Forms.Button();
            this.butTavukYumurtasi = new System.Windows.Forms.Button();
            this.lblGıdaFabrikası = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.solUstPanel = new System.Windows.Forms.Panel();
            this.AltAnaPanel = new System.Windows.Forms.Panel();
            this.sagAltPanel = new System.Windows.Forms.Panel();
            this.KeciProgressBar = new System.Windows.Forms.ProgressBar();
            this.InekProgressBar = new System.Windows.Forms.ProgressBar();
            this.picKeci = new System.Windows.Forms.PictureBox();
            this.picInek = new System.Windows.Forms.PictureBox();
            this.butKeciYem = new System.Windows.Forms.Button();
            this.lblKeciDurum = new System.Windows.Forms.Label();
            this.butInekYem = new System.Windows.Forms.Button();
            this.lblInekDurum = new System.Windows.Forms.Label();
            this.lblAhir = new System.Windows.Forms.Label();
            this.solAltPanel = new System.Windows.Forms.Panel();
            this.OrdekProgressBar = new System.Windows.Forms.ProgressBar();
            this.TavukProgressBar = new System.Windows.Forms.ProgressBar();
            this.picOrdek = new System.Windows.Forms.PictureBox();
            this.picTavuk = new System.Windows.Forms.PictureBox();
            this.butOrdekYem = new System.Windows.Forms.Button();
            this.lblOrdekDurum = new System.Windows.Forms.Label();
            this.butTavukYem = new System.Windows.Forms.Button();
            this.lblTavukDurum = new System.Windows.Forms.Label();
            this.lblKumes = new System.Windows.Forms.Label();
            this.TimerTavukCan = new System.Windows.Forms.Timer(this.components);
            this.TimerOrdekCan = new System.Windows.Forms.Timer(this.components);
            this.TimerKeciCan = new System.Windows.Forms.Timer(this.components);
            this.TimerInekCan = new System.Windows.Forms.Timer(this.components);
            this.TimerGecenSure = new System.Windows.Forms.Timer(this.components);
            this.ustAnaPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.sagUstPanel.SuspendLayout();
            this.solUstPanel.SuspendLayout();
            this.AltAnaPanel.SuspendLayout();
            this.sagAltPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKeci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInek)).BeginInit();
            this.solAltPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrdek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTavuk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunDeposu
            // 
            this.lblUrunDeposu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUrunDeposu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunDeposu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUrunDeposu.Location = new System.Drawing.Point(28, 12);
            this.lblUrunDeposu.Name = "lblUrunDeposu";
            this.lblUrunDeposu.Size = new System.Drawing.Size(362, 34);
            this.lblUrunDeposu.TabIndex = 0;
            this.lblUrunDeposu.Text = "ÜRÜN DEPOSU";
            this.lblUrunDeposu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTavukYumurtası
            // 
            this.lblTavukYumurtası.BackColor = System.Drawing.Color.Silver;
            this.lblTavukYumurtası.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTavukYumurtası.Location = new System.Drawing.Point(29, 57);
            this.lblTavukYumurtası.Name = "lblTavukYumurtası";
            this.lblTavukYumurtası.Size = new System.Drawing.Size(172, 20);
            this.lblTavukYumurtası.TabIndex = 1;
            this.lblTavukYumurtası.Text = "TAVUK YUMURTASI";
            this.lblTavukYumurtası.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTavukYumurtaAdet
            // 
            this.lblTavukYumurtaAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTavukYumurtaAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTavukYumurtaAdet.ForeColor = System.Drawing.Color.Red;
            this.lblTavukYumurtaAdet.Location = new System.Drawing.Point(29, 86);
            this.lblTavukYumurtaAdet.Name = "lblTavukYumurtaAdet";
            this.lblTavukYumurtaAdet.Size = new System.Drawing.Size(172, 44);
            this.lblTavukYumurtaAdet.TabIndex = 5;
            this.lblTavukYumurtaAdet.Text = "0 ADET";
            this.lblTavukYumurtaAdet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInekSutu
            // 
            this.lblInekSutu.BackColor = System.Drawing.Color.Silver;
            this.lblInekSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInekSutu.Location = new System.Drawing.Point(218, 57);
            this.lblInekSutu.Name = "lblInekSutu";
            this.lblInekSutu.Size = new System.Drawing.Size(172, 20);
            this.lblInekSutu.TabIndex = 4;
            this.lblInekSutu.Text = "İNEK SÜTÜ";
            this.lblInekSutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInekSutuKg
            // 
            this.lblInekSutuKg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblInekSutuKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInekSutuKg.ForeColor = System.Drawing.Color.Red;
            this.lblInekSutuKg.Location = new System.Drawing.Point(218, 86);
            this.lblInekSutuKg.Name = "lblInekSutuKg";
            this.lblInekSutuKg.Size = new System.Drawing.Size(172, 44);
            this.lblInekSutuKg.TabIndex = 8;
            this.lblInekSutuKg.Text = "0 KG";
            this.lblInekSutuKg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdekYumurtasi
            // 
            this.lblOrdekYumurtasi.BackColor = System.Drawing.Color.Silver;
            this.lblOrdekYumurtasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrdekYumurtasi.Location = new System.Drawing.Point(28, 142);
            this.lblOrdekYumurtasi.Name = "lblOrdekYumurtasi";
            this.lblOrdekYumurtasi.Size = new System.Drawing.Size(172, 20);
            this.lblOrdekYumurtasi.TabIndex = 9;
            this.lblOrdekYumurtasi.Text = "ÖRDEK YUMURTASI";
            this.lblOrdekYumurtasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdekYumurtaAdet
            // 
            this.lblOrdekYumurtaAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOrdekYumurtaAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrdekYumurtaAdet.ForeColor = System.Drawing.Color.Red;
            this.lblOrdekYumurtaAdet.Location = new System.Drawing.Point(28, 171);
            this.lblOrdekYumurtaAdet.Name = "lblOrdekYumurtaAdet";
            this.lblOrdekYumurtaAdet.Size = new System.Drawing.Size(172, 44);
            this.lblOrdekYumurtaAdet.TabIndex = 11;
            this.lblOrdekYumurtaAdet.Text = "0 ADET";
            this.lblOrdekYumurtaAdet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeciSutu
            // 
            this.lblKeciSutu.BackColor = System.Drawing.Color.Silver;
            this.lblKeciSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeciSutu.Location = new System.Drawing.Point(217, 142);
            this.lblKeciSutu.Name = "lblKeciSutu";
            this.lblKeciSutu.Size = new System.Drawing.Size(172, 20);
            this.lblKeciSutu.TabIndex = 10;
            this.lblKeciSutu.Text = "KEÇİ SÜTÜ";
            this.lblKeciSutu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeciSutuKg
            // 
            this.lblKeciSutuKg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKeciSutuKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeciSutuKg.ForeColor = System.Drawing.Color.Red;
            this.lblKeciSutuKg.Location = new System.Drawing.Point(217, 171);
            this.lblKeciSutuKg.Name = "lblKeciSutuKg";
            this.lblKeciSutuKg.Size = new System.Drawing.Size(172, 44);
            this.lblKeciSutuKg.TabIndex = 12;
            this.lblKeciSutuKg.Text = "0 KG";
            this.lblKeciSutuKg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ustAnaPanel
            // 
            this.ustAnaPanel.BackColor = System.Drawing.Color.Teal;
            this.ustAnaPanel.Controls.Add(this.panel5);
            this.ustAnaPanel.Controls.Add(this.panel4);
            this.ustAnaPanel.Controls.Add(this.sagUstPanel);
            this.ustAnaPanel.Controls.Add(this.solUstPanel);
            this.ustAnaPanel.Location = new System.Drawing.Point(0, 0);
            this.ustAnaPanel.Name = "ustAnaPanel";
            this.ustAnaPanel.Size = new System.Drawing.Size(888, 259);
            this.ustAnaPanel.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lblPara);
            this.panel5.Controls.Add(this.lblKasa);
            this.panel5.Location = new System.Drawing.Point(760, 131);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 110);
            this.panel5.TabIndex = 18;
            // 
            // lblPara
            // 
            this.lblPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.ForeColor = System.Drawing.Color.Red;
            this.lblPara.Location = new System.Drawing.Point(10, 52);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(96, 44);
            this.lblPara.TabIndex = 21;
            this.lblPara.Text = "0 TL";
            this.lblPara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKasa
            // 
            this.lblKasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKasa.Location = new System.Drawing.Point(10, 9);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(96, 34);
            this.lblKasa.TabIndex = 18;
            this.lblKasa.Text = "KASA";
            this.lblKasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblGecenSureDegisken);
            this.panel4.Controls.Add(this.lblGecenSureSabit);
            this.panel4.Location = new System.Drawing.Point(760, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 113);
            this.panel4.TabIndex = 16;
            // 
            // lblGecenSureDegisken
            // 
            this.lblGecenSureDegisken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGecenSureDegisken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenSureDegisken.ForeColor = System.Drawing.Color.Red;
            this.lblGecenSureDegisken.Location = new System.Drawing.Point(10, 57);
            this.lblGecenSureDegisken.Name = "lblGecenSureDegisken";
            this.lblGecenSureDegisken.Size = new System.Drawing.Size(96, 44);
            this.lblGecenSureDegisken.TabIndex = 22;
            this.lblGecenSureDegisken.Text = "0 SN";
            this.lblGecenSureDegisken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGecenSureSabit
            // 
            this.lblGecenSureSabit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGecenSureSabit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecenSureSabit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGecenSureSabit.Location = new System.Drawing.Point(10, 12);
            this.lblGecenSureSabit.Name = "lblGecenSureSabit";
            this.lblGecenSureSabit.Size = new System.Drawing.Size(96, 34);
            this.lblGecenSureSabit.TabIndex = 19;
            this.lblGecenSureSabit.Text = "GEÇEN SÜRE";
            this.lblGecenSureSabit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sagUstPanel
            // 
            this.sagUstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sagUstPanel.Controls.Add(this.butKeciSutu);
            this.sagUstPanel.Controls.Add(this.butInekSutu);
            this.sagUstPanel.Controls.Add(this.butOrdekYumurtasi);
            this.sagUstPanel.Controls.Add(this.butTavukYumurtasi);
            this.sagUstPanel.Controls.Add(this.lblGıdaFabrikası);
            this.sagUstPanel.Controls.Add(this.label1);
            this.sagUstPanel.Location = new System.Drawing.Point(454, 12);
            this.sagUstPanel.Name = "sagUstPanel";
            this.sagUstPanel.Size = new System.Drawing.Size(300, 229);
            this.sagUstPanel.TabIndex = 15;
            // 
            // butKeciSutu
            // 
            this.butKeciSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butKeciSutu.ForeColor = System.Drawing.Color.Red;
            this.butKeciSutu.Location = new System.Drawing.Point(15, 184);
            this.butKeciSutu.Name = "butKeciSutu";
            this.butKeciSutu.Size = new System.Drawing.Size(271, 31);
            this.butKeciSutu.TabIndex = 16;
            this.butKeciSutu.Text = "KEÇİ SÜTÜ SAT";
            this.butKeciSutu.UseVisualStyleBackColor = true;
            // 
            // butInekSutu
            // 
            this.butInekSutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butInekSutu.ForeColor = System.Drawing.Color.Red;
            this.butInekSutu.Location = new System.Drawing.Point(15, 142);
            this.butInekSutu.Name = "butInekSutu";
            this.butInekSutu.Size = new System.Drawing.Size(271, 31);
            this.butInekSutu.TabIndex = 15;
            this.butInekSutu.Text = "İNEK SÜTÜ SAT";
            this.butInekSutu.UseVisualStyleBackColor = true;
            // 
            // butOrdekYumurtasi
            // 
            this.butOrdekYumurtasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butOrdekYumurtasi.ForeColor = System.Drawing.Color.Red;
            this.butOrdekYumurtasi.Location = new System.Drawing.Point(15, 99);
            this.butOrdekYumurtasi.Name = "butOrdekYumurtasi";
            this.butOrdekYumurtasi.Size = new System.Drawing.Size(271, 31);
            this.butOrdekYumurtasi.TabIndex = 14;
            this.butOrdekYumurtasi.Text = "ÖRDEK YUMURTASI SAT";
            this.butOrdekYumurtasi.UseVisualStyleBackColor = true;
            // 
            // butTavukYumurtasi
            // 
            this.butTavukYumurtasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butTavukYumurtasi.ForeColor = System.Drawing.Color.Red;
            this.butTavukYumurtasi.Location = new System.Drawing.Point(15, 57);
            this.butTavukYumurtasi.Name = "butTavukYumurtasi";
            this.butTavukYumurtasi.Size = new System.Drawing.Size(271, 31);
            this.butTavukYumurtasi.TabIndex = 13;
            this.butTavukYumurtasi.Text = "TAVUK YUMURTASI SAT";
            this.butTavukYumurtasi.UseVisualStyleBackColor = true;
            // 
            // lblGıdaFabrikası
            // 
            this.lblGıdaFabrikası.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGıdaFabrikası.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGıdaFabrikası.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGıdaFabrikası.Location = new System.Drawing.Point(12, 12);
            this.lblGıdaFabrikası.Name = "lblGıdaFabrikası";
            this.lblGıdaFabrikası.Size = new System.Drawing.Size(274, 34);
            this.lblGıdaFabrikası.TabIndex = 12;
            this.lblGıdaFabrikası.Text = "GIDA FABRİKASI";
            this.lblGıdaFabrikası.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // solUstPanel
            // 
            this.solUstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.solUstPanel.Controls.Add(this.lblUrunDeposu);
            this.solUstPanel.Controls.Add(this.lblKeciSutuKg);
            this.solUstPanel.Controls.Add(this.lblInekSutu);
            this.solUstPanel.Controls.Add(this.lblTavukYumurtaAdet);
            this.solUstPanel.Controls.Add(this.lblKeciSutu);
            this.solUstPanel.Controls.Add(this.lblTavukYumurtası);
            this.solUstPanel.Controls.Add(this.lblOrdekYumurtaAdet);
            this.solUstPanel.Controls.Add(this.lblInekSutuKg);
            this.solUstPanel.Controls.Add(this.lblOrdekYumurtasi);
            this.solUstPanel.Location = new System.Drawing.Point(15, 12);
            this.solUstPanel.Name = "solUstPanel";
            this.solUstPanel.Size = new System.Drawing.Size(421, 229);
            this.solUstPanel.TabIndex = 14;
            // 
            // AltAnaPanel
            // 
            this.AltAnaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AltAnaPanel.Controls.Add(this.sagAltPanel);
            this.AltAnaPanel.Controls.Add(this.solAltPanel);
            this.AltAnaPanel.Location = new System.Drawing.Point(0, 258);
            this.AltAnaPanel.Name = "AltAnaPanel";
            this.AltAnaPanel.Size = new System.Drawing.Size(888, 375);
            this.AltAnaPanel.TabIndex = 14;
            // 
            // sagAltPanel
            // 
            this.sagAltPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sagAltPanel.Controls.Add(this.KeciProgressBar);
            this.sagAltPanel.Controls.Add(this.InekProgressBar);
            this.sagAltPanel.Controls.Add(this.picKeci);
            this.sagAltPanel.Controls.Add(this.picInek);
            this.sagAltPanel.Controls.Add(this.butKeciYem);
            this.sagAltPanel.Controls.Add(this.lblKeciDurum);
            this.sagAltPanel.Controls.Add(this.butInekYem);
            this.sagAltPanel.Controls.Add(this.lblInekDurum);
            this.sagAltPanel.Controls.Add(this.lblAhir);
            this.sagAltPanel.Location = new System.Drawing.Point(454, 19);
            this.sagAltPanel.Name = "sagAltPanel";
            this.sagAltPanel.Size = new System.Drawing.Size(421, 335);
            this.sagAltPanel.TabIndex = 17;
            // 
            // KeciProgressBar
            // 
            this.KeciProgressBar.Location = new System.Drawing.Point(148, 234);
            this.KeciProgressBar.Name = "KeciProgressBar";
            this.KeciProgressBar.Size = new System.Drawing.Size(242, 33);
            this.KeciProgressBar.TabIndex = 36;
            this.KeciProgressBar.Value = 100;
            // 
            // InekProgressBar
            // 
            this.InekProgressBar.Location = new System.Drawing.Point(150, 97);
            this.InekProgressBar.Name = "InekProgressBar";
            this.InekProgressBar.Size = new System.Drawing.Size(240, 33);
            this.InekProgressBar.TabIndex = 35;
            this.InekProgressBar.Value = 100;
            // 
            // picKeci
            // 
            this.picKeci.Image = ((System.Drawing.Image)(resources.GetObject("picKeci.Image")));
            this.picKeci.Location = new System.Drawing.Point(31, 204);
            this.picKeci.Name = "picKeci";
            this.picKeci.Size = new System.Drawing.Size(100, 100);
            this.picKeci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKeci.TabIndex = 30;
            this.picKeci.TabStop = false;
            // 
            // picInek
            // 
            this.picInek.Image = ((System.Drawing.Image)(resources.GetObject("picInek.Image")));
            this.picInek.Location = new System.Drawing.Point(31, 68);
            this.picInek.Name = "picInek";
            this.picInek.Size = new System.Drawing.Size(100, 100);
            this.picInek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInek.TabIndex = 29;
            this.picInek.TabStop = false;
            // 
            // butKeciYem
            // 
            this.butKeciYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butKeciYem.ForeColor = System.Drawing.Color.Red;
            this.butKeciYem.Location = new System.Drawing.Point(148, 273);
            this.butKeciYem.Name = "butKeciYem";
            this.butKeciYem.Size = new System.Drawing.Size(242, 31);
            this.butKeciYem.TabIndex = 25;
            this.butKeciYem.Text = "YEM VER";
            this.butKeciYem.UseVisualStyleBackColor = true;
            // 
            // lblKeciDurum
            // 
            this.lblKeciDurum.BackColor = System.Drawing.Color.Silver;
            this.lblKeciDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKeciDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblKeciDurum.Location = new System.Drawing.Point(147, 204);
            this.lblKeciDurum.Name = "lblKeciDurum";
            this.lblKeciDurum.Size = new System.Drawing.Size(243, 20);
            this.lblKeciDurum.TabIndex = 24;
            this.lblKeciDurum.Text = "CANLI";
            this.lblKeciDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butInekYem
            // 
            this.butInekYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butInekYem.ForeColor = System.Drawing.Color.Red;
            this.butInekYem.Location = new System.Drawing.Point(148, 137);
            this.butInekYem.Name = "butInekYem";
            this.butInekYem.Size = new System.Drawing.Size(242, 31);
            this.butInekYem.TabIndex = 21;
            this.butInekYem.Text = "YEM VER";
            this.butInekYem.UseVisualStyleBackColor = true;
            // 
            // lblInekDurum
            // 
            this.lblInekDurum.BackColor = System.Drawing.Color.Silver;
            this.lblInekDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInekDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblInekDurum.Location = new System.Drawing.Point(149, 68);
            this.lblInekDurum.Name = "lblInekDurum";
            this.lblInekDurum.Size = new System.Drawing.Size(241, 20);
            this.lblInekDurum.TabIndex = 20;
            this.lblInekDurum.Text = "CANLI";
            this.lblInekDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAhir
            // 
            this.lblAhir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAhir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAhir.Location = new System.Drawing.Point(28, 19);
            this.lblAhir.Name = "lblAhir";
            this.lblAhir.Size = new System.Drawing.Size(362, 34);
            this.lblAhir.TabIndex = 2;
            this.lblAhir.Text = "AHIR";
            this.lblAhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solAltPanel
            // 
            this.solAltPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.solAltPanel.Controls.Add(this.OrdekProgressBar);
            this.solAltPanel.Controls.Add(this.TavukProgressBar);
            this.solAltPanel.Controls.Add(this.picOrdek);
            this.solAltPanel.Controls.Add(this.picTavuk);
            this.solAltPanel.Controls.Add(this.butOrdekYem);
            this.solAltPanel.Controls.Add(this.lblOrdekDurum);
            this.solAltPanel.Controls.Add(this.butTavukYem);
            this.solAltPanel.Controls.Add(this.lblTavukDurum);
            this.solAltPanel.Controls.Add(this.lblKumes);
            this.solAltPanel.Location = new System.Drawing.Point(15, 19);
            this.solAltPanel.Name = "solAltPanel";
            this.solAltPanel.Size = new System.Drawing.Size(421, 335);
            this.solAltPanel.TabIndex = 16;
            // 
            // OrdekProgressBar
            // 
            this.OrdekProgressBar.Location = new System.Drawing.Point(147, 234);
            this.OrdekProgressBar.Name = "OrdekProgressBar";
            this.OrdekProgressBar.Size = new System.Drawing.Size(243, 33);
            this.OrdekProgressBar.TabIndex = 33;
            this.OrdekProgressBar.Value = 100;
            // 
            // TavukProgressBar
            // 
            this.TavukProgressBar.Location = new System.Drawing.Point(147, 97);
            this.TavukProgressBar.Name = "TavukProgressBar";
            this.TavukProgressBar.Size = new System.Drawing.Size(242, 33);
            this.TavukProgressBar.TabIndex = 32;
            this.TavukProgressBar.Value = 100;
            // 
            // picOrdek
            // 
            this.picOrdek.Image = ((System.Drawing.Image)(resources.GetObject("picOrdek.Image")));
            this.picOrdek.Location = new System.Drawing.Point(30, 204);
            this.picOrdek.Name = "picOrdek";
            this.picOrdek.Size = new System.Drawing.Size(100, 100);
            this.picOrdek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrdek.TabIndex = 29;
            this.picOrdek.TabStop = false;
            // 
            // picTavuk
            // 
            this.picTavuk.Image = ((System.Drawing.Image)(resources.GetObject("picTavuk.Image")));
            this.picTavuk.Location = new System.Drawing.Point(30, 68);
            this.picTavuk.Name = "picTavuk";
            this.picTavuk.Size = new System.Drawing.Size(100, 100);
            this.picTavuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTavuk.TabIndex = 28;
            this.picTavuk.TabStop = false;
            // 
            // butOrdekYem
            // 
            this.butOrdekYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butOrdekYem.ForeColor = System.Drawing.Color.Red;
            this.butOrdekYem.Location = new System.Drawing.Point(147, 273);
            this.butOrdekYem.Name = "butOrdekYem";
            this.butOrdekYem.Size = new System.Drawing.Size(242, 31);
            this.butOrdekYem.TabIndex = 21;
            this.butOrdekYem.Text = "YEM VER";
            this.butOrdekYem.UseVisualStyleBackColor = true;
            // 
            // lblOrdekDurum
            // 
            this.lblOrdekDurum.BackColor = System.Drawing.Color.Silver;
            this.lblOrdekDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrdekDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblOrdekDurum.Location = new System.Drawing.Point(147, 204);
            this.lblOrdekDurum.Name = "lblOrdekDurum";
            this.lblOrdekDurum.Size = new System.Drawing.Size(242, 20);
            this.lblOrdekDurum.TabIndex = 20;
            this.lblOrdekDurum.Text = "CANLI";
            this.lblOrdekDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butTavukYem
            // 
            this.butTavukYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butTavukYem.ForeColor = System.Drawing.Color.Red;
            this.butTavukYem.Location = new System.Drawing.Point(147, 136);
            this.butTavukYem.Name = "butTavukYem";
            this.butTavukYem.Size = new System.Drawing.Size(242, 31);
            this.butTavukYem.TabIndex = 17;
            this.butTavukYem.Text = "YEM VER";
            this.butTavukYem.UseVisualStyleBackColor = true;
            // 
            // lblTavukDurum
            // 
            this.lblTavukDurum.BackColor = System.Drawing.Color.Silver;
            this.lblTavukDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTavukDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTavukDurum.Location = new System.Drawing.Point(147, 68);
            this.lblTavukDurum.Name = "lblTavukDurum";
            this.lblTavukDurum.Size = new System.Drawing.Size(242, 20);
            this.lblTavukDurum.TabIndex = 11;
            this.lblTavukDurum.Text = "CANLI";
            this.lblTavukDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKumes
            // 
            this.lblKumes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblKumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKumes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKumes.Location = new System.Drawing.Point(27, 19);
            this.lblKumes.Name = "lblKumes";
            this.lblKumes.Size = new System.Drawing.Size(362, 34);
            this.lblKumes.TabIndex = 1;
            this.lblKumes.Text = "KÜMES";
            this.lblKumes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerTavukCan
            // 
            this.TimerTavukCan.Interval = 1000;
            // 
            // TimerOrdekCan
            // 
            this.TimerOrdekCan.Interval = 1000;
            // 
            // TimerKeciCan
            // 
            this.TimerKeciCan.Interval = 1000;
            // 
            // TimerInekCan
            // 
            this.TimerInekCan.Interval = 1000;
            // 
            // TimerGecenSure
            // 
            this.TimerGecenSure.Interval = 1000;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 630);
            this.Controls.Add(this.AltAnaPanel);
            this.Controls.Add(this.ustAnaPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(903, 669);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(903, 669);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAYVAN ÇİFTLİĞİ";
            this.ustAnaPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.sagUstPanel.ResumeLayout(false);
            this.sagUstPanel.PerformLayout();
            this.solUstPanel.ResumeLayout(false);
            this.AltAnaPanel.ResumeLayout(false);
            this.sagAltPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picKeci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInek)).EndInit();
            this.solAltPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOrdek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTavuk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUrunDeposu;
        private System.Windows.Forms.Label lblTavukYumurtası;
        private System.Windows.Forms.Label lblTavukYumurtaAdet;
        private System.Windows.Forms.Label lblInekSutu;
        private System.Windows.Forms.Label lblInekSutuKg;
        private System.Windows.Forms.Label lblOrdekYumurtasi;
        private System.Windows.Forms.Label lblOrdekYumurtaAdet;
        private System.Windows.Forms.Label lblKeciSutu;
        private System.Windows.Forms.Label lblKeciSutuKg;
        private System.Windows.Forms.Panel ustAnaPanel;
        private System.Windows.Forms.Panel sagUstPanel;
        private System.Windows.Forms.Panel solUstPanel;
        private System.Windows.Forms.Panel AltAnaPanel;
        private System.Windows.Forms.Panel sagAltPanel;
        private System.Windows.Forms.Panel solAltPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblGecenSureDegisken;
        private System.Windows.Forms.Label lblGecenSureSabit;
        private System.Windows.Forms.Button butKeciSutu;
        private System.Windows.Forms.Button butInekSutu;
        private System.Windows.Forms.Button butOrdekYumurtasi;
        private System.Windows.Forms.Button butTavukYumurtasi;
        private System.Windows.Forms.Label lblGıdaFabrikası;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAhir;
        private System.Windows.Forms.Label lblKumes;
        private System.Windows.Forms.PictureBox picKeci;
        private System.Windows.Forms.PictureBox picInek;
        private System.Windows.Forms.Button butKeciYem;
        private System.Windows.Forms.Label lblKeciDurum;
        private System.Windows.Forms.Button butInekYem;
        private System.Windows.Forms.Label lblInekDurum;
        private System.Windows.Forms.PictureBox picOrdek;
        private System.Windows.Forms.PictureBox picTavuk;
        private System.Windows.Forms.Button butOrdekYem;
        private System.Windows.Forms.Label lblOrdekDurum;
        private System.Windows.Forms.Button butTavukYem;
        private System.Windows.Forms.Label lblTavukDurum;
        private System.Windows.Forms.Timer TimerTavukCan;
        private System.Windows.Forms.ProgressBar KeciProgressBar;
        private System.Windows.Forms.ProgressBar InekProgressBar;
        private System.Windows.Forms.ProgressBar OrdekProgressBar;
        private System.Windows.Forms.ProgressBar TavukProgressBar;
        private System.Windows.Forms.Timer TimerOrdekCan;
        private System.Windows.Forms.Timer TimerKeciCan;
        private System.Windows.Forms.Timer TimerInekCan;
        private System.Windows.Forms.Timer TimerGecenSure;
    }
}

