import { SUCCESS, INCORRECT_LOGIN } from './shared'

const USERS_KEY = 'USERS'

export interface IUser { 
    id: number,
    email: string    
    pass: string,
    login: string,
}

export const getUsers = (): IUser[] => {
    return JSON.parse(localStorage.getItem(USERS_KEY) || '[]') as IUser[]
}

export interface IUserAuth { 
    email: string    
    pass: string,
    login: string,
}

export const addUser = (userInfo: IUserAuth): string => {
    const { login, pass, email } = userInfo
    const user: IUser = {
        id: Date.now(),
        login,
        pass,
        email
    } 
    
    const users = getUsers()
    users.push(user)
    const exisingUser = users.filter(u => u.login == user.login)

    if (exisingUser) {
        return INCORRECT_LOGIN
    }
    else {
        localStorage.setItem(USERS_KEY, JSON.stringify(users))
    }

    return SUCCESS
}

export const existUser = (login: string): boolean => { 
    const users = getUsers()
    const result = !!users.filter(u => u.login == login)
    return result
}