import { ADD_ARTICLE }  from '../constants/action-types'

export function addArticle(payload: any) {
    return {
        type: ADD_ARTICLE,
        payload
    }
}