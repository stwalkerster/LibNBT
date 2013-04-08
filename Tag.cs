using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNamedBinaryTag
{
    public abstract class Tag
    {
        public TagType type;
        public static Tag parse(StreamReader sr)
        {

            var type = (TagType)sr.Read();

            if (type == TagType.TagEnd)
            {
                return new EndTag {type = TagType.TagEnd};
            }

            return NamedTag.parse(sr, type);
        }
    }

    [TagType(TagType.TagEnd)]
    class EndTag : Tag
    {
    }
}
