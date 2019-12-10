import React from 'react'
import Redux from 'redux'
import { connect } from "react-redux"
import { Auth } from "./auth"
import { AppState } from 'store/types'
import { existUser } from '../../../api/user'
import { UserInfoAction, storeUser, UserInfo } from '../../../store/user-info/actions'
import { AuthAction, AuthData, setAuthData } from '../../../store/auth/actions'
import { Allert } from '../../presentational/allerts/allert'

interface StateToProps { 
    isAuth: boolean
}

interface DispatchToProps { 
    onAuthDataSetup: (authData: AuthData) => void,
    onUserSignIn: (userInfo: UserInfo) => void
}

type Props = DispatchToProps & StateToProps

const AuthContainer = ({
    isAuth,
    onUserSignIn,
    onAuthDataSetup,
}: Props) => {

    const onBtnAuthClick = (login: string, pass: string) => {
        let responce = existUser(login, pass)
        if(responce) {
            // set navigation ?????
            onUserSignIn({userName: responce.userName})
            onAuthDataSetup({isAuth: true})
            return true
        }

        return false
    }

    if(isAuth) { 
        return <Allert 
                    type='warning' 
                    isHidden={isAuth} 
                    text='You already authorized!' />
    }
    else {
        return<Auth onBtnAuthClick={onBtnAuthClick}/>
    }
}

const mapStateToProps = (state: AppState): StateToProps => ({
    isAuth: state.auth.isAuth
})

type DispatchTypes = UserInfoAction | AuthAction
const mapDispatchToProps = (dispatch: Redux.Dispatch<DispatchTypes>): DispatchToProps => ({
    onUserSignIn: (userInfo: UserInfo) => dispatch(storeUser(userInfo)),
    onAuthDataSetup: (authData: AuthData) => dispatch(setAuthData(authData))
})

export default connect<StateToProps, DispatchToProps>(mapStateToProps, mapDispatchToProps)(AuthContainer)