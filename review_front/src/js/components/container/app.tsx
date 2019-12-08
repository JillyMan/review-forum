import React from 'react'
import NavbarContainer from './navbar/navbar-container'
import SelectedThingComponent from './selected-thing/selected-thing-component'
import { CommentInfo } from '../shared/types'
import { Switch, Route, Router } from 'react-router'
import { BrowserRouter } from 'react-router-dom'

import { Provider } from 'react-redux'
import { createStore } from 'redux'

import rootReducer from '../../store/reduces'
import AuthContainer from './auth/auth-container'

const store = createStore(rootReducer, 
    (window as any).__REDUX_DEVTOOLS_EXTENSION__ && (window as any).__REDUX_DEVTOOLS_EXTENSION__())

const App = () => {
    return (
        <Provider store={store}>
            <BrowserRouter>
                <NavbarContainer />
                <div className='container mt-2 mb-3'>
                    <AuthContainer />
                </div>
            </BrowserRouter>
        </Provider>
    )
}

export default App

/**
    <SelectedThingComponent
        id={11111}
        rate={4}
        urlImage='https://cater.by/wp-content/uploads/2017/06/Makdonalds-kopiya.jpg'
        description='Макдо́налдс — американская корпорация, работающая в сфере общественного питания, до 2010 года крупнейшая в мире сеть ресторанов быстрого питания, работающая по системе франчайзинга. На конец 2018 года под торговой маркой McDonald’s работало 37 855 ресторанов, из них 35 085 на правах франчайзинга. Корпорация входит в список крупнейших компаний США Fortune 500 (в 2019 году 149-е место). Штаб-квартира компании расположена в пригороде Чикаго Оук-Бруке.'
        userName='Some user'
    />
 */