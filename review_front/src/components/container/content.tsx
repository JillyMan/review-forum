import React from 'react'
import { connect } from "react-redux"
import AuthContainer from './auth/auth-container'
import ActiveThingComponent from './active-thing/active-thing-component'
import ThingsContainer from './things-content/things-container'

interface Props {
    isAuth: boolean
}

const CurrentContentComponent = ({isAuth}: Props) => {
    if(isAuth) {
        //return <ActiveThingComponent />
        return <ThingsContainer />
    }
    else {
        return <AuthContainer />
    }
}

const mapStateToProps = (state: any): Props => {
    return {
        isAuth: state.auth.isAuth
    }
}

export default connect(mapStateToProps)(CurrentContentComponent)