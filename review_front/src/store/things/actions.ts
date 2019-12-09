export const ADD_COMMENT = 'ADD_COMMENT'

export const addComment = (comment: string) => ({
    type: ADD_COMMENT,
    payload: comment
})
