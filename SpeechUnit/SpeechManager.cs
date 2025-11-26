using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Windows.Forms;
using System.Globalization;
using IdentityUser;

namespace SpeechUnit
{
    public class SpeechManager
    {
        private SpeechRecognitionEngine recognizer;
        private Dictionary<string, Action> commands;
        private Form parentForm;

        public event Action<User> OnUserInfoRequested;

        public SpeechManager(Form form)
        {
            parentForm = form;
            recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));

            InitializeCommands();
            ConfigureRecognizer();
        }

        private void InitializeCommands()
        {
            commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase)
            {
                { "close", CloseApp },
                { "time", ShowTime },
                { "user info", ShowUserInfo }
            };
        }

        private void ConfigureRecognizer()
        {
            Choices words = new Choices(commands.Keys.ToArray());
            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = recognizer.RecognizerInfo.Culture;
            gb.Append(words);

            Grammar grammar = new Grammar(gb);
            recognizer.LoadGrammarAsync(grammar);

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string command = e.Result.Text.ToLower();

            if (commands.ContainsKey(command))
                commands[command].Invoke();
        }

        private void CloseApp()
        {
            parentForm.Invoke(new Action(() =>
            {
                parentForm.Close();
                Application.Exit();
            }));
        }

        private void ShowTime()
        {
            string hour = DateTime.Now.ToString("hh:mm tt");
            parentForm.Invoke(new Action(() =>
            {
                MessageBox.Show($"Current time: {hour}", "System Time");
            }));
        }

        private void ShowUserInfo()
        {
            User user = CurrentUser.MainUser;

            if (user != null && OnUserInfoRequested != null)
            {
                OnUserInfoRequested(user);
            }
        }

        public void Stop()
        {
            recognizer.RecognizeAsyncStop();
            recognizer.Dispose();
        }
    }
}