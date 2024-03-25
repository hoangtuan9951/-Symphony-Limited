import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";

const classApi = {
    createClass(name: string): Promise<aboutUsState[]> {
        const url = '/api/admin/classes';
        return axiosService.post(url, { params: { name } });
    },
    getListClass(body: Partial<paramCreateAboutUs>): classesState[] {
        const url = `/api/admin/classes`;

        return [
            {
                id: 1,
                name: 'Hydrogen',
                start_time: '26-03-2024',
                amount: 30,
            },
            {
                id: 2,
                name: 'Helium',
                start_time: '26-03-2024',
                amount: 30,
            },
            {
                id: 3,
                name: 'Lithium',
                start_time: 'admin@gmail.com',
                amount: 20,
            },
        ]

        // return axiosService.get(url, body);
    },
    updateClass(body: Partial<paramCreateAboutUs>) {
        const url = `/api/admin/classes`;
        return axiosService.put(url, body);
    },
    deleteClass(id: number) {
        const url = `/api/admin/classes/${id}`;
        return axiosService.delete(url);
    },
}

export default classApi;