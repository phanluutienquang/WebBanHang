namespace WebBanHang.Models
{
    public class Paginate
    {
        public int TotalItems { get;private set;}//Tổng số items
        public int PageSize { get; private set;}// tổng số items/trang


        public int CurrentPage { get; private set;}// Trang hiện tại
        public int TotalPages { get; private set;}//tổng trang
        public int StartPage {  get; private set;}//trang bắt đầu  
        public int EndPage { get; private set;}//trang kết thúc
        public Paginate()
        {

        }
        public Paginate(int totalItems, int pageSize = 10, int page)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems/(decimal)pageSize);
            int currentPage = page;

            int startPage = currentPage - 5;
            int endPage = currentPage + 4;

            if(startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }
        }
    }
}
