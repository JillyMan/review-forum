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
    
    return (
        <button 
            className="btn btn-primary"
            type={type}
            onClick={onBtnClick}>{name}</button>
    )
}

export default Button;