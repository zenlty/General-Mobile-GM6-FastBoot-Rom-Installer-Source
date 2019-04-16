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
using System.Diagnostics;

namespace GM_6_FastBoot_Rom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Barış MIZRAKLI tarafından GsmTurkey.net adına kodlanmıştır . Başka kaynaklarda paylaşılması yasaktır. !","Bilgilendirme");
            MessageBox.Show("Yönergeleri takip etmeyi unutmayın !","Uyarı");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            /////////////////////////////////////////

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            /////////////////////////////////////////
            if (checkBox1.Checked == true)
            {
                comboBox2.Items.Add("Tek Sim Rom (Full)");
                comboBox2.Items.Add("Çift Sim Rom (Full)");
                label4.Text = "Full Rom Kurmayı Seçtiniz";
                comboBox1.Visible = false;
                comboBox2.Visible = true;
            }
            if (checkBox2.Checked == true)
            {
                comboBox1.Items.Add("Stock Boot Yükle");
                comboBox1.Items.Add("Stock Recovery Yükle");
                comboBox1.Items.Add("Stock Logo");
                label4.Text = "Parçalı Rom Kurmayı Seçtiniz";
                comboBox1.Visible = true;
                comboBox2.Visible = false;


            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                label4.Text = "Lütfen sadece bir adet seçim yapınız !";
                comboBox1.Visible = false;
                comboBox2.Visible = false;

            }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {

                label4.Text=("Lütfen Bir Seçim Yapınız ! ");
                comboBox1.Visible = false;
                comboBox2.Visible = false;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alarak Bağlayınız", "Uyarı");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " flash boot boot.img";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " flash recovery recovery.img";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " flash logo logo.bin;";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                if (comboBox2.SelectedIndex == 0)
                {
                    Process process = new Process();
                    Process process2 = new Process();
                    Process process3 = new Process();
                    Process process4 = new Process();
                    Process process5 = new Process();
                    Process process6 = new Process();
                    Process process7 = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    ProcessStartInfo startInfo3 = new ProcessStartInfo();
                    ProcessStartInfo startInfo4 = new ProcessStartInfo();
                    ProcessStartInfo startInfo5 = new ProcessStartInfo();
                    ProcessStartInfo startInfo6 = new ProcessStartInfo();
                    ProcessStartInfo startInfo7 = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo2.CreateNoWindow = true;
                    startInfo3.CreateNoWindow = true;
                    startInfo4.CreateNoWindow = true;
                    startInfo5.CreateNoWindow = true;
                    startInfo6.CreateNoWindow = true;
                    startInfo7.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo2.UseShellExecute = false;
                    startInfo3.UseShellExecute = false;
                    startInfo4.UseShellExecute = false;
                    startInfo5.UseShellExecute = false;
                    startInfo6.UseShellExecute = false;
                    startInfo7.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo2.RedirectStandardOutput = true;
                    startInfo3.RedirectStandardOutput = true;
                    startInfo4.RedirectStandardOutput = true;
                    startInfo5.RedirectStandardOutput = true;
                    startInfo6.RedirectStandardOutput = true;
                    startInfo7.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo2.FileName = "fastboot.exe";
                    startInfo3.FileName = "fastboot.exe";
                    startInfo4.FileName = "fastboot.exe";
                    startInfo5.FileName = "fastboot.exe";
                    startInfo6.FileName = "fastboot.exe";
                    startInfo7.FileName = "fastboot.exe";

                    startInfo.Arguments = " flash system teksim.img ";
                    startInfo2.Arguments = " flash boot boot.img ";
                    startInfo3.Arguments = " flash cache cache.img";
                    startInfo4.Arguments = " flash userdata userdata.img";
                    startInfo5.Arguments = " flash logo logo.bin";
                    startInfo6.Arguments = " flash trustzone trustzone.img";
                    startInfo7.Arguments = " flash uboot uboot.img";

                    process.StartInfo = startInfo;
                    process2.StartInfo = startInfo2;
                    process3.StartInfo = startInfo3;
                    process4.StartInfo = startInfo4;
                    process5.StartInfo = startInfo5;
                    process6.StartInfo = startInfo6;
                    process7.StartInfo = startInfo7;

                    process.Start();
                    process2.Start();
                    process3.Start();
                    process4.Start();
                    process5.Start();
                    process6.Start();
                    process7.Start();


                }
                if (comboBox2.SelectedIndex == 1)
                {
                    Process process = new Process();
                    Process process2 = new Process();
                    Process process3 = new Process();
                    Process process4 = new Process();
                    Process process5 = new Process();
                    Process process6 = new Process();
                    Process process7 = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    ProcessStartInfo startInfo2 = new ProcessStartInfo();
                    ProcessStartInfo startInfo3 = new ProcessStartInfo();
                    ProcessStartInfo startInfo4 = new ProcessStartInfo();
                    ProcessStartInfo startInfo5 = new ProcessStartInfo();
                    ProcessStartInfo startInfo6 = new ProcessStartInfo();
                    ProcessStartInfo startInfo7 = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo2.CreateNoWindow = true;
                    startInfo3.CreateNoWindow = true;
                    startInfo4.CreateNoWindow = true;
                    startInfo5.CreateNoWindow = true;
                    startInfo6.CreateNoWindow = true;
                    startInfo7.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo2.UseShellExecute = false;
                    startInfo3.UseShellExecute = false;
                    startInfo4.UseShellExecute = false;
                    startInfo5.UseShellExecute = false;
                    startInfo6.UseShellExecute = false;
                    startInfo7.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo2.RedirectStandardOutput = true;
                    startInfo3.RedirectStandardOutput = true;
                    startInfo4.RedirectStandardOutput = true;
                    startInfo5.RedirectStandardOutput = true;
                    startInfo6.RedirectStandardOutput = true;
                    startInfo7.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo2.FileName = "fastboot.exe";
                    startInfo3.FileName = "fastboot.exe";
                    startInfo4.FileName = "fastboot.exe";
                    startInfo5.FileName = "fastboot.exe";
                    startInfo6.FileName = "fastboot.exe";
                    startInfo7.FileName = "fastboot.exe";

                    startInfo.Arguments = " flash system ciftsim.img ";
                    startInfo2.Arguments = " flash boot boot.img ";
                    startInfo3.Arguments = " flash cache cache.img";
                    startInfo4.Arguments = " flash userdata userdata.img";
                    startInfo5.Arguments = " flash logo logo.bin";
                    startInfo6.Arguments = " flash trustzone trustzone.img";
                    startInfo7.Arguments = " flash uboot uboot.img";

                    process.StartInfo = startInfo;
                    process2.StartInfo = startInfo2;
                    process3.StartInfo = startInfo3;
                    process4.StartInfo = startInfo4;
                    process5.StartInfo = startInfo5;
                    process6.StartInfo = startInfo6;
                    process7.StartInfo = startInfo7;

                    process.Start();
                    process2.Start();
                    process3.Start();
                    process4.Start();
                    process5.Start();
                    process6.Start();
                    process7.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " devices";
            process.StartInfo = startInfo;
            process.Start();
            cihaz.Text = process.StandardOutput.ReadToEnd();
            if (cihaz.Text == process.StandardOutput.ReadToEnd())
            {
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (pictureBox1.BackColor == Color.Red)
            {
                cihaz.Text = ("Cihaz Bağlı Değildir.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gsmturkey.net");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
