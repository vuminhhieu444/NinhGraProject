namespace GraduateSolution
{
    public class PaginationModel<T> where T : class
    {
        List<T> items;
        int totalPage;
        int totalCount;

        public List<T> ListItem { get => items; set => items = value; }
        public int TotalPage1 { get => totalPage; set => totalPage = value; }
        public int TotalCount { get => totalCount; set => totalCount = value; }
    }
}
