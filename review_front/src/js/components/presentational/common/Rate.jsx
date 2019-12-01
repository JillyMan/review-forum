import React, { Component } from 'react'
import PropTypes from 'prop-types'

const CheckedStar = 'fa fa-star checked'
const UncheckedStar = 'fa fa-star'

//todo: also pls checks docs about function context (func -> this.bind(funcName) )

class Rate extends Component {
    constructor(props) {
        super(props)
    }

    onStartClick(event) {
        //todo: event when click on start, need get id of start, and recieve to upper component
    }

    render() {
        const {warmStars, starsCount, onChangeRate} = this.props
        const StarsComponent = Array(starsCount).map((v, i) => {
            let className = i < warmStars ? CheckedStar : UncheckedStar
            let style = i < warmStars ? {color: 'orange'} : {color: 'black'}
            return (
                <span 
                    id={i}
                    style={style}
                    className={className}
                    onClick={onChangeRate}>
                </span>
            )
        })
    
        return (
            <div className='group-inline'>
                <StarsComponent />
            </div>
        )
    }
}

Rate.propTypes = {
    warmStars: PropTypes.number.isRequired,
    starsCount: PropTypes.number.isRequired,
    onChangeRate: PropTypes.func.isRequired
}

export default Rate;