import React, { Component } from 'react'
import NavbarItem from '../presentational/common/navbar/navbar-item'
import NavbarBrand from '../presentational/common/navbar/navbar-brand'

class Navbar extends Component {
    render() {
        return (
            <nav className="navbar sticky-top navbar-dark bg-dark">
                <NavbarBrand link='#' name='R F'/>
                <NavbarItem link='#' name='Sign in'/>
                <NavbarItem link='#' name='Sign up'/>
            </nav>
        )
    }
}

export default Navbar;