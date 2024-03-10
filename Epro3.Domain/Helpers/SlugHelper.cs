using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epro3.Domain.Helpers
{
    public static class SlugHelper
    {
        public static string CourseSlugGenerate(string courseName)
        {
            string pattern = "[/:*?\"<>|]";
            string fileName = Regex.Replace(courseName, pattern, string.Empty);
            fileName = fileName.Replace("\\", string.Empty);
            fileName = fileName.Replace(" ", "-");
            return fileName;
        }

        public static string CourseImageFileUri(string fileName)
        {
            return "http://localhost:2002/resource/image/course/" + fileName;
        }
    }
}
