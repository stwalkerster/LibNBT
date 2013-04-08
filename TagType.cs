﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNamedBinaryTag
{
    public enum TagType
    {
        TagEnd = 0,
        TagByte = 1,
        TagShort = 2,
        TagInt = 3,
        TagLong = 4,
        TagFloat = 5,
        TagDouble = 6,
        TagByteArray = 7,
        TagString = 8,
        TagList = 9,
        TagCompound = 10,
        TagIntArray = 11
    }
}
