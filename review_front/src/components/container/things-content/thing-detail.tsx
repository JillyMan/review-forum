import React from 'react'
import Image from 'components/presentational/common/image'
import { BorderContainer } from 'components/presentational/common/container'
import Rate from 'components/presentational/common/rate'

interface Props { 
    img: string,
    name: string,
    rate: number
}

export const ThingCardDetail = ({
    img,
    name,
    rate
}: Props) => {
    return (
        <BorderContainer>
            <>
                <h3>{name}</h3>
                <Rate 
                    warmStars={rate}
                    starsCount={5}/>
                <Image 
                    url={img}
                    width={100} 
                    height={100}/>
 
            </>
        </BorderContainer>
    )    
}