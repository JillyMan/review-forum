import React, { Component } from 'react'
import CommentsWrapper from './comments/comments-wrapper'
import ThingInfoComponent from './thing-info-component'
import CommentThing from '../../presentational/comment-thing'

//pls create wrapper under comments.
class SelectedThingComponent extends Component {
    render() {
        return (
            <div>
                <ThingInfoComponent
                    urlImage='https://cdn.pixabay.com/photo/2019/11/06/14/33/moon-4606246_960_720.jpg'
                    rate={3}
                    description='lorem ipsum blablablablablablabla'/>
                <>
                    <CommentThing key={1} userName='Petr' commentText="it's pretty product" />
                    <CommentThing key={3} userName='Vasia' commentText="it's shitty product" />
                </>
            </div>
        )
    }
}

export default SelectedThingComponent;