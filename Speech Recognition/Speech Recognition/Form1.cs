using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace Speech_Recognition
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices cList = new Choices();
        Process[] process;
        //NotifyIcon icon = new NotifyIcon();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            cList.Add("exit sticky note","take a shot","exit chrome","exit word","nexi","hi nexi","hello", "open word","open power point", "how are you", "what is the current time", "open sticky note","open chrome", "open visual studio", "thank you", "close", "exit power point");
            Grammar gr = new Grammar(new GrammarBuilder(cList));


            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void captureIt()
        {
            Bitmap capture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(capture as Image);
            g.CopyFromScreen(0,0,0,0, capture.Size);
            capture.Save("image.jpeg", ImageFormat.Jpeg);
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            
            //sre.BabbleTimeout("10");
            switch (e.Result.Text.ToString())
            {
                case "hello":
                case "hi nexi":
                case "nexi":
                    ss.SpeakAsync("hello Talal");
                    break;
                case "how are you":
                    ss.SpeakAsync("i am good. Thanks for asking");
                    break;
                case "what is the current time":
                    ss.SpeakAsync("Current time is" + DateTime.Now.ToLongTimeString());
                    break;
                case "open chrome":
                    ss.SpeakAsync("Opening Chrome"); Process.Start("chrome", "https://www.google.com");
                    break;
                case "thank you":
                    ss.SpeakAsync("pleasure is mine Talal");
                    break;
                case "close":
                    ss.SpeakAsync("closing"); Application.Exit();
                    break;
                case "open sticky note":
                    ss.SpeakAsync("Opening sticky note"); System.Diagnostics.Process.Start(@"C:\\Windows\\Sysnative\\StikyNot.exe");
                    break;
                case "open word":
                    ss.SpeakAsync("opening microsoft word"); Process.Start("winword");
                    break;
                case "open power point":
                    ss.SpeakAsync("opening microsoft powerpoint"); Process.Start("powerpnt");
                    break;
                case "open visual studio":
                    ss.SpeakAsync("opening visual studio"); Process.Start("denev");
                    break;
                case "exit word":
                    {
                        ss.SpeakAsync("closing word");
                        //Process.Kill("winword");
                        process = Process.GetProcessesByName("winword");
                        foreach(Process w in process)
                        {
                            w.Kill();
                        }
                        break;
                    }
                case "exit sticky note":
                    {
                        ss.SpeakAsync("closing sticky note");
                        process = Process.GetProcessesByName(@"C:\\Windows\\Sysnative\\StikyNot.exe");
                        foreach(Process s in process)
                        {
                            s.Kill();
                        }
                        break;
                    }
                case "exit chrome":
                    {
                        ss.SpeakAsync("closing chrome");
                        process = Process.GetProcessesByName("chrome");
                        foreach (Process c in process)
                        {
                            c.Kill();
                        }
                        break;

                    }
                case "take a shot":
                    {
                        ss.SpeakAsync("taking shot");
                        captureIt();
                        break;
                    }
                //default:
                    
                //    foreach (RecognizedPhrase phrase in e.Result.Alternates)
                //    {
                //        ss.SpeakAsync("Rejected phrase" + phrase.Text);
                //    }
                //    //ss.SpeakAsync("Cannot understand that. Do you want me to add this in my data set");
                //    break;


            }
            commandBox.Text += e.Result.Text.ToString() + Environment.NewLine;


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if(this.WindowState== FormWindowState.Minimized)
            {
                
                notifyIcon1.ShowBalloonTip(1000,"NEXI Running","Say HI NEXI to activate",ToolTipIcon.Info);
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
