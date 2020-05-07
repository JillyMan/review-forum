import React from "react"
import "./style/place-card.css"
import { Link } from "react-router-dom"

import StarRatingComponent from 'react-star-rating-component';
import ContactInfo from "./contact-info";

const rateImg = <span>&#9786;</span>
const imgAlt = "..."
const starCount = 5;

const cardStyle = {
    maxWidth : "440px"
}

const imgContainerStyle = {
    alignSelf : "center"
}

const imgWrapperStyle = {
    height: "160px" 
}

const imgStyle = {
    height : "100%"
}

const raitingStyle = {
    textAlign: "right",
    fontSize: 18
}

const placeNameStyle = {
    fontWeight: "bold"
}

const PlaceCard = (props) => {

    return (
        <Link to={`/active_places/${props.data.id}`} className="placeCardLink">
            <div className="card mb-3" style={cardStyle}>
                <div className="row no-gutters">
                    <div className="col-md-4" style={imgContainerStyle}>
                        <div style={imgWrapperStyle}>
                            <img src={props.data.imgUrl} style={imgStyle} className="card-img" alt={imgAlt} />
                        </div>
                    </div>
                    <div className="col-md-8">
                        <div className="card-body">
                            <div className="firstRow">
                                <div style={placeNameStyle}>
                                    {props.orderNumber + ". "}
                                    {props.data.name.toUpperCase()}
                                </div>
                                <div style={raitingStyle}>
                                    <StarRatingComponent rate={props.data.rate} />
                                </div>
                            </div>
                            <ContactInfo data={props.data} />
                        </div>
                    </div>
                </div>
            </div>
        </Link>
    )
}

export default PlaceCard