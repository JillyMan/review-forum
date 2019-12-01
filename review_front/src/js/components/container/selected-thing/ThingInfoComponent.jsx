import React, { Component } from 'react'
import Image from '../../presentational/common/Image'
import Rate from '../../presentational/Rate'
import Description from '../../presentational/Description'


class ThingInfoComponent extends Component {
    changeRate() {
    }
   
    render () {
        const { umageUrl, rate, description } = this.props;
        return (
            <div>              
                <Image
                    url={umageUrl}
                />
                <Rate
                    currentRate={rate} 
                    changeRate={this.changeRate}
                />
                <Description
                    text={description}/>
            </div>
        )
    }
}

export default ThingInfoComponent;