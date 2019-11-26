import React, { Component } from 'react'
import PropTypes from 'prop-types'

const Button = ({name, type, handlePress}) => {
    return (
        <button 
            className="btn btn-primary"
            type={type}
            onClick={handlePress}
        >
        {name}
        </button>
    )
}

Button.propTypes = {
    name: PropTypes.string.isRequired,
    type: PropTypes.string.isRequired,
    handlePress: PropTypes.func.isRequired,
}

export default Button;