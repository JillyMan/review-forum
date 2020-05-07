export const urlGetCategoryByIdPagePattern = {
    pattern: "/category_places/:categoryId",
    getData: (id) => `/category_places/${id}`
}

export const urlGetPlaceByIdPagePattern = {
    pattern: "/active_places/:placeId",
    getData: (id) => `/active_places/${id}`
}