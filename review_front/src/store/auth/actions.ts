export const SET_AUTH_DATA = 'SET_AUTH_DATA'
export const CLEAR_AUTH_DATA = 'CLEAR_AUTH_DATA'

export interface AuthData {
    isAuth: boolean
}

type SetAuthDataAction = {
    type: typeof SET_AUTH_DATA,
    payload: AuthData
}

type ClearAuthDataAction = {
    type: typeof CLEAR_AUTH_DATA,
    payload: null | AuthData,
}

export type AuthAction = SetAuthDataAction | ClearAuthDataAction

export const setAuthData = (auth: AuthData): SetAuthDataAction => ({
    type: SET_AUTH_DATA,
    payload: auth
})

export const clearAuthData = (): ClearAuthDataAction => ({
    type: CLEAR_AUTH_DATA,
    payload: null,
})