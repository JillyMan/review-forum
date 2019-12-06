import React, { Component } from 'react'
import CommentsContainer from './comments/comments-container'
import ThingInfoComponent from './thing-info-component'

class SelectedThingComponent extends Component {
    render() {
        return (
            <div>
                <ThingInfoComponent
                    urlImage='https://cdn.pixabay.com/photo/2019/11/06/14/33/moon-4606246_960_720.jpg'
                    rate={3}
                    description='lorem ipsum blablablablablablabla'/>
                <CommentsContainer />
            </div>
        )
    }
}

export default SelectedThingComponent;