import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";
import { CourseModules } from "../models/CourseModule.model";

const courseModuleService = {
    getList(): Promise<CourseModules[]> {
        const url = '/api/admin/course-modules';
        return axiosService.get(url,);
    },
     create(body: Partial<any>) {
        const url = `/api/admin/course-modules`;
        return axiosService.post(url, body,  {headers: {[HEADER.CONTENT_TYPE]: 'multipart/form-data'}});
    },
    update(body: Partial<any>) {
        const url = `/api/admin/course-modules`;
        return axiosService.put(url, body, {headers: {[HEADER.CONTENT_TYPE]: 'multipart/form-data'}});
    },
    delete(id: number) {
        const url = `/api/admin/course-modules/${id}`;
        return axiosService.delete(url);
    },
}

export default courseModuleService;