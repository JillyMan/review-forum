import React, { useState } from "react"
import CommentForm from "../comment/form-component"
import CommentList from "../comment/comment-list"

const CommentContainer = () => {

    const [loading] = useState(true);
    const [comments, setComments] = useState([]);

    const addComment = (comment) => {
        setComments([...comments, comment])
        console.log(comments)
    }

    return (
        <div className="App container bg-light shadow">
            <div className="row">
                <div className="col-4  pt-3 border-right">
                    <h6>Say something true about this place.</h6>
                    <CommentForm addCommentCallBack={addComment} />
                </div>
                <div className="col-8  pt-3 bg-white">
                    <CommentList
                        loading={loading}
                        comments={comments}
                    />
                </div>
            </div>
        </div>
    )
}

export default CommentContainer