using System.IO;

namespace LibNamedBinaryTag
{
    [TagType(TagType.TagCompound)]
    class CompoundTag : NamedTag
    {
        public CompoundTag(StreamReader sr, string name, TagType type) : base(sr, name, type)
        {

        }
    }
}