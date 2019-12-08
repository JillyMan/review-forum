import React from 'react'

interface Props { 
    text?: string
}

const Description = ({ text } : Props) => {
    return (
        <div className="shadow-lg p-3 mb-5 bg-white rounded">
            <p className='lead'>{text}</p>
        </div>
    )
}

export default Description;