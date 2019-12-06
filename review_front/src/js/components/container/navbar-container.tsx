import React, { Component } from 'react'
import NavbarItem from '../presentational/common/navbar-item'

const NavbarItemStyle = 'nav-link'
const NavbarBrandStyle = 'navbar-brand'

const NavbarContainer = () => {

    const items = ['Sign in', 'Sign up'].map((item, index) => {
        return <NavbarItem key={index} className={NavbarItemStyle} link='#' name={item}/>
    });

    return (
        <nav className="navbar sticky-top navbar-dark bg-dark">
            <NavbarItem className={NavbarBrandStyle} link='#' name='RP'/>
            {items}
        </nav>
    )
}

export default NavbarContainer;