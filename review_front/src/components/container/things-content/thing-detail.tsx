import React from 'react'
import Image from '../../../components/presentational/common/image'
import Rate from '../../../components/presentational/common/rate'
import { NavLink } from 'react-router-dom'

interface Props { 
    id: number,
    img: string,
    rate: number,
    name: string,
}

export const ThingCardDetail = ({
    img,
    name,
    rate
}: Props) => {
    return (
        <div className='card' style={{width: '18rem'}}>
            <Image url={img} className='card-img-top'/>
            <div className='card-body'>
                <h5 className='card-title'>{name}</h5>
                <p className='card-text'>
                    <Rate starsCount={rate} warmStars={5}/>
                </p>
            </div>
            <NavLink to='/' className='btn btn-primary'/>
        </div>
    )    
}