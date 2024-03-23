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
    description: 'About IT training',
    icon: PATH_IMAGES.top_1,
  },
  {
    id: 2,
    name: '20+',
    description: 'Years of experience',
    icon: PATH_IMAGES.top_2,
  },
  {
    id: 3,
    name: '10.000+',
    description: 'Graduation Academy',
    icon: PATH_IMAGES.top_3,
  },
  {
    id: 4,
    name: '100%',
    description: 'Employment commitment',
    icon: PATH_IMAGES.top_4,
  },
];

export const REASON_ADMISSIONS = [
  {
    id: 1,
    name: 'Thirsty for manpower',
    description:
      'According to TopDev, it is predicted that by 2024, Vietnam will lack 195,000 programmers/engineers annually.',
    backgroundColor: '#9e1d1d',
    color: 'white',
    boxShadow: 'none',
  },
  {
    id: 2,
    name: 'Digital age',
    description:
      'By 2025, Vietnam is expected to have 70,000 digital technology companies with 1.2 million people working in this field.',
    backgroundColor: 'white',
    color: 'black',
    boxShadow: '0px 10px 60px 0px rgba(0,0,0,.4)',
  },
  {
    id: 3,
    name: 'Development opportunities',
    description:
      'Vietnam is one of the top two software outsourcing destinations in Southeast Asia. Ranked 6th in software outsourcing services.',
    backgroundColor: '#E6E6E68A',
    color: 'black',
    boxShadow: '0px 10px 60px 0px rgba(0,0,0,.4)',
  },
  {
    id: 4,
    name: 'ATTRACTIVE SALARY',
    description:
      'Fresher positions range from $342 to just under $1,161 for Mid-Senior. Average salary of Full-Stack programmer 1359$ - 1683$.',
    backgroundColor: '#9e1d1d',
    color: 'white',
    boxShadow: 'none',
  },
];

export const COURSE_ADMISSIONS = [
  {
    id: 1,
    name: 'High school students',
    description:
      'Students from grades 10 to 12 love programming & technology and intend to pursue the Information Technology industry in the future.',
    image: PATH_IMAGES.course_1,
  },
  {
    id: 2,
    name: 'Student',
    description:
      'IT students want to supplement their knowledge and professional practice or students in other fields want to switch to programming.',
    image: PATH_IMAGES.course_2,
  },
  {
    id: 3,
    name: 'Worker',
    description:
      'Want to learn about programming languages, update new technology or new people want to switch to programming.',
    image: PATH_IMAGES.course_3,
  },
];

export const BENEFIT_ADMISSIONS = [
  {
    id: 1,
    name: 'Committed to supporting employment',
    description:
      'Students are introduced to internships at businesses immediately after 6 months of study. Job commitment after graduation with starting salary of 8 million.',
    image: PATH_IMAGES.benefit_1,
  },
  {
    id: 2,
    name: 'Dual International Degree',
    description:
      'Get an Advanced Diploma in Software Engineering valid in over 40 countries. Connect with International University to receive a Bachelor of Programming degree.',
    image: PATH_IMAGES.benefit_2,
  },
  {
    id: 3,
    name: 'Ensuring training quality',
    description:
      'Ensuring training quality with 24 students/class. Enhance interaction between students and lecturers. The Training Department closely follows and provides timely support.',
    image: PATH_IMAGES.benefit_3,
  },
  {
    id: 4,
    name: 'Do real projects',
    description:
      'Students can do 5 projects with experts after each subject. Participate in practical projects according to capacity at the internship company.',
    image: PATH_IMAGES.benefit_4,
  },
  {
    id: 5,
    name: 'Comprehensive curriculum',
    description:
    'Knowledge should be in-depth, focused on practice. Learn and experience the latest programming technologies, closely following business recruitment needs. ',
    image: PATH_IMAGES.benefit_5,
  },
  {
    id: 6,
    name: 'Course warranty',
    description:
      'To firmly grasp the knowledge, students are free to participate in auditing subjects according to the program. Lessons are added promptly to consolidate knowledge.',
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
    ],
  },
];

export const ROUTE_NOT_IN_LAYOUT_USER = [
  '/admin',
  '/login'
]
