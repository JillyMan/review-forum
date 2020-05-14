import React from "react"

import StarRatingComponent from 'react-star-rating-component';

const starCount = 5;
const rateImg = <span>&#9786;</span>


const StarRaiting = (props) => {

    const { rate, onRateChange } = props

    const rateChange = (e) => {
        onRateChange(e.target.value)
    }

    return (
        <StarRatingComponent
            name="starRaiting"
            renderStarIcon={() => rateImg}
            starCount={starCount}
            value={rate}
            onStarClick={rateChange}
        />
    )
}

export default StarRaiting