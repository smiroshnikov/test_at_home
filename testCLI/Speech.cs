using System;
using System.Globalization;
using System.Speech.Synthesis;

namespace testCLI.Properties
{
    public static class Speech
    {
        private static void Main2(string[] args)
        {
            // Initialize a new instance of the SpeechSynthesizer.
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Configure the audio output. 
                synth.SetOutputToDefaultAudioDevice();

                // Speak a string synchronously.
                synth.Speak("What is your favorite color?");
//                synth.Speak("Трой ! Я сьем рыбку  ! ");
//                synth.Speak(" טרוי שלום !  ");
                Console.WriteLine(synth.GetInstalledVoices());
//                Console.WriteLine(synth.GetCurrentlySpokenPrompt());
                
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}