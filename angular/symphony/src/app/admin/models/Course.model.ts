export interface CourseModel {
    id: number | null;
    name: string;
    code: string;
    amount: number;
    discount: string;
    description: string;
    courseDetail: string;
    backGroundImage: string;
    startedDate: string;
    endedDate: string;
    active: boolean
  }