using System.Collections.Generic;
using System.IO;

namespace LibNamedBinaryTag
{
    [TagType(TagType.TagCompound)]
    class CompoundTag : NamedTag
    {
        private List<NamedTag> subtags = new List<NamedTag>();

        public CompoundTag(StreamReader sr, string name, TagType type) : base(sr, name, type)
        {
            while (true)
            {
                var t = parse(sr);

                if (t.type == TagType.TagEnd) break;

                subtags.Add((NamedTag) t);
            }
        }
    }
}