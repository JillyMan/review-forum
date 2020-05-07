import React from "react"
import MainPage from "../common/main-page";
import { Switch, Route } from "react-router-dom";
import { urlGetCategoryByIdPagePattern, urlGetPlaceByIdPagePattern } from "./route-patterns";
import { PlacesRoute } from "../places-by-category/route/places-route";
import ActivePlaceRoute from "../active-place/route/active-place-route";

const RouteContainer = () => {
    return (
        <>
            <Switch>
                <Route exact path="/" component={MainPage} />
                <Route path={urlGetCategoryByIdPagePattern.pattern} component={PlacesRoute} />
                <Route path={urlGetPlaceByIdPagePattern.pattern} component={ActivePlaceRoute} />
            </Switch>
        </>
    )
}

export default RouteContainer