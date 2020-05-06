import React from 'react'
import ListOfPlacesContainer from '../containers/list-of-places-container'
import { getPlaceByCategory } from '../../../api/places/place-service'

export const PlacesRoute = (props) => {
    const { categoryId } = props.match.params

    return (
        <ListOfPlacesContainer selector={() => getPlaceByCategory(categoryId)}/>
    )
}