import React from 'react'
import { Redirect, Router, Route } from 'react-router'
import AuthContainer from '../auth-container'
import { AppState } from 'store/types'
import { connect } from 'react-redux'

interface Props { 
    isAuth: boolean
}

export const AuthRouter = ({isAuth}: Props) => {
    if (isAuth) {
        return <Redirect to='/'/>
    } else {
        return <Route path='/signin' component={AuthContainer}/>
    }
}

const mapStateToProps = (state: AppState): Props => ({
    isAuth: state.auth.isAuth
})

export default connect<Props>(mapStateToProps)(AuthRouter)