
export const isJson = (str: string) => {
    try {
        JSON.parse(str);
    } catch (e) {
        return false;
    }
    return true;
};

// @ts-ignore
export const debounce = (fn, delay) => {
    let timerId: number | null;

    return (...arg: any) => {
        if(timerId) {
            clearTimeout(timerId);
            timerId = null;
        }

        // @ts-ignore
        timerId = setTimeout(() => {
            fn.apply(this, arg)
        }, delay);
    }
}