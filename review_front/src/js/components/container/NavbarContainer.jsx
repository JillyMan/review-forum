import React, { Component } from 'react'
import NavbarItem from '../presentational/common/navbar/NavbarItem'
import NavbarBrand from '../presentational/common/navbar/NavbarBrand'

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