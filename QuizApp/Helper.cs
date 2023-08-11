using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public class Helper
    {
        private static Helper instance = null;
        private static readonly object padlock = new object();

        private Helper()
        {
            // Konstruktor prywatny, aby uniemożliwić tworzenie instancji z zewnątrz.
        }

        public static Helper Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Helper();
                    }
                    return instance;
                }
            }
        }

        public static string OpenFileWithDialog(params string[] allowedExtensions)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = $"Pliki ({string.Join(", ", allowedExtensions)})|{string.Join(";", allowedExtensions)}";
                openFileDialog.Title = "Wybierz plik";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName; // Zwraca pełną ścieżkę z rozszerzeniem
                }
            }

            return null;
        }
        public static bool DoesFileExist(string filePath)
        {
            return File.Exists(filePath);
        }
        public static List<QuizQuestion> ParseCsv(string filePath)
        {
            List<QuizQuestion> questions = new List<QuizQuestion>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length == 7) // Assuming 7 columns in the CSV
                    {
                        QuizQuestion question = new QuizQuestion
                        {
                            Question = fields[0],
                            Options = new string[] { fields[1], fields[2], fields[3], fields[4] },
                            CorrectAnswer = int.Parse(fields[5]),
                            QuestionType = fields[6]
                        };

                        questions.Add(question);
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format in CSV.");
                    }
                }
            }
            return questions;
        }
    }
}
