import React, { ReactElement } from 'react'

interface Props {
    id?: string,
    label?: string, 
    text?: string, 
    type?: string, 
    value?: string, 
    onInputChange?: (value: React.ChangeEvent<HTMLInputElement>) => void
}

const Input = ({
    id, 
    label,
    text,
    type, 
    value, 
    onInputChange
}: Props) => {

    const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        onInputChange(event);
    }

    return (
        <div className='form-group'>
            <label htmlFor={label}>{text}</label>
            <input
                id={id}
                type={type}
                value={value}
                className='form-control'
                onChange={handleChange}
                required
                />
        </div>
    )
}

export default Input