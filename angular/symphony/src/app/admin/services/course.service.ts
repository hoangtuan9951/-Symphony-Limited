import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";
import { CourseCreateModel, CourseModel } from "../models/Course.model";

const courseService = {
    getList(): Promise<CourseModel[]> {
        const url = '/api/admin/courses';
        return axiosService.get(url,);
    },
     create(body: any) {
        const url = `/api/admin/courses`;
        return axiosService.post(url, body);
    },
    update(body: any) {
        const url = `/api/admin/courses`;
        return axiosService.put(url, body);
    },
    delete(id: number) {
        const url = `/api/admin/courses/${id}`;
        return axiosService.delete(url);
    },
}

export default courseService;