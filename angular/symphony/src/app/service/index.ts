import axios, { AxiosError, AxiosResponse, InternalAxiosRequestConfig } from "axios";
// Set up default config for http requests here

const axiosService = axios.create({
	baseURL: 'http://localhost:2002/',
	timeout: 5000,
	headers: {
		"content-type": "application/json",
		// 'api_key': 'XClSdsB1Cqxamhcv6H3gfchn8az7FbT0',
	},
});

axiosService.interceptors.request.use(async (config: InternalAxiosRequestConfig) => {
    //handle setToken in header
	config.headers['Authorization'] = `Bearer ${getToken()}`;;

	return config;
}, function (error: AxiosError) {
	// Do something with request error
	return Promise.reject(error);
})

axiosService.interceptors.response.use(
	(response: AxiosResponse) => {
		if (response && response.data) {
			return response.data;
		}
		return response;
	},
	async (error: AxiosError) => {
		const errorData: any = error?.['response']?.['data'];

		switch (error?.['response']?.['status']) {
			case 401:
				//handle token

				return errorData;
			case 404:
				//handle notFound
				
				return errorData;
			break;
			case 500:
				//handle Error
				return errorData;
			default:
				return Promise.reject(error);
		}
	}
);

const setHeader = (name: string, value: string) => {
	axiosService.defaults.headers.common[name] = `Bearer ${value}`;
};

const removeHeader = (name: string) => {
	delete axiosService.defaults.headers.common[name];
};

const setToken = (token: string) => localStorage.setItem('Authorization', token);

const getToken = () => localStorage.getItem('Authorization');

export {
	axiosService,
	setHeader,
	removeHeader,
	setToken,
	getToken,
};