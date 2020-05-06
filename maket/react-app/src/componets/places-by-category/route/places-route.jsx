import React from 'react'
import ListOfPlacesContainer from '../containers/list-of-places-container'

export const PlacesRoute = (props) => {
    const { categoryId } = props.match.params

    return (
        <ListOfPlacesContainer categoryId={categoryId} />
    )
}