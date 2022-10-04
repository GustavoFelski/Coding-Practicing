//TODO: Create a enum with languages - DONE
//TODO: Create a directory of corresponding languages
//TODO: Create files inside each folder log.txt - 
//TODO: write in each file a number and datetime that was created

using System;
using System.IO;
using System.Diagnostics;

namespace ExerciseWR
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gusta\source\repos\Coding - Practicing\FileWRexercise";
            FolderCreation newFolder = new FolderCreation(path);
            for (int i = 0; i < (int)Enum.GetValues(typeof(languages)).Length; i++)
            {
                newFolder.FileCreation(/*languages*/, i);
                
            }
            
        }
    }

    class FolderCreation
    {
        string pathFolder = string.Empty;
        public FolderCreation(string path)
        {
            pathFolder = path; 
        }
        public void FileCreation(string folderName, int counter)
        {
            pathFolder = (string)pathFolder.Concat("\\" + folderName);
            Directory.CreateDirectory(pathFolder);
            //create logs and write
            FileWriter fw = new FileWriter();
            fw.Writer(folderName, counter);
        }

    }
    class FileWriter
    {
        public void Writer(string path, int counter)
        {
            StreamWriter sw = new StreamWriter((string)path.Concat("\\log.txt"),true);
            sw.WriteLine(DateTime.Now.ToString(), counter.ToString());
            sw.Close();
        }
    }
    enum languages
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Czech,
        Dutch,
        English,
        French,
        German,
        Greek,
        Hindi,
        Hungarian,
        Italian,
        Japanese,
        Javanese,
        Korean,
        Kurdish,
        Malay,
        Mandarin,
        Persian,
        Polish,
        Portuguese,
        Romanian,
        Russian,
        Spanish,
        Swedish,
        Thai,
        Turkish,
        Ukrainian,
        Urdu,
        Vietnamese,
        Zulu
    }
}