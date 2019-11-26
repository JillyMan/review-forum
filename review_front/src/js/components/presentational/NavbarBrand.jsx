import React from 'react'
import PropTypes from 'prop-types'

const NavbarBrand = ({link, name}) => {
    return (
        <a className='navbar-brand' href={link}>{name}</a>
    )
}

NavbarBrand.propTypes = {
    link: PropTypes.string.isRequired,
    name: PropTypes.string.isRequired,
}

export default NavbarBrand;