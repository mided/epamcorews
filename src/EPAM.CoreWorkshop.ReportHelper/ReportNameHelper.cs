using System;
using System.IO;

namespace EPAM.CoreWorkshop.ReportHelper
{
    public static class ReportNameHelper
    {
        public static string NormalizeFileName(string name, char replChar)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            foreach (var c in invalidChars)
            {
                name = name.Replace(c, replChar);
            }

            return name;

        }
    }
}
