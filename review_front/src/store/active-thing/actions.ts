export const ADD_COMMENT = 'ADD_COMMENT'
import { CommentInfo} from '../types'

export const STORE_THING = 'STORE_THING'
export const CLEAR_THING = 'CLEAR_THING'

export interface ActiveThingConfig { 
    id: number,
    rate: number,
    urlImage: string,
    description: string,
    comments: CommentInfo[]
}

type AddCommentAction = {
    type: typeof ADD_COMMENT,
    payload: CommentInfo
}

type StoreThingAction = {
    type: typeof STORE_THING,
    payload: ActiveThingConfig
}

type ClearThingAction = {
    type: typeof CLEAR_THING,
}

export type ActiveThingAction = AddCommentAction | StoreThingAction | ClearThingAction

export const addComment = (comment: CommentInfo): AddCommentAction => ({
    type: ADD_COMMENT,
    payload: comment
})

export const storeActiveThing = (thing: ActiveThingConfig): StoreThingAction => ({
    type: STORE_THING,
    payload: thing
})

export const clearThing = (): ClearThingAction => ({
    type: CLEAR_THING
})