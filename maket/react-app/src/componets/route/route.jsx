import React from "react"
import SearchPlaceContainer from "../search-place/search-place-container";
import { Switch, Route } from "react-router-dom";
import { urlGetCategoryByIdPagePattern, urlGetPlaceByIdPagePattern } from "./route-patterns";
import { PlacesRoute } from "../places-by-category/route/places-route";
import ActivePlaceRoute from "../active-place/route/active-place-route";
import AdminPagePresenter from "../admin-page/presenter/admin-page-presenter";
import SuperUserPresenter from "../super-user-page/presenter/super-user-presenter";

const RouteContainer = () => {
    return (
        <>
            <Switch>
                <Route exact path="/" component={SearchPlaceContainer} />
                <Route path={urlGetCategoryByIdPagePattern.pattern} component={PlacesRoute} />
                <Route path={urlGetPlaceByIdPagePattern.pattern} component={ActivePlaceRoute} />
                <Route path={"/admin"} component={AdminPagePresenter} />
                <Route path={"/super_user"} component={SuperUserPresenter} />
            </Switch>
        </>
    )
}

export default RouteContainer