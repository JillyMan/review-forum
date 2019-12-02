import React from 'react'
import PropTypes from 'prop-types'

const Image = ({url, width = 250, height = 250}) => {
    return (
        <div className='shadow-sm p-3 mb-5 bg-white rounded'>
            <img src={url} width={width} height={height}/>
        </div>
    )
}

Image.propTypes = {
    url: PropTypes.string.isRequired,
    width: PropTypes.number,
    height: PropTypes.number
}

export default Image;