import React from 'react'

const CheckedStarStyle = {
    className: 'fa fa-star checked',
    style: { color: 'orange' }
}

const UncheckedStar = { 
    className: 'fa fa-star',
    style: { color: 'black' }
}

interface Props { 
    warmStars: Number,
    starsCount: Number,
    onChangeRate: (changedValue: Number) => void 
}

const Rate = ({
    warmStars,
    starsCount,
    onChangeRate
}: Props) => {

    const onStartClick = () => {
        const putHereNewRate = 5
        onChangeRate(putHereNewRate)
    }

    const stars = []
    for(let i = 0; i < starsCount; ++i) {
        let { className, style }  = (i < warmStars) ? CheckedStarStyle : UncheckedStar
        stars.push(
            <span
                key={i}
                style={style}
                className={className}
                onClick={onStartClick}>
            </span>
        )
    }
    return (
        <div className='group-inline'>
            {stars}
        </div>
    )
}

export default Rate;