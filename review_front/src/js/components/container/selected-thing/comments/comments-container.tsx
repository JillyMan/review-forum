import React from 'react'
import CommentProps from '../../../shared/types'
import Comment from '../../../presentational/comment'

interface Props {
    commentsProps?: CommentProps[]
}

const CommentsContainer = ({commentsProps}: Props) => {
    if( commentsProps) {
        let CommentsView = commentsProps ? commentsProps.map((info) => {
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
            {CommentsView}
        )
    }
    else {
        return (
            <h1>There is no comments</h1>
        )
    }
}

export default CommentsContainer;