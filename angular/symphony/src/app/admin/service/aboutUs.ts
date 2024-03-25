import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";

const aboutUsApi = {
    getListAboutUs(description: string): Promise<aboutUsState[]> {
        const url = '/api/admin/abouts';
        return axiosService.get(url, {params: {description}});
    },
     createAboutUs(body: Partial<paramCreateAboutUs>) {
        const url = `/api/admin/abouts`;
        return axiosService.post(url, body,  {headers: {[HEADER.CONTENT_TYPE]: 'multipart/form-data'}});
    },
    updateAboutUs(body: Partial<paramCreateAboutUs>) {
        const url = `/api/admin/abouts`;
        return axiosService.put(url, body, {headers: {[HEADER.CONTENT_TYPE]: 'multipart/form-data'}});
    },
    deleteAboutUs(id: number) {
        const url = `/api/admin/abouts/${id}`;
        return axiosService.delete(url);
    },
}

export default aboutUsApi;