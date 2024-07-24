using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace footballnews
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["dstaikhoan"] = new List<taikhoan>();
            taikhoan ad = new taikhoan();
            ad.User = "admin";
            ad.Password = "admin";
            List<taikhoan> ds = (List<taikhoan>)Application["dstaikhoan"];
            ds.Add(ad);
            /*List<baiviet> dsbv = new List<baiviet>();
            Application["dsbaiviet"] = dsbv;*/
            List<tin> dsTintuc = new List<tin>();
            dsTintuc.Add(new tin("1",
                                "https://cdnphoto.dantri.com.vn/ArT76Km7NP9HwQ_GD4sACR0hcSE=/thumb_w/1020/2024/07/24/u19vn-edited-1721823573718.jpeg",
                                "Xác định 4 đội bóng lọt vào bán kết giải U19 Đông Nam Á",
                                "Không có bất ngờ xuất hiện ở lượt trận cuối cùng bảng A giải U19 Đông Nam Á diễn ra vào tối qua. U19 Indonesia đã xuất sắc giành chiến thắng với tỷ số 6-2 trước U19 Timor Leste. Với kết quả này, đội bóng xứ Vạn đảo đã giành vé đi tiếp khi toàn thắng cả 3 trận đấu và có được 9 điểm.Thực tế, màn trình diễn của U19 Indonesia vô cùng thuyết phục ở giải đấu này. Sau 3 trận đấu gặp U19 Timor Leste, U19 Philippines và U19 Campuchia, đội bóng của HLV Indra Sjafri đã ghi tới 14 bàn thắng và chỉ thủng lưới 2 bàn. Trong đó, họ đã ghi tới 6 bàn trong hai trận gặp U19 Philippines và U19 Timor Leste.\r\n\r\nVới vị trí nhất bảng A, U19 Indonesia sẽ đối diện với đội nhất bảng C ở vòng bán kết. Lúc này, bảng C đã xác định xong hai đội đi tiếp là U19 Thái Lan và U19 Malaysia. Trước lượt cuối cùng, U19 Malaysia đang tạm xếp trên do hơn hiệu số bàn thắng bại. Do đó, họ chỉ cần hòa U19 Thái Lan là sẽ giành vị trí đầu bảng C.\r\n\r\nTrong khi đó, ở bảng B, U19 Australia đã chắc chắn có vị trí đầu bảng sau hai chiến thắng trước U19 Lào và U19 Việt Nam. Trong cả hai trận đấu này, đội bóng xứ Chuột túi đều ghi 6 bàn vào lưới đối thủ.\r\n\r\nTrận đấu giữa U19 Australia và U19 Myanmar diễn ra vào lúc 15h00 hôm nay (24/7) chỉ mang ý nghĩa thủ tục. Nhiều khả năng, đội bóng của HLV Trevor Morgan sẽ ra sân với đội hình không phải mạnh nhất."));
            dsTintuc.Add(new tin("2",
                                "https://cdnphoto.dantri.com.vn/cjhllYkS6mAxW9Xb2f3ONgAlhyQ=/thumb_w/1020/2024/07/24/argentina-1721789649-6779-1721789941-1721821688709.jpg",
                                "Người hâm mộ Việt Nam có nguy cơ không được xem trực tiếp Olympic",
                "Tính tới thời điểm hiện tại, chưa có nhà đài nào ở Việt Nam sở hữu bản quyền phát sóng Olympic. Điều đó có nghĩa rằng, người hâm mộ Việt Nam có nguy cơ không được xem trực tiếp giải đấu này." +
                "Chỉ còn vài ngày nữa (26/7), Olympic Paris 2024 sẽ khởi tranh. Tuy nhiên, tính tới sáng ngày 24/7, chưa có đài truyền hình nào ở Việt Nam công bố bản quyền phát sóng Olympic." +
                "Điều đó có nghĩa rằng, người hâm mộ ở mảnh đất hình chữ S có nguy cơ không được xem trực tiếp giải đấu này." +
                "Còn nhớ, cách đây 3 năm, đài truyền hình Việt Nam (VTV) chỉ công bố bản quyền truyền hình Olympic ở thời điểm hai ngày trước lễ khai mạc. Tuy nhiên, tình hình hiện tại bi quan hơn khá nhiều." +
                "Tính tới thời điểm này, hơn 100 quốc gia và vùng lãnh thổ đã công bố sở hữu bản quyền truyền hình ở Olympic 2024. Trong đó, một vài quốc gia ở Đông Nam Á như Thái Lan, Singapore, Indonesia, Philippines đã sở hữu bản quyền." +
                "Nguyên nhân chính là do chi phí bản quyền ngày càng tăng cao. Mức giá bản quyền ở Olympic 2020 tăng gấp 10 lần so với Olympic 2016. Ở kỳ Olympic 2024, số tiền nhà đài bỏ ra mua bản quyền truyền hình có thể tăng vọt." +
                "Tờ Bangkok Post cho hay, một nhà đài ở Thái Lan đã chi tới hơn 280 tỷ đồng cho việc mua bản quyền phát sóng Olympic 2024. Số tiền lớn này là bài toán khó với các đài truyền hình ở Việt Nam."));
            dsTintuc.Add(new tin("3",
                "https://cdnphoto.dantri.com.vn/lZWg-an6mJm33iMq_atCRSbn510=/thumb_w/1020/2024/07/24/anhchu-1721435798234-1721793734247.jpg",
                "Bị UEFA buộc tội, hai ngôi sao Tây Ban Nha có nguy cơ bị phạt nặng sau Euro",
                "Sau cuộc điều tra, Liên đoàn bóng đá châu Âu (UEFA) đã buộc tội hai ngôi sao đội tuyển Tây Ban Nha là Rodri và Morata vi phạm nguyên tắc.</br>Trong lễ diễu hành ăn mừng chức vô địch Euro 2024, hai ngôi sao của Tây Ban Nha là Rodri và Alvaro Morata đã hô vang: \"Gibraltar là của Tây Ban Nha\". Điều này dẫn tới việc Liên đoàn bóng đá Gibraltar bày tỏ sự không hài lòng và gửi đơn kiện lên UEFA.Sau cuộc điều tra, UEFA xác nhận hai cầu thủ này đã vi phạm hai nguyên tắc về ứng xử chung và cư xử đứng đắn. Bên cạnh đó, UEFA còn buộc tội họ lợi dụng sự kiện thể thao để thể hiện hành vi phi thể thao và làm mất hình ảnh đẹp của môn bóng đá, khiến UEFA mang tiếng xấu.UEFA tuyên bố: Các thủ tục kỷ luật đối với Rodri và Morata đã được tiến hành theo điều 55 trong Quy định kỷ luật của UEFA. Hai cầu thủ vi phạm 4 quy tắc của UEFA trong lễ ăn mừng tại Madrid vào ngày 15/7/2024.Ủy ban Kiểm soát, Đạo đức và Kỷ luật của UEFA sẽ quyết định hình phạt đối với Rodri và Morata vào thời điểm thích hợp. Theo một vài nguồn tin, Rodri và Morata có thể chịu án phạt rất nặng, bao gồm cấm thi đấu (thậm chí ở cúp châu Âu) và phạt tiền. UEFA sẵn sàng phạt nặng để răn đe trường hợp tương tự trong tương lai.Liên đoàn bóng đá Gibraltar hoan nghênh cuộc điều tra của UEFA và họ đang chờ án phạt dành cho hai tuyển thủ Tây Ban Nha. Liên đoàn bóng đá Gibraltar cho rằng màn ăn mừng của Rodri và Morata mang tính chất khiêu khích và xúc phạm đất nước của họ.Cần nói thêm rằng ở Euro 2024, UEFA đã đưa ra hình phạt về hành vi không phù hợp liên quan tới chính trị. Cầu thủ Mirlind Daku của Albania bị phạt hai trận vì hành vi cầm loa phát đi những thông điệp mang tính kích động tới Serbia. Trung vệ Merih Demiral của Thổ Nhĩ Kỳ cũng lĩnh án phạt vì có hành vi ủng hộ tổ chức cực đoan tại quê nhà."));
            List<tin> dsGiaiDau = new List<tin>();
                dsGiaiDau.Add(new tin("4", "img", "title", "content"));
                dsGiaiDau.Add(new tin("5", "img", "title", "content"));
                dsGiaiDau.Add(new tin("6", "img", "title", "content"));
            List<tin> dsLichThiDau = new List<tin>();
            dsLichThiDau.Add(new tin("7", "img", "title", "content"));
            dsLichThiDau.Add(new tin("8", "img", "title", "content"));
            dsLichThiDau.Add(new tin("9", "img", "title", "content"));
            List<tin> dsHighlight = new List<tin>();
            dsHighlight.Add(new tin("10", "img", "title", "content"));
            dsHighlight.Add(new tin("11", "img", "title", "content"));
            dsHighlight.Add(new tin("12", "img", "title", "content"));
            Application["dsTintuc"] = dsTintuc;
            Application["dsGiaiDau"] = dsGiaiDau;
            Application["dsLichThiDau"] = dsLichThiDau;
            Application["dsHighlight"] = dsHighlight;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
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