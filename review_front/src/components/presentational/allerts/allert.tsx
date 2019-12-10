import React from 'react'

interface Props {
    type: 'primary' | 'secondary' |  'success' | 'warning' | 'info'
    text: string,
    isHidden: boolean
}

export const Allert = ({type, text, isHidden}: Props) => {
    return (
        <div 
            className={`alert alert-${type} text-center`}
            hidden={isHidden}>
            <p className='lead'>{text}</p>
        </div>
    )
}