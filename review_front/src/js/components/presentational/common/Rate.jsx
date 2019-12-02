import React, { Component } from 'react'
import PropTypes from 'prop-types'

const CheckedStar = 'fa fa-star checked'
const UncheckedStar = 'fa fa-star'

//todo: also pls checks docs about function context (func -> this.bind(funcName) )

export default class Rate extends Component {
    constructor(props) {
        super(props)
    }

    onStartClick(event) {
        //todo: event when click on start, need get id of start, and recieve to upper component
    }

    render() {
        const {warmStars, starsCount, onChangeRate} = this.props
        const stars = []
        for(let i = 0; i < starsCount; ++i) {
            let { className, style }  = (i < warmStars) ? { className: CheckedStar, style: {color: 'orange'}} : { className: UncheckedStar, style: {color: 'black'}}
            stars.push(
                <span 
                    id={i}
                    style={style}
                    className={className}
                    onClick={onChangeRate}>
                </span>
            )
        }
        return (
            <div className='group-inline'>
                {stars}
            </div>
        )
    }
}

Rate.propTypes = {
    warmStars: PropTypes.number.isRequired,
    starsCount: PropTypes.number.isRequired,
    onChangeRate: PropTypes.func.isRequired
}