import { ADD_ARTICLE } from '../constants/action-types'

interface AuthState {
    isAuth: boolean,
}

interface ThingsState {
    things: any
}

interface SearchState {
    currentSearch: string,
}

interface SelectedThingState {
    thingId: string,
    descriptin: string,
    rate: number,
}

interface AppState { 
    auth?: AuthState,
    things?: ThingsState,     
    search?: SearchState,
    selectedThing?: SelectedThingState,
}

const initialState: AppState = {
}

const rootReducer = () => {

}

export default rootReducer