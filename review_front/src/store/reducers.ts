import { combineReducers } from 'redux'
import { authReducer } from './auth/reducers'
import { userReducer } from './user-info/reducers'
import { thingsReducer } from './things/reducers'
import { activeThingReducer } from './active-thing/reducers'

export default combineReducers({
    auth: authReducer,
    userInfo: userReducer,
    activeThing: activeThingReducer,
    things: thingsReducer,
})