import { PATH_IMAGES } from '../constant/images';

export const ROLE = {
  ADMIN: 1,
  USER: 2,
};

export const HEADER = {
  API_KEY: 'x-api-key',
  CLIENT_ID: 'x-client-id',
  AUTHORIZATION: 'Authorization',
  REFRESHTOKEN: 'x-rtoken-id',
  CONTENT_TYPE: 'Content-Type',
};

export const statusCode = {
  SUCCESS: 200,
  CREATED: 201,
  UPDATED: 201,
  DELETED: 201,
  NO_CONTENT: 204,
};

export const LEVEL_ADMISSIONS = [
  {
    id: 1,
    name: 'Học sinh',
  },
  {
    id: 2,
    name: 'Sinh viên',
  },
  {
    id: 3,
    name: 'Đi làm',
  },
  {
    id: 4,
    name: 'Khác',
  },
];

export const TOP_ADMISSIONS = [
  {
    id: 1,
    name: 'TOP 1',
    description: 'Về đạo tạo CNTT',
    icon: PATH_IMAGES.top_1,
  },
  {
    id: 2,
    name: '20+',
    description: 'Năm kinh nghiệm',
    icon: PATH_IMAGES.top_2,
  },
  {
    id: 3,
    name: '10.000+',
    description: 'Học viện tốt nghiệp',
    icon: PATH_IMAGES.top_3,
  },
  {
    id: 4,
    name: '100%',
    description: 'Cam kết việc làm',
    icon: PATH_IMAGES.top_4,
  },
];

export const REASON_ADMISSIONS = [
  {
    id: 1,
    name: 'Khát nhân lực',
    description:
      'Theo TopDev, dự đoán từ đến năm 2024, Việt Nam thiếu hụt 195.000 lập trình viên/kỹ sư hàng năm.',
    backgroundColor: '#9e1d1d',
    color: 'white',
    boxShadow: 'none',
  },
  {
    id: 2,
    name: 'Thời đại số',
    description:
      'Đến năm 2025, Việt Nam dự kiến có 70.000 công ty công nghệ số với 1.2 triệu nhân lực làm việc trong lĩnh vực này.',
    backgroundColor: 'white',
    color: 'black',
    boxShadow: '0px 10px 60px 0px rgba(0,0,0,.4)',
  },
  {
    id: 3,
    name: 'Cơ hội phát triển',
    description:
      'Việt Nam là một trong hai điểm đến gia công phần mềm hàng đầu ở Đông Nam Á. Hạng 6 về dịch vụ gia công phần mềm.',
    backgroundColor: '#E6E6E68A',
    color: 'black',
    boxShadow: '0px 10px 60px 0px rgba(0,0,0,.4)',
  },
  {
    id: 4,
    name: 'MỨC LƯƠNG HẤP DẪN',
    description:
      'Vị trí Fresher dao động từ $342 đến dưới $1.161 cho Mid-Senior. Lương trung bình của lập trình viên Full-Stack 1359$ - 1683$.',
    backgroundColor: '#9e1d1d',
    color: 'white',
    boxShadow: 'none',
  },
];

export const COURSE_ADMISSIONS = [
  {
    id: 1,
    name: 'Học sinh THPT',
    description:
      'Học sinh từ lớp 10 đến lớp 12 yêu thích lập trình & công nghệ, có định hướng theo đuổi ngành Công nghệ thông tin trong tương lai.',
    image: PATH_IMAGES.course_1,
  },
  {
    id: 2,
    name: 'Sinh viên',
    description:
      'Sinh viên CNTT muốn bổ sung kiến thức & thực hành chuyên nghiệp hoặc sinh viên ngành khác muốn chuyển sang học lập trình.',
    image: PATH_IMAGES.course_2,
  },
  {
    id: 3,
    name: 'Người đi làm',
    description:
      'Muốn tìm hiểu về những ngôn ngữ lập trình, cập nhật công nghệ mới hoặc người mới muốn chuyển sang nghề lập trình.',
    image: PATH_IMAGES.course_3,
  },
];

export const BENEFIT_ADMISSIONS = [
  {
    id: 1,
    name: 'Cam kết hỗ trợ việc làm',
    description:
      'Học viên được giới thiệu thực tập tại doanh nghiệp ngay sau 6 tháng học. Cam kết việc làm sau khi tốt nghiệp với lương khởi điểm 8 triệu.',
    image: PATH_IMAGES.benefit_1,
  },
  {
    id: 2,
    name: 'Song bằng Quốc Tế',
    description:
      'Nhận Bằng Advanced Diploma in Software Engineering có giá trị trên 40 quốc gia. Liên thông ĐH Quốc Tế nhận bằng Cử nhân Lập trình.',
    image: PATH_IMAGES.benefit_2,
  },
  {
    id: 3,
    name: 'Đảm bảo chất lượng đào tạo',
    description:
      'Đảm bảo chất lượng đào tạo với sĩ số 24 bạn/lớp. Tăng cường tương tác giữa học viên và giảng viên. Bộ phận Đào tạo theo sát & hỗ trợ kịp thời.        ',
    image: PATH_IMAGES.benefit_3,
  },
  {
    id: 4,
    name: 'Làm dự án thực tế',
    description:
      'Học viên được thực hiện 5 đồ án cùng các chuyên gia sau mỗi môn học. Tham gia các dự án thực tế theo năng lực tại doanh nghiệp thực tập.',
    image: PATH_IMAGES.benefit_4,
  },
  {
    id: 5,
    name: 'Chương trình học toàn diện',
    description:
      'Kiến thức nên tảng chuyên sâu, tập trung thực hành. Được học và trải nghiệm các công nghệ lập trình mới nhất, bám sát nhu cầu tuyển dụng doanh nghiệp.        ',
    image: PATH_IMAGES.benefit_5,
  },
  {
    id: 6,
    name: 'Bảo hành khóa học',
    description:
      'Để nắm chắc kiến thức, học viên được miễn phí tham gia dự thính các môn học theo chương trình. Các tiết học được bổ sung kịp thời nhằm củng cố kiến thức.',
    image: PATH_IMAGES.benefit_6,
  },
];

