import { AUTH_CHANGE_LOGIN, AUTH_CHANGE_PASSWORD } from "./actions"

export interface AuthState {
    login: string,
    password: string,
}

const defaultState: AuthState = { 
   login: '',
   password: '',
}

export const authReducer = (state: AuthState = defaultState, action: any): AuthState => {
    switch (action.type) {
        case AUTH_CHANGE_LOGIN:
            return {
                ...state, 
                login: action.payload
            }
        case AUTH_CHANGE_PASSWORD:
            return {
                ...state, 
                password: action.payload
            }
    }

    return state
}