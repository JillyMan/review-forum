import React from 'react'
import { NavLink } from 'react-router-dom'

interface Props {
    className: string,
    link: string,
    name: string
}

const NavbarItem = ({
    className,
    link, 
    name
}: Props) => {
    return (
        <NavLink className={className} to={link}>{name}</NavLink>
    )
}

export default NavbarItem;