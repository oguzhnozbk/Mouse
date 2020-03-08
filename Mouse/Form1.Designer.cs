namespace Mouse
{
    partial class MouseHareketlendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseHareketlendirme));
            this.timer_zamaniGoster = new System.Windows.Forms.Timer(this.components);
            this.lbl_tarihsaat = new System.Windows.Forms.Label();
            this.calismaZamani = new System.Windows.Forms.Label();
            this.lbl_calismaZamani = new System.Windows.Forms.Label();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.timer_hareketZamani = new System.Windows.Forms.Timer(this.components);
            this.checkBox_acilistaCalistir = new System.Windows.Forms.CheckBox();
            this.notifyIcon_mouse = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_mouse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_cikis = new System.Windows.Forms.Button();
            this.timer_gecenSure = new System.Windows.Forms.Timer(this.components);
            this.label_gun = new System.Windows.Forms.Label();
            this.contextMenuStrip_mouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_zamaniGoster
            // 
            this.timer_zamaniGoster.Interval = 1000;
            this.timer_zamaniGoster.Tick += new System.EventHandler(this.timer_zamaniGoster_Tick);
            // 
            // lbl_tarihsaat
            // 
            this.lbl_tarihsaat.AutoSize = true;
            this.lbl_tarihsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarihsaat.Location = new System.Drawing.Point(47, 9);
            this.lbl_tarihsaat.Name = "lbl_tarihsaat";
            this.lbl_tarihsaat.Size = new System.Drawing.Size(202, 26);
            this.lbl_tarihsaat.TabIndex = 0;
            this.lbl_tarihsaat.Text = "gg.aa.yyyy ss.dd.ss";
            // 
            // calismaZamani
            // 
            this.calismaZamani.AutoSize = true;
            this.calismaZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calismaZamani.Location = new System.Drawing.Point(67, 35);
            this.calismaZamani.Name = "calismaZamani";
            this.calismaZamani.Size = new System.Drawing.Size(160, 26);
            this.calismaZamani.TabIndex = 1;
            this.calismaZamani.Text = "Çalışma Süresi";
            // 
            // lbl_calismaZamani
            // 
            this.lbl_calismaZamani.AutoSize = true;
            this.lbl_calismaZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_calismaZamani.Location = new System.Drawing.Point(161, 61);
            this.lbl_calismaZamani.Name = "lbl_calismaZamani";
            this.lbl_calismaZamani.Size = new System.Drawing.Size(92, 26);
            this.lbl_calismaZamani.TabIndex = 2;
            this.lbl_calismaZamani.Text = "ss.dd.ss";
            this.lbl_calismaZamani.Click += new System.EventHandler(this.lbl_calismaZamani_Click);
            // 
            // btn_baslat
            // 
            this.btn_baslat.Location = new System.Drawing.Point(52, 90);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(90, 25);
            this.btn_baslat.TabIndex = 3;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // btn_durdur
            // 
            this.btn_durdur.Location = new System.Drawing.Point(159, 90);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(90, 25);
            this.btn_durdur.TabIndex = 4;
            this.btn_durdur.Text = "Durdur";
            this.btn_durdur.UseVisualStyleBackColor = true;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // timer_hareketZamani
            // 
            this.timer_hareketZamani.Interval = 420000;
            this.timer_hareketZamani.Tick += new System.EventHandler(this.timer_hareketZamani_Tick);
            // 
            // checkBox_acilistaCalistir
            // 
            this.checkBox_acilistaCalistir.AutoSize = true;
            this.checkBox_acilistaCalistir.Location = new System.Drawing.Point(52, 123);
            this.checkBox_acilistaCalistir.Name = "checkBox_acilistaCalistir";
            this.checkBox_acilistaCalistir.Size = new System.Drawing.Size(201, 17);
            this.checkBox_acilistaCalistir.TabIndex = 5;
            this.checkBox_acilistaCalistir.Text = "Bilgisayar açıldığında programı çalıştır.";
            this.checkBox_acilistaCalistir.UseVisualStyleBackColor = true;
            this.checkBox_acilistaCalistir.CheckedChanged += new System.EventHandler(this.checkBox_acilistaCalistir_CheckedChanged);
            // 
            // notifyIcon_mouse
            // 
            this.notifyIcon_mouse.ContextMenuStrip = this.contextMenuStrip_mouse;
            this.notifyIcon_mouse.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_mouse.Icon")));
            this.notifyIcon_mouse.Text = "Mouse Hareketlendirme";
            this.notifyIcon_mouse.Visible = true;
            // 
            // contextMenuStrip_mouse
            // 
            this.contextMenuStrip_mouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.başlatToolStripMenuItem,
            this.durdurToolStripMenuItem});
            this.contextMenuStrip_mouse.Name = "contextMenuStrip_mouse";
            this.contextMenuStrip_mouse.Size = new System.Drawing.Size(112, 70);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // durdurToolStripMenuItem
            // 
            this.durdurToolStripMenuItem.Name = "durdurToolStripMenuItem";
            this.durdurToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.durdurToolStripMenuItem.Text = "Durdur";
            this.durdurToolStripMenuItem.Click += new System.EventHandler(this.durdurToolStripMenuItem_Click);
            // 
            // button_cikis
            // 
            this.button_cikis.Location = new System.Drawing.Point(108, 148);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Size = new System.Drawing.Size(75, 23);
            this.button_cikis.TabIndex = 6;
            this.button_cikis.Text = "Çıkış";
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // timer_gecenSure
            // 
            this.timer_gecenSure.Interval = 1000;
            this.timer_gecenSure.Tick += new System.EventHandler(this.timer_gecenSure_Tick);
            // 
            // label_gun
            // 
            this.label_gun.AutoSize = true;
            this.label_gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_gun.Location = new System.Drawing.Point(47, 61);
            this.label_gun.Name = "label_gun";
            this.label_gun.Size = new System.Drawing.Size(42, 26);
            this.label_gun.TabIndex = 7;
            this.label_gun.Text = "gg.";
            this.label_gun.Click += new System.EventHandler(this.label_dun_Click);
            // 
            // MouseHareketlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 183);
            this.Controls.Add(this.label_gun);
            this.Controls.Add(this.button_cikis);
            this.Controls.Add(this.checkBox_acilistaCalistir);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.lbl_calismaZamani);
            this.Controls.Add(this.calismaZamani);
            this.Controls.Add(this.lbl_tarihsaat);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MouseHareketlendirme";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Mouse Hareketlendirme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MouseHareketlendirme_FormClosing);
            this.Load += new System.EventHandler(this.MouseHareketlendirme_Load);
            this.contextMenuStrip_mouse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_zamaniGoster;
        private System.Windows.Forms.Label lbl_tarihsaat;
        private System.Windows.Forms.Label calismaZamani;
        private System.Windows.Forms.Label lbl_calismaZamani;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.Timer timer_hareketZamani;
        private System.Windows.Forms.CheckBox checkBox_acilistaCalistir;
        private System.Windows.Forms.NotifyIcon notifyIcon_mouse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_mouse;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durdurToolStripMenuItem;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Timer timer_gecenSure;
        private System.Windows.Forms.Label label_gun;
    }
}

