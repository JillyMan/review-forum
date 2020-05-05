import React from 'react'

const getByCategory = (categoryName) => {
    return []
}

const ListOfPlacesContainer = (props) => {
    const { categoryId } = props

    const placeces = getByCategory(categoryId)

    return (
        <>
            {categoryId}
            {placeces}  
        </>
    )
}

export default ListOfPlacesContainer;