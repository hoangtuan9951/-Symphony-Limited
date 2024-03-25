import { axiosService } from "../../service/index";

const adminApi = {
    helloWorld() {
        const url = '/';
        return axiosService.get(url);
    },
    getUserInfo(): infoUser {
        const url = '/v1/admin/info';

        return {
            success: true,
            id: 1,
            user_name: 'Thanh Liem',
            email: 'phamvanliem26122002@gmail.com',
            role: 'admin'
        }
        // return axiosService.get(url);
    },
    getListAdmin(user_name: string): infoUser[] {
        const url = '/v1/admin';

        return [
            {
                success: true,
                id: 1,
                user_name: 'Thanh Liem',
                email: 'phamvanliem26122002@gmail.com',
                role: 'admin',
                created_at: '20-03-2024',
                updated_at: '24-03-2024'
            },
            {
                success: true,
                id: 2,
                user_name: 'Alejandro',
                email: 'alejandro@gmail.com',
                role: 'admin',
                created_at: '20-03-2024',
                updated_at: '24-03-2024'
            },
            {
                success: true,
                id: 3,
                user_name: 'Tran Huy Hoang',
                email: 'tranhoang2102@gmail.com',
                role: 'admin',
                created_at: '20-03-2024',
                updated_at: '24-03-2024'
            },
        ];
        // return axiosService.get(url, {params: {user_name}});
    },
    updateAdmin(body: {id: number, password: string}) {
        const url = `/v1/admin/update/${body.id}`;
        return axiosService.post(url, body);
    },
    deleteAdmin(id: number) {
        console.log("🚀 ~ id:", id)
        const url = `/v1/admin/delete/${id}`;
        return axiosService.post(url);
    },
}

export default adminApi;