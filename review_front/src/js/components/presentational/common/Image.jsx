import React from 'react'
import PropTypes from 'prop-types'

const Image = ({url}) => {
    return (
        <div className='shadow-sm p-3 mb-5 bg-white rounded'>
            <img src={url}/>
        </div>
    )
}

Image.propTypes = {
    url: PropTypes.string.isRequired
}

export default Image;