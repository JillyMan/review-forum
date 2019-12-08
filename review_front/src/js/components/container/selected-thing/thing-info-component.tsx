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
        <div className='container'>
            <div className='row'>
                <div className='col-4'>
                    <Image
                        url={urlImage}
                        width='240'
                        height='200'
                    />
                    <Rate
                        warmStars={rate} 
                        starsCount={5}
                        onChangeRate={onRateChaged}
                    />
                </div>
                <div className='col-8'>
                    <Description
                        text={description}/>
                </div>
            </div>
        </div>
    )
}

export default ThingInfoComponent;