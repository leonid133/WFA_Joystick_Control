using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;
using eKey = Microsoft.DirectX.DirectInput.Key;


namespace WFA_Joystick_Control
{
    class JoystickConfiguration
    {
        static string m_config_file_name = "joysticks.config";
        static DataContractJsonSerializer m_serializer = new DataContractJsonSerializer(typeof(Dictionary<eKey, String>));

        public Dictionary<eKey, String> m_joystick_map;

        public void SetJoyAction(eKey dest, String source)
        {
            m_joystick_map[dest] = source;
        }

        public JoystickConfiguration()
        {
            string joystick_map_readbuff = "";
            try
            {
                using (StreamReader sr = File.OpenText(m_config_file_name))
                {
                    joystick_map_readbuff = sr.ReadLine();
                }
                m_joystick_map = GetDictionary(ref joystick_map_readbuff);
            }
            catch (Exception ex)
            {
                m_joystick_map = DefaultDictionary();
                Flush();
                //throw new System.Exception("An error occured while reading joystick.config. Joystick was reset to default. \nError: " + ex.Message);
            }
        }

        public void Flush()
        {
            string json = GetJSON(ref m_joystick_map);

            try
            {
                using (FileStream fs = File.Create(m_config_file_name))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(json);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                throw new System.Exception("An error occured while writing joystick.config. Changes were not written. Please, try again. \nError: " + ex.Message);
            }

        }


        static public string GetJSON(ref Dictionary<eKey, String> dict)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                m_serializer.WriteObject(ms, dict);
                return Encoding.Default.GetString(ms.ToArray());
            }
        }

        static public Dictionary<eKey, String> GetDictionary(ref string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                return (Dictionary<eKey, String>)m_serializer.ReadObject(ms);
            }
        }
        static public Dictionary<eKey, String> DefaultDictionary()
        {
            Dictionary<eKey, String> dict = new Dictionary<eKey, String>();
            dict.Add(eKey.W, "Y-"); //Вперед W
            dict.Add(eKey.S, "Y+"); //Назад S
            dict.Add(eKey.D, "X-"); //Поворот в право D
            dict.Add(eKey.A, "X+"); //Поворот в лево A

            dict.Add(eKey.Up, "AY-"); //Подъем пушки Up
            dict.Add(eKey.Down, "AY+"); //Опускание пушки Down
            dict.Add(eKey.Right, "AX-"); //Поворот пушки вправо Right
            dict.Add(eKey.Left, "AX+"); //Поворот пушки влево Left

            dict.Add(eKey.NumPad8, "VY-"); //Складывание по вертикали вверх Num8
            dict.Add(eKey.NumPad2, "VY+"); //Складывание по вертикали вниз Num2
            dict.Add(eKey.NumPad4, "Z+"); //Раскладывание Num4
            dict.Add(eKey.NumPad6, "Z-"); //Складывание Num6

            dict.Add(eKey.NumPad5, "B1");  // Фиксация/Расфиксация вертикального складывания Num5

            dict.Add(eKey.D1, "B2");  // Включение/Выключение выключение прожектора 1
            dict.Add(eKey.D2, "B3");  // Включение/Выключение камеры 2
            
            dict.Add(eKey.D3, "2Y+"); //Доп оборудование №1 вверх 3
            dict.Add(eKey.D4, "2Y-"); //Доп оборудование №1 вниз 4

            dict.Add(eKey.D5, "2X+"); //Доп оборудование №2 вверх 5
            dict.Add(eKey.D6, "2X-"); //Доп оборудование №2 вниз 6

            dict.Add(eKey.D7, "2Z+"); //Доп оборудование №3 вверх 7
            dict.Add(eKey.D8, "2Z-"); //Доп оборудование №3 вниз 8 

            dict.Add(eKey.D9, "2VY+"); //Доп оборудование №4 вверх 9
            dict.Add(eKey.D0, "2VY-"); //Доп оборудование №4 вниз 0

            return dict;
        }
    }
}
