using _20_File_Access_XML.Interfaces;

namespace _20_File_Access_XML.Classes
{
    internal class Animal : GetInfoAboutData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public string GetInfoByString()
        {
            return $"\n| Имя животного: {Name} \n| Возраст животного: {Age} \n| Вес животного: {Weight} ";
        }
    }
}
