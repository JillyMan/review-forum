import React, { Component } from 'react'
import CommentType from '../shared/types'

const Comment = ({
    userName,
    commentText,
    childComments
}: CommentType) => {

    let ChildCommentsComponent;
    if(childComments){ 
        ChildCommentsComponent = childComments.map((child) => {
            return (
                <Comment
                    userName={child.userName}
                    commentText={child.commentText}
                    childComments={child.childComments}
                />
            )
        })
    }

    return (
        <div className='container'>
            <div className='group'>
                <h2>{userName}</h2>
                <p>{commentText}</p>
            </div>
            {ChildCommentsComponent}
        </div>
    )
}

export default Comment;