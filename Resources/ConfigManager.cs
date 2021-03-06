﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BD.Resources
{
    /// <summary>
    /// 将对象xml系列化，或者反序列化
    /// </summary>
    public class ConfigManager
    {
        static string defaultPath;
        public ConfigManager()
        {
            defaultPath = Environment.CurrentDirectory;
        }
        #region 存取配置文件

        /// <summary>
        /// 加载配置
        /// </summary>
        /// <typeparam name="T">配置类型</typeparam>
        /// <returns></returns>
        public static T LoadConfig<T>(string ProfilePath=null) where T : class, new()
        {
            Type t = typeof(T);
            if (ProfilePath == null)
                ProfilePath = defaultPath;
            string path = System.IO.Path.Combine(ProfilePath, t.Name + ".xml");
            if (!System.IO.File.Exists(path)) return null;
            else
            {
                T obj = null;
                using (System.IO.StreamReader sr = new System.IO.StreamReader(path, System.Text.Encoding.Unicode))
                {
                    System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(t);
                    obj = xml.Deserialize(sr) as T;
                    sr.Close();
                }
                return obj;
            }
        }

        /// <summary>
        /// 加载配置
        /// </summary>
        /// <typeparam name="T">配置类型</typeparam>
        /// <returns></returns>
        public static object LoadConfig(Type t, string configName, string ProfilePath=null)
        {
            if (ProfilePath == null)
                ProfilePath = defaultPath;
            string path = System.IO.Path.Combine(ProfilePath, configName + ".xml");
            if (!System.IO.File.Exists(path)) return null;
            else
            {
                object obj = null;
                using (System.IO.StreamReader sr = new System.IO.StreamReader(path, System.Text.Encoding.Unicode))
                {
                    System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(t);
                    obj = xml.Deserialize(sr);
                    sr.Close();
                }
                return obj;
            }
        }

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="cfg"></param>
        /// <param name="ProfilePath"></param>
        public static void SaveConfig(object cfg, string ProfilePath=null)
        {
            if (ProfilePath == null)
                ProfilePath = defaultPath;
            if (cfg == null) throw new ArgumentNullException();
            Type t = cfg.GetType();
            string path = System.IO.Path.Combine(ProfilePath, t.Name + ".xml");
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
            using (System.IO.StreamWriter sr = new System.IO.StreamWriter(path, false, System.Text.Encoding.Unicode))
            {
                System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(t);
                xml.Serialize(sr, cfg);
                sr.Close();
            }
        }

        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="configName"></param>
        /// <param name="cfg"></param>
        /// <param name="ProfilePath"></param>
        public static void SaveConfig(string configName, object cfg, string ProfilePath)
        {
            if (ProfilePath == null)
                ProfilePath = defaultPath;
            if (cfg == null) throw new ArgumentNullException();
            Type t = cfg.GetType();
            string path = System.IO.Path.Combine(ProfilePath, configName + ".xml");
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));
            using (System.IO.StreamWriter sr = new System.IO.StreamWriter(path, false, System.Text.Encoding.Unicode))
            {
                System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(t);
                xml.Serialize(sr, cfg);
                sr.Close();
            }
        }
        /// <summary>
        /// 把对象序列化到Stream
        /// </summary>
        /// <param name="cfg"></param>
        /// <returns></returns>
        public static MemoryStream SaveConfigMem(object cfg)
        {
            if (cfg == null) throw new ArgumentNullException();
            Type t = cfg.GetType();
            MemoryStream stream = new MemoryStream();
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(t);
            xml.Serialize(stream, cfg);
            stream.Position = 0;
            return stream;
        }
        /// <summary>
        /// 从Stream 反序列化得到对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T LoadConfig<T>(Stream stream) where T : class, new()
        {
            Type t = typeof(T);
            T obj = null;
            System.Xml.Serialization.XmlSerializer xml = new System.Xml.Serialization.XmlSerializer(t);
            obj = xml.Deserialize(stream) as T;
            return obj;
        }


        #endregion
    }
}
