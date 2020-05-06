import React from "react"

import PlaceCard from "../../common/place-card"

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

    const {placeConfigs, orientation} = props

    const cards = placeConfigs.map((value, index) => (
        <PlaceCard
            key={index}
            orderNumber={index + 1}
            data={value}
        />
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