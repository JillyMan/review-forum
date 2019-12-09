export const ADD_COMMENT = 'ADD_COMMENT'
export const STORE_THING = 'STORE_THING'

export const selectThings = (thing: any) => ({
    type: typeof STORE_THING,
    payload: thing
})

export const addComment = (comment: string) => ({
    type: typeof ADD_COMMENT,
    payload: comment
})
