import React from 'react'

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
        <a className={className} href={link}>{name}</a>
    )
}

export default NavbarItem;