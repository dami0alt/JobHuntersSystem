using System;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;
using System.Drawing;
using IdentityUser;

namespace JobHuntersSystem
{
    public class SpeechManager
    {
        private SpeechRecognitionEngine recognizer;
        private frmMain parentForm;

        public bool IsRunning { get; private set; }

        public SpeechManager(frmMain form)
        {
            string[] commands;
            parentForm = form;
            try
            {
                commands = new string[]{ "turn off", "get time", "get info" };
                recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));

                ConfigureRecognizer(commands);
                IsRunning = true;
            }
            catch(Exception ex){
                try
                {
                    recognizer = new SpeechRecognitionEngine(new CultureInfo("es-ES"));
                    commands = new string[] { "apagar", "hora", "información" };

                    ConfigureRecognizer(commands);
                    IsRunning = true;
                }
                catch
                {
                    IsRunning = false;
                }
            }
        }
        private void ConfigureRecognizer(string[] commands)
        {

            Choices words = new Choices(commands);
            GrammarBuilder gb = new GrammarBuilder(words);
            gb.Culture = recognizer.RecognizerInfo.Culture;

            Grammar grammar = new Grammar(gb);
            recognizer.LoadGrammarAsync(grammar);

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            if (e.Result.Confidence < 0.75f)
                return;

            string command = e.Result.Text.ToLower();

            if (command == "turn off")
            {
                CloseApp();
            }
            else if (command == "get time")
            {
                ShowTime();
            }
            else if (command == "get info")
            {
                ShowUserInfo();
            }
        }

        private void CloseApp()
        {
            parentForm.Close();
        }

        private void ShowTime()
        {
            string hour = DateTime.Now.ToString("HH:mm tt");
            MessageBox.Show($"Current time: {hour}", "System Time");
        }

        private void ShowUserInfo()
        {
            var user = CurrentUser.MainUser;

            if (user != null)
            {
                Image profile = null;
                string fullPath = AppDomain.CurrentDomain.BaseDirectory + user.Photo;

                if (System.IO.File.Exists(fullPath))
                    profile = Image.FromFile(fullPath);

                FrmUserInfo form = new FrmUserInfo(
                    user.UserName,
                    user.DescRank,
                    user.DescCategory,
                    profile
                );

                form.ShowDialog();
            }
        }

        /*public void Stop()
        {
            recognizer.RecognizeAsyncStop();
            recognizer.Dispose();
        }*/
    }
}