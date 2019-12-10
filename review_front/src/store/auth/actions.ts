export const SET_AUTH_DATA = 'SET_AUTH_DATA'

export const setAuthData = (isAuth: boolean) => ({
    type: SET_AUTH_DATA,
    payload: isAuth
})
