import React, { Component } from 'react'
import PropTypes from 'prop-types'

class Comment extends Component {
    constructor(props){
        super(props)
    }

    render() {
        const { userName, commentText, childComments } = this.props
        //todo: check on null childComments
        //todo: think again about comments and child comments.
        
        let ChildCommentsComponent;
        if(childComments){ 
            ChildCommentsComponent = childComments.map((child) => {
                return (
                    <Comment
                        userName={child.user}
                        commentText={child.Text}
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
                <ChildCommentsComponent/>
            </div>
        )
    }
}

Comment.propTypes = {
    userName: PropTypes.string.isRequired,
    commentText: PropTypes.string.isRequired,
}

export default Comment;