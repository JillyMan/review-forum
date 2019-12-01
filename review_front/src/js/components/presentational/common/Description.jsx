import React, {Comopnent } from 'react'
import PropTypes from 'prop-types'

const Description = ({text}) => {
    return (
        <p className='lead'>{text}</p>
    )
}

Description.propTypes = {
    text: PropTypes.string.isRequired
}

export default Description;