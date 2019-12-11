import { SET_AUTH_DATA, AuthAction, CLEAR_AUTH_DATA } from "./actions"

export interface AuthState {
    isAuth: boolean
}

const defaultState: AuthState = { 
    isAuth: false
}

export const authReducer = (state: AuthState = defaultState, action: AuthAction): AuthState => {
    switch (action.type) {
        case SET_AUTH_DATA:
            return {
                ...state,
                ...action.payload,
            }
        case CLEAR_AUTH_DATA: 
            return {
                ...action.payload
        }
    }

    return state
}