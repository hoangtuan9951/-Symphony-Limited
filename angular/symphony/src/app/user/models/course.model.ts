export interface CourseChildModel {
    Id: number;
    Name: string;
  }
  
  export interface CourseModuleMenuModel {
    Id: number;
    Name: string;
    Child: CourseModuleMenuModel[];
  }
  export interface Child {
    Id: number;
    Name: string;
  }
  
  export interface CoursesModel{
    Id : number,
    Name: string,
    Description: string,
    Start_time: string,
    Discount: string,
    Image: string
  }