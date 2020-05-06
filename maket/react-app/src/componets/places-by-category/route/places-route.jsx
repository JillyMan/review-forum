import React from 'react'
import ListOfPlacesByCategoryContainer from '../containers/list-of-places-by-category-container'

export const PlacesRoute = (props) => {
    const { categoryId } = props.match.params

    return (
        <ListOfPlacesByCategoryContainer categoryId={categoryId} />
    )
}