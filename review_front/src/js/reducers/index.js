import { ADD_ARTICLE } from '../constants/action-types'

const test_state = {
    auth: {},
    things: {},
    search: {},
    selectedPage: {},
}

const initialState = {
    articles: []
}
const rootReducer = (state = initialState, action) => {
    switch (action.type) {
        case ADD_ARTICLE: 
        {
            return {
                articles: [action.payload, ...state.articles]
            }
        }
        default:
            return state
    }
}

export default rootReducer