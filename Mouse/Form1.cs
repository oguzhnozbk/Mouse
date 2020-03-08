using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Mouse
{
    public partial class MouseHareketlendirme : Form
    {

        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

        DateTime a = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        double i = 0;
        TimeSpan time;
        public MouseHareketlendirme()
        {
            InitializeComponent();
            try
            {
                if (key.GetValue("MouseHareketlendirme").ToString() == "\"" + Application.ExecutablePath + "\"")
                {                
                    checkBox_acilistaCalistir.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void MouseHareketlendirme_Load(object sender, EventArgs e)
        {
            timer_zamaniGoster.Start();
            timer_hareketZamani.Start();
            timer_gecenSure.Start();
        }
        private void MouseHareketlendirme_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIcon_mouse.Visible = true;
            this.Hide();
        }
        private void timer_zamaniGoster_Tick(object sender, EventArgs e)
        {
            lbl_tarihsaat.Text = DateTime.Now.ToString();
            
        }
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        int k = 0 , m = 1000;
        private void timer_hareketZamani_Tick(object sender, EventArgs e)
        {
            if (k <= 500)
            { SetCursorPos(k += 10, k += 10); if (k == 1000) m = 1000; }
            else
            { SetCursorPos(m -= 10, m -= 10); if (m < 0) k = 0; }
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            i = 0;
            timer_hareketZamani.Start();
            timer_gecenSure.Start();
        }

        private void checkBox_acilistaCalistir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_acilistaCalistir.Checked)

            { 
                key.SetValue("MouseHareketlendirme", "\"" + Application.ExecutablePath + "\"");
                button_cikis.Visible = false;
            }
            else
            {  
                key.DeleteValue("MouseHareketlendirme");
                button_cikis.Visible = true;
            }
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon_mouse.Visible = false;
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i = 0;
            timer_hareketZamani.Start();
            timer_gecenSure.Start();
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_hareketZamani.Stop();
            timer_gecenSure.Stop();
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        double gunsayisi =0;
        private void timer_gecenSure_Tick(object sender, EventArgs e)
        {
            time = TimeSpan.FromSeconds(i++);
            lbl_calismaZamani.Text = time.ToString();
            if (i == 86399)
            { i = 0; gunsayisi++; }
            label_gun.Text = gunsayisi + "  gün,";

        }

        private void lbl_calismaZamani_Click(object sender, EventArgs e)
        {

        }

        private void label_dun_Click(object sender, EventArgs e)
        {

        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            timer_hareketZamani.Stop();
            timer_gecenSure.Stop();
        }
    }
}
