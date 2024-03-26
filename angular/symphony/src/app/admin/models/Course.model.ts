export interface CourseModel {
    id: number | null;
    name: string;
    code: string;
    amount: number;
    discount: string;
    thumbnail: string;
    startedDate: string;
    endedDate: string;
    active: boolean
  }

  export interface CourseCreateModel {
    id? :number;
    name: "";
    code: "";
    amount: 0;
    discount: 0;
    description: "";
    courseDetail: "";
    backGroundImage: File| null;
    startedDate: "";
    endedDate: "";
    active: boolean,
    gradePass: 0;
    thumbnail: File| null;
  }

  