import { axiosService } from "../../service/index";
import { HEADER } from '../constant/index';

const authApi = {
    helloWorld() {
        const url = '/';
        return axiosService.get(url);
    },
    login(body: any): Promise<string> {
        const url = '/api/admin/login';
        return axiosService.post(url, body);
    },
}

export default authApi;