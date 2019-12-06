import React, { ReactNode } from 'react'
import CommentThing from '../../../presentational/comment-thing'

const CommentsWrapper = (children: any) => {
    // if( comments) {
    //     let CommentsView = comments ? comments.map((info) => {
    //         return (
    //             <CommentThing
    //                 userName={info.userName}
    //                 commentText={info.commentText}
    //                 childComments={info.childComments}
    //             />
    //         )
    //     }) : <CommentThing
    //             userName='default name'
    //             commentText='default text'
    //         />
    //     return (
    //         {CommentsView}
    //     )
    // }
    // else {
    //     return (
    //         <h1>There is no comments</h1>
    //     )
    // }

    return(
        <ul>
            {children}
        </ul>
    );
}

export default CommentsWrapper;