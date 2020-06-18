import React, { useState } from "react"

const FormComponent = (props) => {

    const { addCommentCallBack } = props

    const disabledStatus = JSON.parse(localStorage.getItem("user")) ? false : true

    const [comment, setComment] = useState({ name: JSON.parse(localStorage.getItem("user")) ? JSON.parse(localStorage.getItem("user")).name : "", message: "" })

    const handleMessageFieldChange = (e) => {
        setComment({ name: comment.name, message: e.target.value })
    };

    const onSubmit = (e) => {
        e.preventDefault();
        addCommentCallBack(comment)
        setComment({ name: "user", message: "" })
    }

    return (
        <form method="post" onSubmit={onSubmit}>
            <div className="form-group">
                <textarea
                    onChange={handleMessageFieldChange}
                    value={comment.message}
                    className="form-control"
                    placeholder="Your Comment"
                    name="message"
                    rows="5"
                    disabled={disabledStatus}
                    required
                />
            </div>
            <div className="form-group">
                <button disabled={disabledStatus} className="btn btn-primary">
                    Comment ➤
                </button>
            </div>
        </form>
    )

}
export default FormComponent