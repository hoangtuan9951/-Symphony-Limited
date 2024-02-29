namespace Symphony.Ltd.Courses
{
    public static class CourseConsts
    {
        private const string DefaultSorting = "{0}Title asc";

        public static string GetDefaultSorting(bool withEntityName)
        {
            return string.Format(DefaultSorting, withEntityName ? "Course." : string.Empty);
        }

    }
}