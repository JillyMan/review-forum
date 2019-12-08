import { combineReducers } from 'redux'
import { authReducer } from './auth/reducers'
import { registrionReducer } from './registration/reducers'
import { selectedThingReducer } from './things/reducers'

interface AuthState {
    isAuth: boolean,
}

interface ThingsState {
    things: any
}

interface SearchState {
    currentSearch: string,
}

export interface SelectedThingState {
    thingId: string,
    descriptin: string,
    rate: number,
}

export interface AppState { 
    auth?: AuthState,
    things?: ThingsState,     
    search?: SearchState,
    selectedThing?: SelectedThingState,
}

const initialState: AppState = {
}

export default combineReducers({
    auth: authReducer,
    registration: registrionReducer,
    thing: selectedThingReducer,
})