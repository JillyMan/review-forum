import React, { Component } from 'react'

interface Props {
    name: string,
    type?: 'submit' | 'reset' | 'button',
    onBtnClick?: () => void
}

const Button = ({
    name, 
    type, 
    onBtnClick} : Props
) => {
    
    const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
        onBtnClick()
    }

    return (
        <button 
            className="btn btn-primary"
            type={type}
            onClick={handleClick}>{name}</button>
    )
}

export default Button;