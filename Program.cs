using System;
using System.Collections.Generic;
using static System.Console;

namespace VokabelTrainer
{
    static class Program
    {
        static List<Vocabulary> vocabluraryList = new List<Vocabulary>();
        public static void Main(string[] args)
        {
            WriteLine("Willkommen zu Bens Vokabeltrainer!");
            WriteLine("Drücke eine beliebige Taste um forzufahren");
            ReadKey();

            while (true){
                WriteLine(Text.Hauptmenü);
                string Input = ReadLine();

                if (Input == "1")
                {
                    ProgrammNewVocabulary();
                }
                if (Input == "2")
                {

                }
                foreach (Vocabulary aVocabulary in vocabluraryList)
                {
                    WriteLine(aVocabulary);
                }
            }
            
        }

        static void AddVocabulary(List<Vocabulary> list, string word, string translation, float progress)
        {
            list.Add(new Vocabulary() { Word = word, Translation = translation, Progress = progress });
        }

        static void DeleteVocabulary(List<Vocabulary> list, Vocabulary vocabulary)
        {
            list.Remove(vocabulary);
        }
        

        #region Programms
        static void ProgrammNewVocabulary()
        {
            string word;
            string translation;
            WriteLine("Gebe die Deutsche Vokabel ein:");
            word = ReadLine();
            WriteLine("Gebe die Übersetzung ein:");
            translation = ReadLine();

            AddVocabulary(vocabluraryList, word, translation, 0f);


        }

        static void ProgrammDeleteVocabulary()
        {
            
        }





        #endregion
    }
}
