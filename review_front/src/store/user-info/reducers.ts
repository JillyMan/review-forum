import { STORE_USER_INFO, LOG_OUT } from "./actions"

export interface UserState { 
    userName: string,
}

const defaultState: UserState = { 
    userName: 'Artsiom'
}

export const userReducer = (state: UserState = defaultState, action: any) => {
    switch (action.type) {
        case STORE_USER_INFO:
            return {
                ...state,
                userName: action.payload
            }
        case LOG_OUT:
            return {
                ...state,
                userName: ''
            }
    }
    return state
}