export const PARTNER_ADMISSIONS = [
  {
    id: 1,
    image: PATH_IMAGES.partner_1,
  },
  {
    id: 2,
    image: PATH_IMAGES.partner_2,
  },
  {
    id: 3,
    image: PATH_IMAGES.partner_3,
  },
  {
    id: 4,
    image: PATH_IMAGES.partner_4,
  },
  {
    id: 5,
    image: PATH_IMAGES.partner_5,
  },
  {
    id: 6,
    image: PATH_IMAGES.partner_6,
  },
];

export const LIST_COURSE = [
  {
    image:
      'https://aptech.vn/wp-content/uploads/2024/01/banner-1900x750-1.png.webp',
    name: 'Lập trình viên quốc tế',
    description:
      'Chương trình đào tạo chuẩn quốc tế và toàn diện. Phù hợp với học sinh tốt nghiệp THPT, sinh viên và người định hướng theo nghề lập trình chuyên nghiệp.',
    discount: 'Học bổng 24.000.000 VNĐ',
    startTime: '3/2024',
  },
  {
    image:
      'https://aptech.vn/wp-content/uploads/2024/01/banner-1900x750-1.png.webp',
    name: 'Lập trình viên quốc tế',
    description:
      'Chương trình đào tạo chuẩn quốc tế và toàn diện. Phù hợp với học sinh tốt nghiệp THPT, sinh viên và người định hướng theo nghề lập trình chuyên nghiệp.',
    discount: 'Học bổng 24.000.000 VNĐ',
    startTime: '3/2024',
    endTime: '3/2024',
  },
  {
    image:
      'https://aptech.vn/wp-content/uploads/2024/01/banner-1900x750-1.png.webp',
    name: 'Lập trình viên quốc tế',
    description:
      'Chương trình đào tạo chuẩn quốc tế và toàn diện. Phù hợp với học sinh tốt nghiệp THPT, sinh viên và người định hướng theo nghề lập trình chuyên nghiệp.',
    discount: 'Học bổng 24.000.000 VNĐ',
    startTime: '3/2024',
    endTime: '3/2024',
  },
  {
    image:
      'https://aptech.vn/wp-content/uploads/2024/01/banner-1900x750-1.png.webp',
    name: 'Lập trình viên quốc tế',
    description:
      'Chương trình đào tạo chuẩn quốc tế và toàn diện. Phù hợp với học sinh tốt nghiệp THPT, sinh viên và người định hướng theo nghề lập trình chuyên nghiệp.',
    discount: 'Học bổng 24.000.000 VNĐ',
    startTime: '3/2024',
    endTime: '3/2024',
  },
  {
    image:
      'https://aptech.vn/wp-content/uploads/2024/01/banner-1900x750-1.png.webp',
    name: 'Lập trình viên quốc tế',
    description:
      'Chương trình đào tạo chuẩn quốc tế và toàn diện. Phù hợp với học sinh tốt nghiệp THPT, sinh viên và người định hướng theo nghề lập trình chuyên nghiệp.',
    discount: 'Học bổng 24.000.000 VNĐ',
    startTime: '3/2024',
    endTime: '3/2024',
  },
  {
    image:
      'https://aptech.vn/wp-content/uploads/2024/01/banner-1900x750-1.png.webp',
    name: 'Lập trình viên quốc tế',
    description:
      'Chương trình đào tạo chuẩn quốc tế và toàn diện. Phù hợp với học sinh tốt nghiệp THPT, sinh viên và người định hướng theo nghề lập trình chuyên nghiệp.',
    discount: 'Học bổng 24.000.000 VNĐ',
    startTime: '3/2024',
    endTime: '3/2024',
  },
];

export const LIST_MENU = [
  {
    Id: '00000000-0000-0000-0000-000000000000',
    Name: 'Khóa 1',
    Child: [
      {
        Id: '00000000-0000-0000-0000-000000000000',
        Name: 'Khóa con 1',
      },
      {
        Id: '00000000-0000-0000-0000-000000000000',
        Name: 'Khóa con 2',
      },
      {
        Id: '00000000-0000-0000-0000-000000000000',
        Name: 'Khóa con 3',
      },
    ],
  },
  {
    Id: '00000000-0000-0000-0000-000000000000',
    Name: 'Khóa 2',
    Child: [
      {
        Id: '00000000-0000-0000-0000-000000000000',
        Name: 'Khóa con 1',
      },
      {
        Id: '00000000-0000-0000-0000-000000000000',
        Name: 'Khóa con 2',
      },
      {
        Id: '00000000-0000-0000-0000-000000000000',
        Name: 'Khóa con 3',
      },
    ],
  },
];
