import React, { Component } from 'react'
import CommentsContainer from './comments/CommentsContainer'
import ThingInfoComponent from './ThingInfoComponent'

class SelectedThingComponent extends Component {
    render() {
        return (
            <div>
                <ThingInfoComponent/>
                <CommentsContainer/>
            </div>
        )
    }
}

export default SelectedThingComponent;