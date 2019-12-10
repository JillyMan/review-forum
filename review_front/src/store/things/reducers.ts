import { ThingsConfig, STORE_THINGS } from './actions'

const defaultState: ThingsConfig = {
    configs: []
}

export const thingsReducer = (state: ThingsConfig = defaultState, action: any) => {
    switch (action.type) {
        case STORE_THINGS:
            return {
                ...action.payload
            }
    }
    return state
}