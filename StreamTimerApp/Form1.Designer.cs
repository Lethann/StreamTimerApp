
namespace StreamTimerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.saveFileOutput = new System.Windows.Forms.SaveFileDialog();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSimpleTimer = new System.Windows.Forms.TabPage();
            this.btnSound = new System.Windows.Forms.Button();
            this.lblSound = new System.Windows.Forms.Label();
            this.txtSoundFile = new System.Windows.Forms.TextBox();
            this.tabMultiTimer = new System.Windows.Forms.TabPage();
            this.ComingSoon = new System.Windows.Forms.TextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSimple = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolHoverTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileSound = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabSimpleTimer.SuspendLayout();
            this.tabMultiTimer.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(98, 109);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(203, 23);
            this.txtMessage.TabIndex = 23;
            this.txtMessage.MouseLeave += new System.EventHandler(this.txtMessage_MouseLeave);
            this.txtMessage.MouseHover += new System.EventHandler(this.txtMessage_MouseHover);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(39, 112);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 15);
            this.lblMessage.TabIndex = 27;
            this.lblMessage.Text = "Message";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(98, 231);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(47, 15);
            this.lblCurrent.TabIndex = 26;
            this.lblCurrent.Text = "Current";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(226, 178);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 25;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(98, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(42, 83);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 15);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "Minutes";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(98, 80);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(71, 23);
            this.txtDuration.TabIndex = 22;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            this.txtDuration.MouseLeave += new System.EventHandler(this.txtDuration_MouseLeave);
            this.txtDuration.MouseHover += new System.EventHandler(this.txtDuration_MouseHover);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(307, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(98, 51);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(203, 23);
            this.txtOutputFile.TabIndex = 20;
            this.txtOutputFile.MouseLeave += new System.EventHandler(this.txtOutputFile_MouseLeave);
            this.txtOutputFile.MouseHover += new System.EventHandler(this.txtOutputFile_MouseHover);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(26, 54);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(66, 15);
            this.lblOutput.TabIndex = 19;
            this.lblOutput.Text = "Output File";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSimpleTimer);
            this.tabControl1.Controls.Add(this.tabMultiTimer);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 310);
            this.tabControl1.TabIndex = 28;
            // 
            // tabSimpleTimer
            // 
            this.tabSimpleTimer.Controls.Add(this.btnSound);
            this.tabSimpleTimer.Controls.Add(this.lblSound);
            this.tabSimpleTimer.Controls.Add(this.txtSoundFile);
            this.tabSimpleTimer.Controls.Add(this.btnBrowse);
            this.tabSimpleTimer.Controls.Add(this.lblCurrent);
            this.tabSimpleTimer.Controls.Add(this.lblMessage);
            this.tabSimpleTimer.Controls.Add(this.btnStop);
            this.tabSimpleTimer.Controls.Add(this.txtMessage);
            this.tabSimpleTimer.Controls.Add(this.btnStart);
            this.tabSimpleTimer.Controls.Add(this.txtOutputFile);
            this.tabSimpleTimer.Controls.Add(this.lblOutput);
            this.tabSimpleTimer.Controls.Add(this.txtDuration);
            this.tabSimpleTimer.Controls.Add(this.lblDuration);
            this.tabSimpleTimer.Location = new System.Drawing.Point(4, 24);
            this.tabSimpleTimer.Name = "tabSimpleTimer";
            this.tabSimpleTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimpleTimer.Size = new System.Drawing.Size(508, 282);
            this.tabSimpleTimer.TabIndex = 0;
            this.tabSimpleTimer.Text = "Simple Timer";
            this.tabSimpleTimer.UseVisualStyleBackColor = true;
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(308, 138);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(75, 23);
            this.btnSound.TabIndex = 30;
            this.btnSound.Text = "Browse";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(18, 144);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(64, 15);
            this.lblSound.TabIndex = 29;
            this.lblSound.Text = "End Sound";
            // 
            // txtSoundFile
            // 
            this.txtSoundFile.Location = new System.Drawing.Point(98, 139);
            this.txtSoundFile.Name = "txtSoundFile";
            this.txtSoundFile.Size = new System.Drawing.Size(203, 23);
            this.txtSoundFile.TabIndex = 28;
            this.txtSoundFile.TextChanged += new System.EventHandler(this.txtSoundFile_TextChanged);
            this.txtSoundFile.MouseLeave += new System.EventHandler(this.txtSoundFile_MouseLeave);
            this.txtSoundFile.MouseHover += new System.EventHandler(this.txtSoundFile_MouseHover);
            // 
            // tabMultiTimer
            // 
            this.tabMultiTimer.Controls.Add(this.ComingSoon);
            this.tabMultiTimer.Location = new System.Drawing.Point(4, 24);
            this.tabMultiTimer.Name = "tabMultiTimer";
            this.tabMultiTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabMultiTimer.Size = new System.Drawing.Size(508, 282);
            this.tabMultiTimer.TabIndex = 1;
            this.tabMultiTimer.Text = "Multi Timer";
            this.tabMultiTimer.UseVisualStyleBackColor = true;
            // 
            // ComingSoon
            // 
            this.ComingSoon.Location = new System.Drawing.Point(58, 35);
            this.ComingSoon.Multiline = true;
            this.ComingSoon.Name = "ComingSoon";
            this.ComingSoon.ReadOnly = true;
            this.ComingSoon.Size = new System.Drawing.Size(385, 126);
            this.ComingSoon.TabIndex = 0;
            this.ComingSoon.Text = "Future Feature!\r\n\r\nMulti Timer will allow you to have multiple timers with differ" +
    "ent durations and messages as well as playing sounds.";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.txtInstructions);
            this.tabAbout.Controls.Add(this.lblAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 24);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(508, 282);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.SystemColors.Window;
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructions.Location = new System.Drawing.Point(72, 97);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(372, 138);
            this.txtInstructions.TabIndex = 1;
            this.txtInstructions.Text = resources.GetString("txtInstructions.Text");
            this.txtInstructions.TextChanged += new System.EventHandler(this.Instructions_TextChanged);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(72, 8);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(225, 60);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "Stream Timer App\r\ncreated by: Lethann Aeda\r\n\r\nFor help and support please go to g" +
    "ithub.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSimple,
            this.toolHoverTip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(517, 24);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSimple
            // 
            this.toolSimple.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolSimple.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolSimple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSimple.Name = "toolSimple";
            this.toolSimple.Size = new System.Drawing.Size(80, 19);
            this.toolSimple.Text = "Simple Timer";
            // 
            // toolHoverTip
            // 
            this.toolHoverTip.Name = "toolHoverTip";
            this.toolHoverTip.Size = new System.Drawing.Size(0, 19);
            // 
            // openFileSound
            // 
            this.openFileSound.FileName = "openFileSound";
            this.openFileSound.Filter = "Wav Files Only (*.wav)|*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 338);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "StreamTimerApp";
            this.tabControl1.ResumeLayout(false);
            this.tabSimpleTimer.ResumeLayout(false);
            this.tabSimpleTimer.PerformLayout();
            this.tabMultiTimer.ResumeLayout(false);
            this.tabMultiTimer.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.SaveFileDialog saveFileOutput;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSimpleTimer;
        private System.Windows.Forms.TabPage tabMultiTimer;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.TextBox txtSoundFile;
        private System.Windows.Forms.TextBox ComingSoon;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.OpenFileDialog openFileSound;
        private System.Windows.Forms.ToolStripStatusLabel toolSimple;
        private System.Windows.Forms.ToolStripStatusLabel toolHoverTip;
    }
}

