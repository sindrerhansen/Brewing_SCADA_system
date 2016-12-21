using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace BryggeprogramWPF.VoiceControll
{
    public class SpeechRecognition
    {
        SpeechRecognitionEngine speechRecognitionEngin; 
        //private static SpeechRecognitionEngine sr = new SpeechRecognitionEngine(new CultureInfo("nb-NO"));
        public SpeechRecognition()
        {
            speechRecognitionEngin = new SpeechRecognitionEngine();
        }


        public void Enable()
        {
            speechRecognitionEngin.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void Disable()
        {
            speechRecognitionEngin.RecognizeAsyncStop();
        }

        private void Init()
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "Exit program", "start counting", "Stop", "set counting speed" });

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(commands);

            // Create the Grammar instance.
            Grammar g = new Grammar(gb);
            speechRecognitionEngin.LoadGrammarAsync(g);
            speechRecognitionEngin.SetInputToDefaultAudioDevice();
            speechRecognitionEngin.SpeechRecognized += SpeechRecognitionEngin_SpeechRecognized;
        }

        private void SpeechRecognitionEngin_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
