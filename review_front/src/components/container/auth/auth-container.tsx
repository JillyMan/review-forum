import React from 'react'
import { connect } from "react-redux"
import { Auth } from "./auth"
import { AuthProps } from './shared'

const AuthContainer = ({
    pass, 
    login, 
    setPass,
    setLogin, 
    onBtnAuthClick
}: AuthProps) => {
    return (
        <Auth 
            login={login}
            pass={pass}
            setLogin={setLogin}
            setPass={setPass}
            onBtnAuthClick={onBtnAuthClick}
        />
    )
}

const mapStateToProps = (state: any) => {
    return {
        login: state.auth.login,
        password: state.auth.password
    }
}

const mapDispatchToProps = {
    // setLogin,
    // setPassword
}

export default connect(mapStateToProps, mapDispatchToProps)(AuthContainer)