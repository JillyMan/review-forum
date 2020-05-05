import React from "react"
import MainPage from "../common/main-page";
import { Switch, Route } from "react-router-dom";
import { urlGetCategoryByIdPagePattern } from "./route-patterns";
import { PlacesRoute } from "../places-by-category/route/places-route";

const RouteContainer = () => {
    return (
        <>
            <Switch>
                <Route exact path="/" component={MainPage} />
                <Route path={urlGetCategoryByIdPagePattern.pattern} component={PlacesRoute} />
            </Switch>
        </>
    )
}

export default RouteContainer