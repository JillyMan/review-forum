import { ADD_COMMENT, STORE_THING } from "./actions"

export interface CommentInfo {
    userName: string,
    text: string,
}

export interface SelectedThing { 
    id: number,
    urlImage: string,
    rate: number,
    description: string,
    comments: CommentInfo[]
}

const defaultState: SelectedThing = {
    id: 0,
    urlImage: '',
    rate: 0,
    description: '',
    comments: []
}

export const selectedThingReducer = (state: SelectedThing = defaultState, action: any): SelectedThing => {
    switch (action.type) {
        case ADD_COMMENT:
            return {
                ...state,
                comments: action.payload
            }
        case STORE_THING:
            return {
                ...action.payload
            }
    }

    return state
}