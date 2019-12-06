import React, { Component } from 'react'
import Image from '../../presentational/common/image'
import Rate from '../../presentational/common/rate'
import Description from '../../presentational/common/description'
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

interface Props { 
    rate: Number,
    urlImage: string, 
    description?: string       
}

const ThingInfoComponent = ({ 
    rate, 
    urlImage, 
    description 
}: Props) => {
    const onRateChaged = (newRate: Number) => {
    }

    return (
        <div>              
            <Image
                url={urlImage}
            />
            <Rate
                warmStars={rate} 
                starsCount={5}
                onChangeRate={onRateChaged}
            />
            <Description
                text={description}/>
        </div>
    )
}

export default ThingInfoComponent;