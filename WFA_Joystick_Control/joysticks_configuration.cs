using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;



namespace WFA_Joystick_Control
{
    class JoystickConfiguration
    {
        static string m_config_file_name = "joysticks.config";
        static DataContractJsonSerializer m_serializer = new DataContractJsonSerializer(typeof(Dictionary<String, String>));

        public Dictionary<String, String> m_joystick_map;

        public void SetKey(String dest, String source)
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
                throw new System.Exception("An error occured while reading joystick.config. Joystick was reset to default. \nError: " + ex.Message);
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


        static public string GetJSON(ref Dictionary<String, String> dict)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                m_serializer.WriteObject(ms, dict);
                return Encoding.Default.GetString(ms.ToArray());
            }
        }

        static public Dictionary<String, String> GetDictionary(ref string json)
        {
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                return (Dictionary<String, String>)m_serializer.ReadObject(ms);
            }
        }
        static public Dictionary<String, String> DefaultDictionary()
        {
            Dictionary<String, String> dict = new Dictionary<String, String>();
            dict.Add("Y+", "Y+"); //Вперед
            dict.Add("Y-", "Y-"); //Назад
            dict.Add("X-", "X-"); //Поворот в право
            dict.Add("X+", "X+"); //Поворот в лево

            dict.Add("AY+", "AY+"); //Подъем пушки
            dict.Add("AY-", "AY-"); //Опускание пушки
            dict.Add("AX-", "AX-"); //Поворот пушки вправо
            dict.Add("AX+", "AX+"); //Поворот пушки влево

            dict.Add("VY+", "VY+"); //Складывание по вертикали вверх
            dict.Add("VY-", "VY-"); //Складывание по вертикали вниз
            dict.Add("Z+", "Z+"); //Раскладывание
            dict.Add("Z-", "Z-"); //Складывание

            dict.Add("B1", "B1");  // Фиксация/Расфиксация вертикального складывания
            dict.Add("B2", "B2");  // Включение/Выключение выключение прожектора
            dict.Add("B3", "B3");  // Включение/Выключение камеры
            
            dict.Add("2Y+", "2Y+"); //Доп оборудование №1 вверх
            dict.Add("2Y-", "2Y-"); //Доп оборудование №1 вниз

            dict.Add("2X+", "2X+"); //Доп оборудование №2 вверх
            dict.Add("2X-", "2X-"); //Доп оборудование №2 вниз

            dict.Add("2Z+", "2Z+"); //Доп оборудование №3 вверх
            dict.Add("2Z-", "2Z-"); //Доп оборудование №3 вниз

            dict.Add("2VY+", "2VY+"); //Доп оборудование №4 вверх
            dict.Add("2VY-", "2VY-"); //Доп оборудование №4 вниз

            return dict;
        }
    }
}
