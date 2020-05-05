import React from 'react'
import ReactDOM from 'react-dom'
import { createStore } from 'redux'
import rootReducer from './store/reducers'
import { AppContainer } from './components/container/app'
import App from '../maket/app'

// const store = createStore(rootReducer, 
//     (window as any).__REDUX_DEVTOOLS_EXTENSION__ && (window as any).__REDUX_DEVTOOLS_EXTENSION__())

ReactDOM.render(<App></App>, document.getElementById('root'))