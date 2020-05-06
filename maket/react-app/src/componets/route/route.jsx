import React from "react"
import SearchPlaceContainer from "../search-place/search-place-container";
import { Switch, Route } from "react-router-dom";
import { urlGetCategoryByIdPagePattern } from "./route-patterns";
import { PlacesRoute } from "../places-by-category/route/places-route";

const RouteContainer = () => {
    return (
        <>
            <Switch>
                <Route exact path="/" component={SearchPlaceContainer} />
                <Route path={urlGetCategoryByIdPagePattern.pattern} component={PlacesRoute} />
            </Switch>
        </>
    )
}

export default RouteContainer