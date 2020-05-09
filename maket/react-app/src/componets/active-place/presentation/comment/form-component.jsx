import React, { useState } from "react"

const FormComponent = (props) => {

    const { addCommentCallBack } = props

    const [loading, setLoading] = useState(false)

    const [comment, setComment] = useState({ name: "user", message: "" })

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
                    required
                />
            </div>
            <div className="form-group">
                <button disabled={loading} className="btn btn-primary">
                    Comment ➤
                </button>
            </div>
        </form>
    )

}
export default FormComponent