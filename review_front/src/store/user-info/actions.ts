export const STORE_USER_INFO = 'STORE_USER_INFO'
export const LOG_OUT = 'LOG_OUT'

export const storeUser = (userName: string) => ({
    type: STORE_USER_INFO,
    payload: userName
})

export const logOut = () => ({
    type: LOG_OUT,
    payload: ''
})