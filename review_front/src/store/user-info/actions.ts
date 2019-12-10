export const STORE_USER_INFO = 'STORE_USER_INFO'
export const LOG_OUT = 'LOG_OUT'

export interface UserInfo { 
    userName: string,
}

type StoreUserInfo = {
    type: typeof STORE_USER_INFO,
    payload: UserInfo
}

type LogOutAction = {
    type: typeof LOG_OUT,
    payload: UserInfo
}

export type UserInfoAction = StoreUserInfo | LogOutAction

export const storeUser = (userInfo: UserInfo): StoreUserInfo => ({
    type: STORE_USER_INFO,
    payload: userInfo
})

export const logOut = (): LogOutAction => ({
    type: LOG_OUT,
    payload: null
})