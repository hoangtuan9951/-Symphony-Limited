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
    id : number,
    name: string,
    description: string,
    start_time: string,
    discount: string,
    image: string
  }