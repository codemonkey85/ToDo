using System.IO;
using System.Xml.Serialization;

namespace ToDo
{
    public static class FileIO
    {
        public static void LoadFromFile<T>(FileStream fs, ref T item)
        {
            var serializer = new XmlSerializer(typeof(T));
            item = (T)serializer.Deserialize(fs);
        }

        public static void SaveToFile<T>(FileStream fs, T item)
        {
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(fs, item);
        }
    }
}