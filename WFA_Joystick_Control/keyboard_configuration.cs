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
        static string config_file_name = "keyboard.config.txt";
        static DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<eKey, eKey>));

        public Dictionary<eKey, eKey> keyboard_map;

        public void SetKey(eKey dest, eKey source)
        {
            keyboard_map[dest] = source;
        }

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
                Flush();
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

            dict.Add(eKey.Up, eKey.Up);
            dict.Add(eKey.Down, eKey.Down);
            dict.Add(eKey.Left, eKey.Left);
            dict.Add(eKey.Right, eKey.Right);

            dict.Add(eKey.NumPad8, eKey.NumPad8);
            dict.Add(eKey.NumPad2, eKey.NumPad2);
            dict.Add(eKey.NumPad4, eKey.NumPad4);
            dict.Add(eKey.NumPad6, eKey.NumPad6);

            dict.Add(eKey.D1, eKey.D1);
            dict.Add(eKey.D2, eKey.D2);
            dict.Add(eKey.D3, eKey.D3);
            dict.Add(eKey.D4, eKey.D4);
            dict.Add(eKey.D5, eKey.D5);
            dict.Add(eKey.D6, eKey.D6);
            dict.Add(eKey.D7, eKey.D7);
            dict.Add(eKey.D8, eKey.D8);
            dict.Add(eKey.D9, eKey.D9);
            dict.Add(eKey.D0, eKey.D0);

            return dict;
        }
    }

}