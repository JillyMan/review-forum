import React from 'react'

interface Props { 
    text?: string
}

const Description = ({ text } : Props) => {
    return (
        <p className='lead'>{text}</p>
    )
}

export default Description;