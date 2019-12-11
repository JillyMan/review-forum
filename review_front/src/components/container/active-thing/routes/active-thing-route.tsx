import React from 'react'
import { Redirect, Route } from 'react-router'
import { AppState } from 'store/types'
import { connect } from 'react-redux'
import ActiveThingComponent from '../active-thing-component'

interface Props { 
    id: number,
}

export const ActiveThingRoute = ({id}: Props) => {
    if(id != -1) {
        return <Route path='/active-thing' component={ActiveThingComponent}/>
    }
    else {
        return <Redirect to='/'/>
    }
}

const mapStateToProps = (state: AppState): Props => ({
    id: state.activeThing.id
})

export default connect<Props>(mapStateToProps)(ActiveThingRoute)