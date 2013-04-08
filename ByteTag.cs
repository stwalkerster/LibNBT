using System.IO;

namespace LibNamedBinaryTag
{
    [TagType(TagType.TagByte)]
    class ByteTag : NamedTag
    {
        private byte _data;

        public ByteTag(StreamReader sr, string name, TagType type) : base(sr, name, type)
        {
            _data = (byte) sr.Read();
        }
    }
}