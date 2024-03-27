export interface CourseModel {
    id: number | null;
    name: string;
    code:string;
    amount: number;
    discount: number;
    thumbnail: string;
    startedDate: string;
    endedDate: string
  }

  export interface CourseCreateModel {
    id? :number;
    name: string;
    code:string;
    amount: number;
    discount: number;
    description: string;
    backGroundImage: File| null;
    startedDate: string;
    endedDate: string;
    active: boolean,
    gradePass: number;
    thumbnail: File| null;
    fee: number,
    feeChargeDate: string
  }

  