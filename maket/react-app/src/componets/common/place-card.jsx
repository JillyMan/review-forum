import React from "react"

import ContactInfo from "./contact-info";
import StarRaiting from "./star-raiting";

const imgAlt = "..."

const cardStyle = {
}

const imgContainerStyle = {
    alignSelf: "center"
}

const imgWrapperStyle = {
    height: "160px"
}

const imgStyle = {
    height: "100%"
}

const raitingStyle = {
    textAlign: "right",
    fontSize: 18
}

const placeNameStyle = {
    fontWeight: "bold"
}

const PlaceCard = (props) => {

    const { place } = props

    return (
        <div className="card mb-3" style={cardStyle}>
            <div className="row no-gutters">
                <div className="col-md-4" style={imgContainerStyle}>
                    <div style={imgWrapperStyle}>
                        <img src={place.image.imageUrl} style={imgStyle} className="card-img" alt={imgAlt} />
                    </div>
                </div>
                <div className="col-md-8">
                    <div className="card-body">
                        <div className="firstRow">
                            <div style={placeNameStyle}>
                                {props.orderNumber + ". "}
                                {place.name.toUpperCase()}
                            </div>
                            <div style={raitingStyle}>
                                <StarRaiting rate={place.rate} />
                            </div>
                        </div>
                        <ContactInfo data={place} />
                    </div>
                </div>
            </div>
        </div>
    )
}

export default PlaceCard