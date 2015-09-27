using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;


namespace WFA_Joystick_Control
{
    class DictionarySerialization
    {
        static DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<int, int>));

        static public string GetJSON(ref Dictionary<int, int> dict)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, dict);
                return Encoding.Default.GetString(ms.ToArray());
            }

        }

        static public Dictionary<int, int> GetDictionary(ref string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                return (Dictionary<int, int>)serializer.ReadObject(ms);
            }
        }
    }

}