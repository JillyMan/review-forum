import React from 'react'
import { connect } from 'react-redux'
import NavbarItem from '../../presentational/common/navbar-item'
import { AppState } from 'store/types'

const NavbarItemStyle = 'nav-link'
const NavbarBrandStyle = 'navbar-brand'

interface StateProps {
    isAuth: boolean
}

type Props = StateProps

const NavbarContainer = ({isAuth}: Props) => {
    const items = [{
        active: !isAuth,
        name: 'Sign in',
        ref: '/signin'
    }, {
        active: isAuth,
        name: 'Logout', 
        ref: '/logout'
    }].map((item, index) => {
        if(item.active) {
            return <NavbarItem key={index} className={NavbarItemStyle} link={item.ref} name={item.name}/>
        }
    }).filter((value) => value);

    return (
        <nav className="navbar sticky-top navbar-dark bg-dark">
            <NavbarItem className={NavbarBrandStyle} link='/' name='RP'/>
            {items}
        </nav>
    )
}

const mapStateToProps = (state: AppState): StateProps => ({
    isAuth: state.auth.isAuth
})

export default connect<StateProps>(mapStateToProps)(NavbarContainer)