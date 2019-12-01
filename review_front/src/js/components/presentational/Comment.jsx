import React, { Component } from 'react'
import PropTypes from 'prop-types'

class Comment extends Component {
    constructor(props){
        super(props)
    }

    render() {
        const { userName, commentText, childComments } = this.props.comments
        //todo: check on null childComments
        //todo: think again about comments and child comments.
        const ChildCommentsComponent = childComments.map((childComments) => {
            return (
                <Comment
                    userName={comment.user}
                    commentText={comment.Text}
                    childComments={comment.childComments}
                />
            )
        })

        return (
            <div className='container'>
                <div className='group'>
                    <h2>{userName}</h2>
                    <p>{commentText}</p>
                </div>
                <Comment/>
            </div>
        )
    }
}

PropType.propTypes = {
    userName: PropTypes.string.isRequired,
    commentText: PropTypes.string.isRequired,
}

export default Comment;