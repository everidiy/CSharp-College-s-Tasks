using _20_File_Access_XML.Interfaces;

namespace _20_File_Access_XML.Classes
{
    internal class Cell : GetInfoAboutData
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public string Type { get; set; }

        public string GetInfoByString()
        {
            return $"\n| Название вальера: {Name} \n| Площадь вальера: {Area} \n| Тип животного: {Type} \n";
        }
    }
}
