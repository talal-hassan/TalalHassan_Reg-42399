using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using mshtml;
using System.Net;
using System.Text.RegularExpressions;

namespace NEXI
{
    public partial class WebSearch : Form
    {
        NEXI nexi2;
        SpeechSynthesizer nexiWeb = new SpeechSynthesizer();
        PromptBuilder pbWeb = new PromptBuilder();
        SpeechRecognitionEngine sreWeb = new SpeechRecognitionEngine();


        string[] webSearchCommands;
        string[] webSearchKeywords;
        public WebSearch()
        {
            InitializeComponent();
            try
            {
                sreWeb = createSpeechEngine("en-US");
                sreWeb.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(engine_SpeechRecognized);
                sreWeb.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(WebSearch_SpeechRecognized);


                loadGrammarAndCommands();
                sreWeb.SetInputToDefaultAudioDevice();
                sreWeb.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void engine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speechWeb = e.Result.Text;
            switch(speechWeb)
            {
                case "read":
                    btnCopyScreen.PerformClick();
                    btnPlay.PerformClick(); 
                    break;
                case "read the result":
                case "read the results":
                case "what is the result":
                case "what are the results":
                    GetResults();
                    break;
                case "search":
                    btnSearch.PerformClick();
                    break;
                case "pause":
                case "continue":
                    btnPause.PerformClick();
                    break;
                case "stop":
                    btnStop.PerformClick();
                    break;
                case "close web search":
                    btnCloseWebSearch.PerformClick();
                    nexi2 = new NEXI();
                    break;
                case "hide web search":
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Minimized;
                    TopMost = false;
                    break;
                case "show last search":
                    btnBackward.PerformClick();
                    break;
                case "show web search":
                case "show web search again":
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Normal;
                    TopMost = true;
                    break;
               

            }
        }

        private void loadGrammarAndCommands()
        {
            try
            {
                Choices cListWeb = new Choices();
                string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\DefaultCommands.txt");
                cListWeb.Add(lines);
                Grammar grWeb= new Grammar(new GrammarBuilder(cListWeb));
                sreWeb.LoadGrammar(grWeb);
                try
                {
                    webSearchCommands = File.ReadAllLines(Environment.CurrentDirectory + "\\WebSearchCommands.txt");
                    webSearchKeywords = File.ReadAllLines(Environment.CurrentDirectory + "\\WebSearchKeywords.txt");
                    Grammar webSearchCommandGrammar = new Grammar(new GrammarBuilder(new Choices(webSearchCommands)));
                    sreWeb.LoadGrammarAsync(webSearchCommandGrammar);
                }
                catch (Exception ex)
                {
                nexiWeb.SpeakAsync("I have detected an in valid entry in your web commands" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WebSearch_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            int i = 0;
            try
            {
                foreach (string line in webSearchCommands)
                {
                    if (line == speech)
                    {
                        nexiWeb.SpeakAsync(webSearchKeywords[i]);
                        //name of first textbox
                        textSearchBar.Text = webSearchKeywords[i];
                        //search button
                        btnSearch.PerformClick();
                    }
                    i += 1;
                }
            }
            catch (Exception ex)
            {
                i += 1;
                nexiWeb.SpeakAsync("Please check the " + speech + "web command on line " + i + ". It appears to be missing a proper response." + ex.Message);
            }
        }

        private SpeechRecognitionEngine createSpeechEngine(string prefferedCulture)
        {
            foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
            {
                if (config.Culture.ToString() == prefferedCulture)
                {
                    sreWeb = new SpeechRecognitionEngine(config);
                    break;
                }
            }

            if (sreWeb == null)
            {
                MessageBox.Show("The desired culture is not installed on this machine. The speech engine will continue using " + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + " as the default culture.", "Culture " + prefferedCulture + "not found");
                sreWeb = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
            }
            return sreWeb;
        }

        private void btnCloseWebSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string toSearch = textSearchBar.Text;
     
            webSearchShow.Navigate("https://www.google.com.pk/search?q=" + toSearch);
        }

        private void btnCopyScreen_Click(object sender, EventArgs e)
        {
            IHTMLDocument2 htmlDocument = webSearchShow.Document.DomDocument as IHTMLDocument2;

            IHTMLSelectionObject currentSelection = htmlDocument.selection;
            IHTMLTxtRange range = currentSelection.createRange() as IHTMLTxtRange;
            if (currentSelection != null)
            {
                if(range != null)
                {
                    text.Text = range.text;
                }
            }
        }
        private void GetResults()
        {
            getResult.Items.Clear();
            string url = textSearchBar.Text;
            WebClient webc = new WebClient();
            string page = webc.DownloadString("https://www.google.com/search?q=" + url);
            string news = "<div class=\"b_snippet\">(.*?)</div>";
            news = "<div class=\"b_attribution\">(.*?)</div>";
            news = "<p>(.*?)</p>";
            foreach (Match match in Regex.Matches(page, news))
                getResult.Items.Add(match.Groups[1].Value.Replace("<strong>", " ").Replace("</strong>"," ").Replace("&"," ").Replace("#"," "));
            foreach(string readItems in getResult.Items)
            {
                nexiWeb.SpeakAsync(readItems);
            }

            
        }
       

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(nexiWeb.State == SynthesizerState.Speaking)
            {
                nexiWeb.Pause();
                btnPause.Text = "CONTINUE";
            }
            else
            {
                if(nexiWeb.State == SynthesizerState.Paused)
                {
                    nexiWeb.Resume();
                    btnPause.Text = "PAUSE";
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(nexiWeb.State == SynthesizerState.Paused)
            {
                nexiWeb.Resume();
                nexiWeb.SpeakAsyncCancelAll();
                btnStop.Text = "STOP";
                btnPlay.Enabled = true;

            }
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            webSearchShow.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webSearchShow.GoForward();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnCopyScreen.PerformClick();
            //btnPlay.PerformClick();
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            nexiWeb.SpeakAsync(text.Text);
        }
    }
}
