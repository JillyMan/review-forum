import React, { Component } from 'react'
import Image from '../../presentational/common/image'
import Rate from '../../presentational/common/rate'
import Description from '../../presentational/common/description'
import PropTypes from 'prop-types'

/*
    |       | Rate
    |image  | Desciption
*/
/*
    - Thing
        - Image
        - Rate
        - Description
*/

export default class ThingInfoComponent extends Component {
    constructor(props) {
        super(props)
    }
 
    changeRate() {
    }
   
    render () {
        const { urlImage, rate, description } = this.props;       
        return (
            <div>              
                <Image
                    url={urlImage}
                />
                <Rate
                    warmStars={4} 
                    starsCount={5}
                    onChangeRate={this.changeRate}
                />
                <Description
                    text={description}/>
            </div>
        )
    }
}

ThingInfoComponent.propTypes = {
    urlImage: PropTypes.string.isRequired,
    rate: PropTypes.number.isRequired,
    description: PropTypes.string.isRequired
}