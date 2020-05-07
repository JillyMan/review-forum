import React from "react"
import ActivePlaceContainer from "../container/active-place-container"
import {getPlaceById} from "../../../api/places/place-service"

const ActivePlaceRoute = (props) => {

    const { placeId } = props.match.params

    const place = getPlaceById(placeId)

    return <ActivePlaceContainer selector={place}/>

}

export default ActivePlaceRoute