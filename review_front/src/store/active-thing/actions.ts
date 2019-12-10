export const ADD_COMMENT = 'ADD_COMMENT'
export const STORE_THING = 'STORE_THING'
export const CLEAR_THING = 'CLEAR_THING'

import { CommentInfo, ThingConfig } from '../types'

type AddCommentAction = {
    type: typeof ADD_COMMENT,
    payload: CommentInfo
}

type StoreThingAction = {
    type: typeof STORE_THING,
    payload: ThingConfig
}

type ClearThingAction = {
    type: typeof CLEAR_THING,
}

export type ActiveThingAction = AddCommentAction | StoreThingAction | ClearThingAction

export const addComment = (comment: CommentInfo): AddCommentAction => ({
    type: ADD_COMMENT,
    payload: comment
})

export const storeThings = (thing: ThingConfig): StoreThingAction => ({
    type: STORE_THING,
    payload: thing
})

export const clearThing = (): ClearThingAction => ({
    type: CLEAR_THING
})