import React from "react"
import ListOfPlacesContainer from "../places-by-category/containers/list-of-places-container"
import { getPlaceByUserId } from "../../api/user/user-service"

const PlacesByUser = () => {

    return <ListOfPlacesContainer selector={() => getPlaceByUserId(1)[0].places} />

}

export default PlacesByUser