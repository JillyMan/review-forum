import React, { ReactText } from 'react'

interface Props {
    url: string,
    className?: string,
    width?: ReactText,
    height?: ReactText
}

const Image = ({
    url,
    className = 'img-thumbnail',
    width = 250, 
    height = 250
}: Props) => {

    return (
        <div className='shadow-sm p-3 mb-5 bg-white rounded'>
            <img className={className} src={url} width={width} height={height}/>
        </div>
    )
}

export default Image;