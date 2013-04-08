using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNamedBinaryTag
{
    public abstract class NamedTag : Tag
    {
        private StreamReader _sr;
        private TagType _type;
        private string _name;

        protected NamedTag(StreamReader sr, string name, TagType type)
        {
            _name = name;
            _type = type;
            _sr = sr;
        }

        public static NamedTag parse(StreamReader sr, TagType type)
        {
            var name = "";

            //read the name length
            var buffer = new char[2];
            sr.ReadBlock(buffer, 0, 2);
            var bytebuf = new byte[] {(byte) buffer[1], (byte) buffer[0]};
            short length = BitConverter.ToInt16(bytebuf, 0);

            buffer = new char[length];
            sr.ReadBlock(buffer, 0, length);
            name = new string(buffer);

            Type t = GetClrTypeForTag(type);
            return (NamedTag)Activator.CreateInstance(t, sr, name, type);
        }

        public static Type GetClrTypeForTag(TagType tagType)
        {
            // load all the classes in this assembly
            var types = System.Reflection.Assembly.GetCallingAssembly().GetTypes();
            return (from t in types where t.BaseType == typeof (NamedTag) let attributes = t.GetCustomAttributes(typeof (TagTypeAttribute), false) where attributes.Length != 0 where ((TagTypeAttribute) attributes[0]).Type == tagType select t).FirstOrDefault();
        }
    }
}
