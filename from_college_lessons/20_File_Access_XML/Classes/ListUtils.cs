using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _20_File_Access_XML.Classes
{
    public class ListUtils
    {
        static char separator1 = ';';
        static char separator2 = '-';
        static char separator3 = '*';

        static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        static Dictionary<Animal, Cell> list = new Dictionary<Animal, Cell>();

        internal static void CreateList()
        {
            string dir = Path.Combine(baseDirectory, "Data");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string file = Path.Combine(dir, "data.txt");
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            } 
            else if (File.Exists(file)) 
            {
                try
                {
                    string[] lines = File.ReadAllLines(file);

                    list.Clear();

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(separator3);

                        string animal = parts[0].Trim();
                        string[] animalProps = animal.Split(separator1);

                        string cell = parts[1].Trim();
                        string[] cellProps = cell.Split(separator2);

                        Animal animalObj = new Animal
                        {
                            Name = animalProps[0].Trim(),
                            Age = int.Parse(animalProps[1].Trim()),
                            Weight = double.Parse(animalProps[2].Trim()),
                        };

                        Cell cellObj = new Cell
                        {
                            Name = cellProps[0].Trim(),
                            Area = double.Parse(cellProps[1].Trim()),
                            Type = cellProps[2].Trim(),
                        };

                        list.Add(animalObj, cellObj);
                    }
                }
                catch (IOException) { }
            }
            else
            {
                SendError("Файл не найден!");
            }
            SendError("\nСписок был создан!");
        }

        internal static void DeleteList()
        {
            list.Clear();
            SendError("\nСписок был удален!");
        }

        internal static void ViewList()
        {
            if (list.Count == 0)
            {
                SendError("\nСписок пуст!");
                return;
            }

            foreach (var key in list)
            {
                Animal animal = key.Key;
                Cell cell = key.Value;

                Console.Write(animal.GetInfoByString());
                Console.Write(cell.GetInfoByString());
                
            }
            SendError("\nСписок был показан!");
        }

        internal static void SendError(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
        }
    }
}
