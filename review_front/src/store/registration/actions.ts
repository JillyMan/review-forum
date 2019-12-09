export const REGISTRATION_CHANGE_EMAIL = 'REGISTRATION_CHANGE_EMAIL'
export const REGISTRATION_CHANGE_LOGIN = 'REGISTRATION_CHANGE_LOGIN'
export const REGISTRATION_CHANGE_PASSWORD = 'REGISTRATION_CHANGE_PASSWORD'

export const setPassword = (password: string): any => ({
    type: REGISTRATION_CHANGE_PASSWORD,
    payload: password
})

export const setLogin = (login: string): any => ({
    type: REGISTRATION_CHANGE_LOGIN,
    payload: login
})

export const setEmail = (email: string): any => ({
    type: REGISTRATION_CHANGE_EMAIL,
    payload: email
})
