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

        public SpeechManager(frmMain form)
        {
            parentForm = form;
            recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));

            ConfigureRecognizer();
        }

        private void ConfigureRecognizer()
        {
            string[] commands = { "close", "time", "user" };
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
            string command = e.Result.Text.ToLower();

            if (command == "close")
            {
                CloseApp();
            }
            else if (command == "time")
            {
                ShowTime();
            }
            else if (command == "user")
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
            string hour = DateTime.Now.ToString("hh:mm tt");
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

        public void Stop()
        {
            recognizer.RecognizeAsyncStop();
            recognizer.Dispose();
        }
    }
}