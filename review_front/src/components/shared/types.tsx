export interface CommentInfo {  
    userName: string,
    commentText: string
}

export interface AuthorizedUser {
    id: number,
    isAutorized: boolean
    login: string,
}