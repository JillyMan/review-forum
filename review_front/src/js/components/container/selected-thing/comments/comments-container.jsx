import React, { Component } from 'react'
import Comment from '../../../presentational/comment'

export default class CommentsContainer extends Component {
    render() {
        const { comments } = this.props
        if(comments) {
            let CommentsView = comments ? comments.map((info) => {
                return (
                    <Comment
                        userName={info.userName}
                        commentText={info.commentText}
                        childComments={info.childComments}
                    />
                )
            }) : <Comment
                    userName='default name'
                    commentText='default text'
                />
    
            return (
                <CommentsView />
            )
        }
        else {
            return (
                <h1>There is no comments</h1>
            )
        }
    }
}