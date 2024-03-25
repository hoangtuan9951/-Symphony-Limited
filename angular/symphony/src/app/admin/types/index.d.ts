interface infoUser {
    id: number,
    email: string,
    role: string,
    user_name: string,
    success: boolean,
    password?: boolean,
    created_at?: string,
    updated_at?: string,
}

interface contactState {
    email: string,
    id: number,
    name: string,
    address: string,
    phone_number: string,
    message:  string,
    status: string, //active','unactive'
    created_at: string,
    updated_at: string,
}

interface aboutUsState {
    id?: number,
    description: string,
    backgroundImage: string,
    created_at?: string,
    updated_at?: string,
}

interface paramCreateAboutUs {
    id?: number;
    Description: string;
    BackgroundImage: File | null;
}

interface paramCreateClass{
    name: string;
    amount: string;
    start_time: string;
}

interface classesState {
    id?: number,
    name: string,
    start_time: string,
    amount: number,
}