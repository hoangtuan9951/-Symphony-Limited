export const MENU_ADMIN = [
    {
        name: 'Manage admin',
        icon: 'bi bi-person-lines-fill',
        active: true,
        href: 'manage-admin',
    },
    {
        name: 'Manage Module',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'manage-module',
    },
    {
        name: 'Manage Course',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'manage-admin',
    },
    {
        name: 'Manage Student',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'student',
    },
    {
        name: 'Contact',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'contact',
    },
    {
        name: 'Manage Classes',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'manage-class',
    },
    {
        name: 'About Us',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'about-us',
    },
    {
        name: 'FAQ',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'manage-faq',
    },
    {
        name: 'Contact us',
        icon: 'bi bi-person-lines-fill',
        active: false,
        href: 'contact-us',
    },
]

export const getBase64 = (file: File): Promise<string> =>
    new Promise((resolve, reject) => {
        const reader = new FileReader();
        reader.readAsDataURL(file);
        reader.onload = () => resolve(reader.result as string);
        reader.onerror = (error) => reject(error);
    });