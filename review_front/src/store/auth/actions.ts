export const SET_AUTH_DATA = 'SET_AUTH_DATA'

export interface AuthData {
    isAuth: boolean
}

type SetAuthDataAction = {
    type: typeof SET_AUTH_DATA,
    payload: AuthData
}

export type AuthAction = SetAuthDataAction

export const setAuthData = (auth: AuthData): SetAuthDataAction => ({
    type: SET_AUTH_DATA,
    payload: auth
})
