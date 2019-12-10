import { ActiveThingConfig } from "./actions"
import { 
    ADD_COMMENT, 
    STORE_THING,
    CLEAR_THING
} from "./actions"

const defaultState: ActiveThingConfig = {
    id: -1,
    urlImage: '',
    rate: -1,
    description: '',
    comments: []
}

export const activeThingReducer = (state: ActiveThingConfig = defaultState, action: any): ActiveThingConfig => {
    switch (action.type) {
        case ADD_COMMENT:
            return {
                ...state,
                comments: [action.payload, ...state.comments]
            }
        case STORE_THING:
            return {
                ...action.payload
            }
        case CLEAR_THING:
            return {
                ...defaultState
            }
    }

    return state
}