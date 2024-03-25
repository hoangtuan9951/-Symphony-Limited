import { axiosService } from "../../service/index";

const contactApi = {
    getListContact(email: string): contactState[] {
        const url = '/v1/admin/user-contact';

        return [
            {
                id: 1,
                name: 'Tran Hoang',
                message: 'ok nghe roi',
                status: 'unactive',
                address: 'Hải Hậu - Nam Định',
                email: 'phamvanliem26122002@gmail.com',
                phone_number: '0453874002',
                created_at: '20-03-2024',
                updated_at: '24-03-2024'
            },
            {
                id: 2,
                name: 'Tran Hoang',
                message: 'ok nghe roi',
                status: 'unactive',
                address: 'Cầu Giấy - Hà Nội',
                email: 'test@gmail.com',
                phone_number: '0453874002',
                created_at: '20-03-2024',
                updated_at: '24-03-2024'
            },
            {
                id: 3,
                name: 'Tran Hoang',
                message: 'ok nghe roi',
                status: 'unactive',
                address: 'Paris',
                email: 'alejandro@gmail.com',
                phone_number: '0453874002',
                created_at: '20-03-2024',
                updated_at: '24-03-2024'
            },
        ];
        // return axiosService.get(url, {params: {email}});
    },
    updateContact(body: contactState) {
        const url = `/v1/admin/user-contact/edit/${body.id}`;
        return axiosService.post(url, body);
    },
    deleteContact(id: number) {
        const url = `/v1/admin/user-contact/delete/${id}`;
        return axiosService.post(url);
    },
}

export default contactApi;