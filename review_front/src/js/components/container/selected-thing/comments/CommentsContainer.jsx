import React, { Component } from 'react'
import Comment from '../presentational/Comment'

class CommentsContainer extends Component {
    render() {
        const { comments } = this.props
        const CommentsView = comments.forEach((commentInfo) => {
            return (
                <Comment
                    userName={commentInfo.userName}
                    commemtText={commentInfo.commentText}
                    childComments={commentInfo.childComments}
                />
            )
        })

        return (
            <CommentsView />
        )
    }
}

export default CommentsContainer;