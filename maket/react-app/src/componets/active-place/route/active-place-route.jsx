import React from "react"
import ActivePlaceContainer from "../container/active-place-container"
import {getPlaceById} from "../../../api/places/place-service"

const ActivePlaceRoute = (props) => {

    const { placeId } = props.match.params

    return <ActivePlaceContainer selector={() => getPlaceById(placeId)}/>

}

export default ActivePlaceRoute