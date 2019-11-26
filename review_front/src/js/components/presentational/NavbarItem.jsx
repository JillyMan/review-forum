import React from 'react'
import PropTypes from 'prop-types'

const NavbarItem = ({link, name}) => {
    return (
        <a className='nav-link' href={link}>{name}</a>
    )
}

NavbarItem.propTypes = {
    link: PropTypes.string.isRequired,
    name: PropTypes.string.isRequired,
}

export default NavbarItem;