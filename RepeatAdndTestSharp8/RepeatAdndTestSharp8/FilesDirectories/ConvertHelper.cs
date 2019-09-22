using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatAdndTestSharp8.FilesDirectories
{
    class ConvertHelper
    {
        public static int ConvertToGb(long number)
        {
            for (var i = 0; i < 3; i++)
            {
                number = (number / 1024);
            }
            return (int)number;
        }

        public static int ConvertToMb(long number)
        {
            for (var i = 0; i < 2; i++)
            {
                number = (number / 1024);
            }
            return (int)number;
        }

    }
}
