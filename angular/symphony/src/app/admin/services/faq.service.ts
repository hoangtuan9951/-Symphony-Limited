import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";
import { FAQModel } from "../models/FAQ.model";
import { StudentModel } from "../models/Student.model";

const faqService = {
    getList(): Promise<FAQModel[]> {
        const url = '/api/admin/faqs';
        return axiosService.get(url);
    },
     create(body: FAQModel) {
        const url = `/api/admin/faqs`;
        return axiosService.post(url, body);
    },
    update(body: FAQModel) {
        const url = `/api/admin/faqs`;
        return axiosService.put(url, body);
    },
    delete(id: number) {
        const url = `/api/admin/faqs/${id}`;
        return axiosService.delete(url);
    },
}

export default faqService;
