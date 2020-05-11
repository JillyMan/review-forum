import React from "react"

import PlaceCard from "../../common/place-card"

import "../../common/style/place-card.css"
import { Link } from "react-router-dom"

const inlineOrientation = "inline"

const containerStyle = {
    height: "100%",
    width: "100%",
    alignSelf: "center",
    alignItems: "center"
}

const blockOrinentation = {
    gridColumnGap: "10px",
    display: "grid",
    gridTemplateColumns: "auto auto"
}

const ListOfPlacesPresenter = (props) => {

    const { placeConfigs, orientation } = props

    const cards = placeConfigs.map((value, index) => (
        <Link
            to={`/active_places/${value.id}`}
            className="placeCardLink"
            key={index}>
            <PlaceCard
                key={index}
                orderNumber={index + 1}
                data={value}
            />
        </Link>
    ))

    return (
        <div style={containerStyle}>
            {orientation === inlineOrientation ?
                <div>
                    {cards}
                </div> :
                <div style={blockOrinentation}>
                    {cards}
                </div>
            }
        </div>
    )
}

export default ListOfPlacesPresenter