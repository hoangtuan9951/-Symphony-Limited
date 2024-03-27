import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";
import { StudentModel } from "../models/Student.model";

const studentService = {
    getList(): Promise<StudentModel[]> {
        const url = '/api/admin/students';
        return axiosService.get(url);
    },
     create(body: any) {
        const url = `/api/admin/students`;
        return axiosService.post(url, body);
    },
    update(body: any) {
        const url = `/api/admin/students`;
        return axiosService.put(url, body);
    },
    delete(id: number) {
        const url = `/api/admin/students?studentRollNumber=${id}`;
        return axiosService.delete(url);
    },
}

export default studentService;
