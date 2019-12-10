import React from 'react'
import NavbarContainer from './navbar/navbar-container'
import CurrentContentComponent from './content'

import { BrowserRouter } from 'react-router-dom'
import { Provider } from 'react-redux'

// import { Switch, Route, Router } from 'react-router'

interface Props { 
    store: any
}

export const AppContainer = ({ store }: Props) => {
    return (
        <Provider store={store}>
            <BrowserRouter>
                <NavbarContainer />
                <div className='container mt-2 mb-3'>
                    <CurrentContentComponent/>
                </div>
            </BrowserRouter>
        </Provider>
    )
}