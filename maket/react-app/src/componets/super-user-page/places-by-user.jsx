import React from "react"
import ListOfPlacesContainer from "../places-by-category/containers/list-of-places-container"
import { getPlaceByUserId } from "../../api/user/user-service"
import PlaceCard from "../common/place-card"


const inlineOrientation = "inline"

const containerStyle = {
    marginTop: "20px",
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

const PlacesByUser = (props) => {

    const orientation = "block"

    const tabChange = (place) => {
        props.changeActiveTab("edit");
        props.selectedPlace(place)
    }

    const cards = getPlaceByUserId(1)[0].places.map((value, index) => (
        <div
            key={index}
            onClick={()=> tabChange(value)}>
            <PlaceCard
                orderNumber={index + 1}
                place={value}

            />
        </div>
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

export default PlacesByUser