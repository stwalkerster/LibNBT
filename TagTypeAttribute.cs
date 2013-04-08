using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNamedBinaryTag
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    class TagTypeAttribute : Attribute
    {
        private readonly TagType type;

        public TagTypeAttribute(TagType type)
        {
            this.type = type;
        }

        public TagType Type
        {
            get { return type; }
        }
    }
}
