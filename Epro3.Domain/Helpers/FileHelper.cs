using System.Text.RegularExpressions;

namespace Epro3.Domain.Helpers
{
    public static class FileHelper
    {
        public static string CreateCourseThumbnailFileName(string courseName, string extension)
        {
            string pattern = "[/:*?\"<>|]";
            string fileName = Regex.Replace(courseName, pattern, string.Empty);
            fileName = fileName.Replace("\\", string.Empty);
            fileName = "thumbnail" + fileName.Replace(" ", "-") + extension;
            return fileName;
        }
        public static string CreateCourseBackgroundFileName(string courseName, string extension)
        {
            string pattern = "[/:*?\"<>|]";
            string fileName = Regex.Replace(courseName, pattern, string.Empty);
            fileName = fileName.Replace("\\", string.Empty);
            fileName = "background" + fileName.Replace(" ", "-") + extension;
            return fileName;
        }
        public static string CourseImageFileUri(string fileName)
        {
            return "http://localhost:2002/resource/image/course/" + fileName;
        }
    }
}
