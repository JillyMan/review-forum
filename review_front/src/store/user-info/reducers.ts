import {
    UserInfoAction,
    STORE_USER_INFO,
    LOG_OUT
 } from "./actions"

export interface UserState {
    userName: string,
}

const defaultState: UserState = {
    userName: ''
}

export const userReducer = (state: UserState = defaultState, action: UserInfoAction) => {
    switch (action.type) {
        case STORE_USER_INFO:
            return {
                ...state,
                ...action.payload
            }
        case LOG_OUT:
            return {
                ...state,
                ...action.payload
            }
    }
    return state
}