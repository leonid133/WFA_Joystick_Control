using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;

using eKey = Microsoft.DirectX.DirectInput.Key;

namespace WFA_Joystick_Control
{
    class KeyboardConfiguration
    {
        static string config_file_name = "keyboard.config";
        static DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<eKey, eKey>));

        public Dictionary<eKey, eKey> keyboard_map;

        public KeyboardConfiguration()
        {
            string connectionString = "";
//             string path_connectionfile = @"connection.txt";
            try
            {
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(config_file_name))
                {
                    string s = "";
                    if ((s = sr.ReadLine()) != null)
                    {
//                         Console.WriteLine(s);
                        connectionString = s;
                    }
                }
                keyboard_map = GetDictionary(ref connectionString);
            }
            catch (Exception ex)
            {
                keyboard_map = DefaultDictionary();
                throw new System.Exception("An error occured while reading keyboard.config. Keyboard was reset to default. \nError: " + ex.Message);
//                 Console.WriteLine(ex.ToString());
            }
//             return connectionString;

        }

        public void Flush()
        {
            string json = GetJSON(ref keyboard_map);

            try
            {
                // Create the file.
                using (FileStream fs = File.Create(config_file_name))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(json);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception("An error occured while writing keyboard.config. Changes were not written. Please, try again. \nError: " + ex.Message);
            }

        }


        static public string GetJSON(ref Dictionary<eKey, eKey> dict)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, dict);
                return Encoding.Default.GetString(ms.ToArray());
            }
        }

        static public Dictionary<eKey, eKey> GetDictionary(ref string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                return (Dictionary<eKey, eKey>)serializer.ReadObject(ms);
            }
        }
        static public Dictionary<eKey, eKey> DefaultDictionary()
        {
            Dictionary<eKey, eKey> dict = new Dictionary<eKey, eKey>();
            dict.Add(eKey.W, eKey.W);
            dict.Add(eKey.S, eKey.S);
            dict.Add(eKey.A, eKey.A);
            dict.Add(eKey.D, eKey.D);
            dict.Add(eKey.UpArrow, eKey.UpArrow);
            dict.Add(eKey.DownArrow, eKey.DownArrow);
            dict.Add(eKey.LeftArrow, eKey.LeftArrow);
            dict.Add(eKey.RightArrow, eKey.RightArrow);
            return dict;
        }
    }

}