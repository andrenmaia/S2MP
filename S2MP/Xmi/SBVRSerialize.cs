
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Xmi.Definitions;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace S2MP.Xmi
{
    internal class SBVRSerialize
    {
        /// <summary>
        /// Deserializer a xmi file to in a sbvr object.
        /// </summary>
        /// <typeparam name="T">
        /// Type of sbvr object.
        /// </typeparam>
        /// <param name="xmi">
        /// Xmi from sbvr file.
        /// </param>
        /// <returns>
        /// List of type of sbvr object deserialized.
        /// </returns>
        public static List<T> Deserializer<T>(XMI xmi) where T : class
        {
            // Get type.
            Type destinationType = typeof(T);

            // Select nodes from xmi file.
            var nodes = xmi.Items.Where(x => x.LocalName == destinationType.Name);

            // Create deserializer.
            XmlSerializer deserializer = new XmlSerializer(destinationType);
            List<T> result = new List<T>();

            foreach (var item in nodes)
            {
                // Deserialize object from xmi file.
                T objectDeserialized = deserializer.Deserialize(new MemoryStream(Encoding.Default.GetBytes(item.OuterXml))) as T;

                // Read IDREF in properties from sbvr's objects.
                foreach (var prop in destinationType.GetProperties())
                {
                    XmlAttributeAttribute att = prop.GetCustomAttributes(typeof(XmlAttributeAttribute), false).FirstOrDefault() as XmlAttributeAttribute;

                    if (att != null
                        && !string.IsNullOrEmpty(att.AttributeName)
                        && att.DataType == "IDREF")
                    {
                        PropertyInfo info = objectDeserialized.GetType().GetProperty(att.AttributeName);

                        // Iterate by recursion thought reflexion of type Deserialize.
                        Type rootType = typeof(SBVRSerialize);
                        MethodInfo mi = rootType.GetMethod("Deserializer");
                        MethodInfo miConstructed = mi.MakeGenericMethod(info.PropertyType);
                        IEnumerable<object> o = miConstructed.Invoke(null, new object[] { xmi }) as IEnumerable<object>;
                        info.SetValue(objectDeserialized, o.FirstOrDefault(), null);
                    }
                }
                result.Add(objectDeserialized);
            }

            return result;
        }
    }
}
