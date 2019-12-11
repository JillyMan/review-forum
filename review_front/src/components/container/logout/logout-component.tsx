import React from 'react'
import Redux from 'redux'
import { connect } from 'react-redux'
import { clearAuthData, AuthAction } from '../../../store/auth/actions'
import { Redirect } from 'react-router'

interface Props {
    onLogout: () => void
}

const LogoutComponent = ({ onLogout }: Props) => {
    onLogout()
    return (<Redirect to='/'/>)
}

const mapDispatchToProps = (dispatch: Redux.Dispatch<AuthAction>): Props => ({
    onLogout: () => dispatch(clearAuthData())
})

export default connect(
    null,
    mapDispatchToProps
)(LogoutComponent)