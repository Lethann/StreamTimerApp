using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace StreamTimerApp
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;
        private int _currentSeconds;
        private int currentSeconds
        {
            get
            {
                return _currentSeconds;
            }
            set
            {
                _currentSeconds = value;

                DateTime currentTime = new DateTime();
                currentTime = currentTime.AddSeconds(_currentSeconds);

                string outputFull = String.Format("{0} - {1}", currentTime.ToString("mm:ss"), txtMessage.Text);

                lblCurrent.Text = outputFull;
                toolSimple.Text = outputFull;


                writeFile(txtOutputFile.Text, outputFull);
            }
        }

        private void InitializeSound()
        {
            player = new SoundPlayer();
            player.LoadCompleted += new AsyncCompletedEventHandler(player_LoadCompleted);
            player.SoundLocationChanged += new EventHandler(player_LocationChanged);

        }
        public Form1()
        {
            InitializeComponent();
            InitializeSound();
        }



        private void txtOutputFile_MouseHover(object sender, EventArgs e)
        {
            toolHoverTip.Text = "Text File Location";
        }

        private void txtOutputFile_MouseLeave(object sender, EventArgs e)
        {
            toolHoverTip.Text = "";
        }

        private void txtDuration_MouseHover(object sender, EventArgs e)
        {
            toolHoverTip.Text = "Timer Duration in Minutes";
        }

        private void txtDuration_MouseLeave(object sender, EventArgs e)
        {
            toolHoverTip.Text = "";
        }


        private void txtMessage_MouseHover(object sender, EventArgs e)
        {
            toolHoverTip.Text = "Text to appear with timer";
        }

        private void txtMessage_MouseLeave(object sender, EventArgs e)
        {
            toolHoverTip.Text = "";
        }

        private void txtSoundFile_MouseHover(object sender, EventArgs e)
        {
            toolHoverTip.Text = "WAV file to be played at the end of the timer";
        }

        private void txtSoundFile_MouseLeave(object sender, EventArgs e)
        {
            toolHoverTip.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var currentfile = txtOutputFile.Text;
            saveFileOutput.FileName = currentfile;
            var result = saveFileOutput.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtOutputFile.Text = saveFileOutput.FileName;
            }
        }

        private void btnSound_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckFileExists = true;
            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";
       
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.txtSoundFile.Text = dlg.FileName;
                player.SoundLocation = txtSoundFile.Text;
            }
        } 

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (currentSeconds == 0)
            {
                StartTheClock();

            }
            else
            {
                currentSeconds -= 1;
                if (currentSeconds == 0)
                {
                    timerCountdown.Interval = 5000;
                    lblCurrent.Text = "Finished";
                    if (player.SoundLocation != string.Empty)
                    {
                        player.Play();
                    }
                     
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTheClock();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerCountdown.Stop();
            player.Stop();
            ReportStatus("Timer Stopped");
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {


        }
        private void StartTheClock()
        {
            int newMinutes;

            if (int.TryParse(txtDuration.Text, out newMinutes))
            {
                currentSeconds = newMinutes * 60;
            }
            timerCountdown.Interval = 1000;
            timerCountdown.Start();
        }

        private void writeFile(string fileName, string currentTime)
        {
            try
            {
                File.WriteAllText(fileName, currentTime);
            }
            catch
            {
                timerCountdown.Stop();
                lblCurrent.Text = "Error No File";
                toolSimple.Text = "Error No File";
                MessageBox.Show("Error: No Output Text File Selected.");
            }


        }
        private void ReportStatus(string statusMessage)
        {
            if (!string.IsNullOrEmpty(statusMessage))
            {
                this.toolHoverTip.Text = statusMessage;
            }
        }
        private void player_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string message = String.Format("Sound Selected: {0}", this.txtSoundFile.Text);
            ReportStatus(message);
        }

        private void player_LocationChanged(object sender, EventArgs e)
        {
            string message = String.Format("Sound Selected: {0}", player.SoundLocation);
            ReportStatus(message);
        }

        private void Instructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoundFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
