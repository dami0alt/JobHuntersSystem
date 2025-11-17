using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace SpeechUnit
{
    public class SpeechManager
    {

        private  SpeechRecognitionEngine recognizer;
        private  Dictionary<string, Action> commands;
        private  Form parentForm;
        private Image userProfileImage;
        /*private  string currentUser;*/

        public SpeechManager(Form form, Image profilePic )
        {
            parentForm = form;
            /* currentUser = user;*/
            userProfileImage = profilePic;

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
                /*
                { "user info", ShowUserInfo }
                */
            };
        }

        private void ConfigureRecognizer()
        {
            Choices words = new Choices(commands.Keys.ToArray());
            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = recognizer.RecognizerInfo.Culture;
            gb.Append(words);

            Grammar grammar = new Grammar(gb);
            grammar.Name = "SecureCoreVoiceCommands";
            recognizer.LoadGrammarAsync(grammar);

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;

            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string command = e.Result.Text.ToLower();

            if (commands.ContainsKey(command))
            {
                commands[command].Invoke();
            }
        }

        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
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
                MessageBox.Show($"Current time: {hour}", "System Time",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }

        /*private void ShowUserInfo()
        {
            parentForm.Invoke(new Action(() =>
    {
        string username = "User";       // tú lo cambiarás luego
        string category = "Category";   // idem
        string rank = "Rank";           // idem

        UserCardForm card = new UserCardForm(username, category, rank, userProfileImage);
        card.ShowDialog(parentForm);
    }));
        }
        */

        public void Stop()
        {
            recognizer.RecognizeAsyncStop();
            recognizer.Dispose();
        }
    }
}
