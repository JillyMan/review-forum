import React from 'react'
import PropTypes from 'prop-types'

const Input = ({id, label, text, type, value, handleChange}) => {
    return (
        <div className='form-group'>
            <label htmlFor={label}>{text}</label>
            <input
                type={type}
                className='form-control'
                id={id}
                value={value}
                onChange={handleChange}
                required
                />
        </div>
    )
}

Input.propTypes = {
    id: PropTypes.string.isRequired,
    text: PropTypes.string.isRequired,
    type: PropTypes.string.isRequired,
    label: PropTypes.string.isRequired,
    value: PropTypes.string.isRequired,
    handleChange: PropTypes.func.isRequired,
}

export default Input