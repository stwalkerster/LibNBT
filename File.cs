using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysFile = System.IO.File;

namespace LibNamedBinaryTag
{
    public class File
    {
        public string path;
        public Tag tag;

        public File(string path)
        {
            this.path = path;
        }

        protected File()
        {
        }

        public static File readFile(string path)
        {
            var f = new File();
            f.path = path;

            var sr = new StreamReader(path);

            f.tag = Tag.parse(sr);

            sr.Close();

            return f;
        }

    }
}