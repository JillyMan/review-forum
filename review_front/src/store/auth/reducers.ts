import { SET_AUTH_DATA } from "./actions"

export interface AuthState {
    isAuth: boolean
}

const defaultState: AuthState = { 
    isAuth: true
}

export const authReducer = (state: AuthState = defaultState, action: any): AuthState => {
    switch (action.type) {
        case SET_AUTH_DATA:
            return {
                ...state, 
                isAuth: action.payload
            }
    }

    return state
}