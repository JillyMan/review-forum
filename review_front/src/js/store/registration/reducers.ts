import { REGISTRATION_CHANGE_LOGIN, REGISTRATION_CHANGE_PASSWORD, REGISTRATION_CHANGE_EMAIL } from "./actions"

export interface RegistrationState {
    login: string,
    password: string,
    email: string,
    repeatPassword: string
}

const defaultState: RegistrationState = { 
   login: '',
   email: '',
   password: '',
   repeatPassword: ''
}

export const registrionReducer = (state: RegistrationState = defaultState, action: any): RegistrationState => {
    switch (action.type) {
        case REGISTRATION_CHANGE_LOGIN:
            return {
                ...state, 
                login: action.payload
            }
        case REGISTRATION_CHANGE_EMAIL:
            return {
                ...state,
                email: action.payload
            } 
        case REGISTRATION_CHANGE_PASSWORD:
            return {
                ...state, 
                password: action.payload
            }
    }

    return state
}