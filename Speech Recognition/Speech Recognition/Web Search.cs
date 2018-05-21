using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;


namespace Speech_Recognition
{
    public partial class Web_Search : Form
    {
        SpeechRecognitionEngine sre = null;
        SpeechSynthesizer ss = new SpeechSynthesizer();

        String[] webSearchCommands;
        String[] webKeywordSearch;

        public Web_Search()
        {
            InitializeComponent();
            try
            {
                sre = createSpeechEngine("en-US");
                sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(WebSearch_SpeechRecognized);

                loadGrammarAndCommands();
                sre.SetInputToDefaultAudioDevice();

                sre.RecognizeAsync(RecognizeMode.Multiple);
                webSearchCommands = File.ReadAllLines(Environment.CurrentDirectory + "\\WebSearchCommands.txt");
                webKeywordSearch = File.ReadAllLines(Environment.CurrentDirectory + "\\WebKeywords.txt");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void loadGrammarAndCommands()
        {
        //    try
        //    {
        //        Choices text = new Choices();
        //        string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\DefaultCommands.txt");
        //        text.Add(lines);
        //        Grammar gr = new Grammar(new GrammarBuilder(text));
        //        sre.LoadGrammar(gr);
        //        //try
        //        //{

        //        //}
        //        // = new Grammar(new GrammarBuilder(new Choices(webSearchCommands)));
        //        //sre.LoadGrammarAsync();
        //    }
        //    catch()
        //    {

        //    }
        }

        private void WebSearch_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            int i = 0;
            try
            {
                foreach(string line in webSearchCommands)
                {
                    if (line == speech)
                    {
                        ss.SpeakAsync(webKeywordSearch[i]);
                        //name of first textbox
                        keyWords.Text = webKeywordSearch[i];
                        //search button
                        btnSearch.PerformClick();
                    }
                    i += 1;
                }
            }
            catch(Exception ex)
            {
                i += 1;
                ss.SpeakAsync("Please check the " + speech + "web command on line " + i + ". It appears to be missing a proper response." + ex.Message);
            }
        }

        private SpeechRecognitionEngine createSpeechEngine(string prefferedCulture)
        {

            foreach(RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
            {
                if(config.Culture.ToString() == prefferedCulture)
                {
                    sre = new SpeechRecognitionEngine(config);
                    break;
                }
            }

            if(sre == null)
            {
                MessageBox.Show("The desired culture is not installed on this machine. The speech engine will continue using " + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + " as the default culture.", "Culture " + prefferedCulture + "not found");
                sre = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
            }
            return sre;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
