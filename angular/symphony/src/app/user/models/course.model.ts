export interface CourseChildModel {
    Id: number;
    Name: string;
  }
  
  export interface CourseModuleMenuModel {
    Id: number;
    Name: string;
    Child: CourseChildModel[];
  }

  export interface CoursesModel{
    Id : number,
    Name: string,
    Description: string,
    Start_time: string,
    Discount: string
  }