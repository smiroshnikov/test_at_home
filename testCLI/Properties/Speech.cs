using System;
using System.Speech.Synthesis;

namespace testCLI.Properties
{
    public class Speech
    {
        static void Main(string[] args)
        {
            // Initialize a new instance of the SpeechSynthesizer.
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Configure the audio output. 
                synth.SetOutputToDefaultAudioDevice();

                // Speak a string synchronously.
                //synth.Speak("What is your favorite color?");
                synth.Speak("Трой ! Иди Спать ! ");
                synth.Speak("Трой ! Я заберу твои машинки и игрушки  ! ");
                synth.Speak("Трой ! Я заберу маму и папу и все все конфетки !  ! ");
                
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}