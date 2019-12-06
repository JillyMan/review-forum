import React from 'react'

interface Props {
    userName?: string,
    commentText?: string,
    // childComments?: Props[]
}

const CommentThing = ({
    userName,
    commentText,
    // childComments
}: Props) => {

    let ChildCommentsComponent;
    // if(childComments){
    //     ChildCommentsComponent = childComments.map((child, index) => {
    //         return (
    //             <CommentThing
    //                 key={index}
    //                 userName={child.userName}
    //                 commentText={child.commentText}
    //                 childComments={child.childComments}
    //             />
    //         )
    //     })
    // }

    return (
        <div className='group'>
            <h2>{userName}</h2>
            <p>{commentText}</p>
        </div>
    )
}

export default CommentThing;