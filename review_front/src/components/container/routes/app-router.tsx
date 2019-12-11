import React from 'react'
import { Switch, Route } from 'react-router-dom'
import { AuthRouter } from '../auth/routes/auth-routes'
import { ActiveThingRoute } from '../active-thing/routes/active-thing-route'
import ThingsContainer from '../things-content/things-container'
import LogoutComponent from '../logout/logout-component'

export const AppRouter = () => {
    return(
        <Switch>
            <Route path='/' exact component={ThingsContainer}/>
            <Route path='/signin' component={AuthRouter}/>
            <Route path='/things' component={ThingsContainer}/>
            <Route path='/active-thing' component={ActiveThingRoute} />
            <Route path='/logout' component={LogoutComponent}/>
        </Switch>
    )
}