import React from "react"
import CommentContainer from "../comment/comment-container"

const commentRowStyle = {
    marginTop: 50
}


const CommentsRow = () => {

    return (
        <div className="commentsRow" style={commentRowStyle}>
            <div className="someComment">
                <CommentContainer />
            </div>
        </div>
    )
}

export default CommentsRow