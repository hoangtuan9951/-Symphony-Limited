import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";
import { ContactUsModel } from "../models/ContactUs.model";
import { StudentModel } from "../models/Student.model";

const contactService = {
    getList(): Promise<ContactUsModel[]> {
        const url = '/api/admin/contacts';
        return axiosService.get(url);
    },
     create(body: any) {
        const url = `/api/admin/contacts`;
        return axiosService.post(url, body);
    },
    update(body: any) {
        const url = `/api/admin/contacts`;
        return axiosService.put(url, body);
    },
    delete(id: number) {
        const url = `/api/admin/contacts/${id}`;
        return axiosService.delete(url);
    },
}

export default contactService;
