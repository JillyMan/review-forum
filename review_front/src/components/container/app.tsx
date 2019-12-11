import React from 'react'
import NavbarContainer from './navbar/navbar-container'
import { BrowserRouter, Router } from 'react-router-dom'
import { Provider } from 'react-redux'
import { AppRouter } from './routes/app-router'
import history from '../../history/history'

interface Props { 
    store: any
}

export const AppContainer = ({ store }: Props) => {
    return (
        <Provider store={store}>
            <Router history={history}>
                <NavbarContainer />
                <div className='container mt-2 mb-3'>
                    <AppRouter/>
                </div>
            </Router>
        </Provider>
    )
}