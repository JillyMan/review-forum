import React, { Component } from 'react'
import PropTypes from 'prop-types'

const Button = ({name, type, onBtnClick}) => {
    return (
        <button 
            className="btn btn-primary"
            type={type}
            onClick={onBtnClick}>{name}</button>
    )
}

Button.propTypes = {
    name: PropTypes.string.isRequired,
    type: PropTypes.string.isRequired,
    onBtnClick: PropTypes.func.isRequired,
}

export default Button;