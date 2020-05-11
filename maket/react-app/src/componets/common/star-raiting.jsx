import React from "react"

import StarRatingComponent from 'react-star-rating-component';

const starCount = 5;
const rateImg = <span>&#9786;</span>


const StarRaiting = (props) => {
    return (
        <StarRatingComponent
            name="starRaiting"
            renderStarIcon={() => rateImg}
            starCount={starCount}
            value={props.rate}
        />
    )
}

export default StarRaiting