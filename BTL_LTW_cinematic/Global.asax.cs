using BTL_LTW_cinematic.Class;
using System;
using System.Collections;

namespace BTL_LTW_cinematic
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //application user
            User u = new User("Nguyen Duc Luong", "088888", "12-3-2003", "luong", "123");
            User i = new User("Cao Nhat Minh", "088888", "12-3-2003", "minh", "123");
            User a = new User("admin", "088888", "12-3-2003", "admin", "123");
            ArrayList app = new ArrayList();
            app.Add(u);
            app.Add(i);
            app.Add(a);
            Application["users"] = app;
            //application movies
            Application["movies"] = new ArrayList();
            Movies m1 = new Movies("Bà Thím Báo Thù", "../assets/img/ba-thim-bao-thu.jpg", "120p", "Khác", "Trần Đức Lộc", "Park Young-ju", "12/04/2024", "Bà Thím Báo Thù kể về một kẻ lừa đảo, đang đối mặt với nguy cơ mất tất cả, đành phải cầu cứu sự giúp đỡ từ chính những người đã từng là nạn nhân của mình! Duk Hee (Ra Mi-ran thủ vai), đang cố gắng vay mượn từ khắp nơi để tái lập cửa tiệm giặt ủi sau vụ hoả hoạn, nhận được một cuộc gọi từ Son, tự xưng là nhân viên ngân hàng, hứa sẽ cấp cho cô một khoản vay với lãi suất ưu đãi. Tuy nhiên, Son yêu cầu Duk Hee phải chuyển trước cho anh ta một khoản tiền gọi là phí vay mượn", "1", "12.00-14.00");
            Movies m2 = new Movies("BIỆT ĐỘI SĂN MA (T13): KỶ NGUYÊN BĂNG GIÁ", "../assets/img/biet-doi-san-ma.jpg", "115p", "Khác", "Gil Kenan", "William Atherton, Emily Alyn Lind, James Acaster, Annie Potts, Ernie Hudson", "12/04/2024", "Sau các sự kiện của Ghostbusters: Afterlife, gia đình Spengler đang tìm kiếm cuộc sống mới ở Thành phố New York. Nhóm săn ma bao gồm Ray, Winston và Podcast sử dụng công nghệ mới để chống lại các mối đe dọa chết người cổ xưa đang ẩn náu trong các vật dụng hàng ngày. Thế nhưng, họ sẽ phải đối đầu với một thế lực đen tối hùng mạnh mới.", "1", "14.00-16.00");
            Movies m3 = new Movies("Gặp lại chị bầu", "../assets/img/gap-lai-chi-bau-tet.jpg", "115p", "Việt Nam", "Nhất Minh", "Anh Tú , Diệu Nhi, Kiều Minh Tuấn", "02/04/2024", "Phúc (Anh Tú) là diễn viên nghiệp dư với niềm đam mê lớn dành cho diễn xuất.Thế nhưng, cuộc sống khắc nghiệt khiến anh trở nên hoài nghi ước mơ mình ấp ủ. Không chỉ vậy, quá khứ thiếu vắng tình thương của cha mẹ cũng ảnh hưởng sâu sắc, mãi tới khi anh gặp Huyền (Diệu Nhi).", "3", "16.00-18.00");
            Movies m4 = new Movies("GODZILLA X KONG: ĐẾ CHẾ MỚI 2D", "../assets/img/godzilla-vs-kong-poster.jpg", "120p", "Khác", "Adam Wingard", "Rebecca Hall, Dan Stevens, Rachel House", "29/03/2024", "Kong và Godzilla - hai sinh vật vĩ đại huyền thoại, hai kẻ thủ truyền kiếp sẽ cùng bắt tay thực thi một sứ mệnh chung mang tính sống còn để bảo vệ nhân loại, và trận chiến gắn kết chúng với loài người mãi mãi sẽ bắt đầu.", "4", "16.00-18.00");
            Movies m5 = new Movies("NHỮNG MẢNH GHÉP CẢM XÚC 2", "../assets/img/inside-out-2.jpg", "99p", "Khác", "Kelsey Mann", "Amy Poehler, Phyllis Smith, Lewis Black", "14/06/2024", "ĐÓN CHỜ NHỮNG MẢNH GHÉP CẢM XÚC 2 (INSIDE OUT 2) - DỰ KIẾN KHỞI CHIẾU 6/2024", "1", "16.00-18.00");
            Movies m6 = new Movies("GARFIELD - MÈO BÉO SIÊU QUẬY", "../assets/img/meo-beo-sieu-quay.jpg", "115p", "Khác", "Mark Dindal", "Hannah Waddingham, Chris Pratt, Samuel L. Jackson", "24/05/2024", "Mèo vàng Garfield siêu quậy quay trở lại trong bộ phim mới nhất Garfield Movie. Đón xem ngay vào dịp hè năm 2024 nhé!", "1", "18.00-20.00");
            Movies m7 = new Movies("Mai", "../assets/img/poster-mai.jpg", "115p", "Việt Nam", "Trấn Thành", "Phương Anh Đào, Tuấn Trần, Trấn Thành, Uyển Ân, Hồng Đào,...", "24/05/2024", "Mai quay trở lại trong bộ phim mới nhất . Đón xem ngay vào dịp hè năm 2024 nhé!", "1", "20.00-22.00");
            Movies m8 = new Movies("Thanh gươm diệt quỷ", "../assets/img/thanh-guom-diet-quy.jpg", "115p", "Khác", "Lượng wibu", "Nhật Minh", "24/05/2024", "Thanh gươm diệt quỷ quay trở lại trong bộ phim mới nhất . Đón xem ngay vào dịp hè năm 2024 nhé!", "4", "20.00-22.00");

            ArrayList mov = (ArrayList)Application["movies"];
            mov.Add(m1);
            mov.Add(m2);
            mov.Add(m3);
            mov.Add(m4);
            mov.Add(m5);
            mov.Add(m6);
            mov.Add(m7);
            mov.Add(m8);
            //application movie ticket
            Application["movieticket"] = new ArrayList();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["search"] = "";
            Session["idphim"] = 0;
            Session["user"] = new User();
            Session["movietck"] = new Movie_Tickests();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}