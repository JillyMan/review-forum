export const AUTH_CHANGE_LOGIN = 'AUTH_CHANGE_LOGIN'
export const AUTH_CHANGE_PASSWORD = 'AUTH_CHANGE_PASSWORD'

export const setLogin = (login: string): any => ({
    type: AUTH_CHANGE_LOGIN,
    payload: login
})

export const setPassword = (password: string): any => ({
    type: AUTH_CHANGE_PASSWORD,
    payload: password
})
