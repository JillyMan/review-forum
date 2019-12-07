import React, { Component } from 'react'
import ThingInfoComponent from './thing-info-component'
import Comment from '../../presentational/comment'
import WriteCommentPanel from '../../presentational/write-comment-panel'
import { CommentInfo } from '../../shared/types'

// todo: pls create wrapper under comments.
// todo: validate comments.

interface Props {
    userName?: string, // it's shit pls delete
    urlImage: string,
    rate: number,
    description: string,
    comments?: CommentInfo[]
}

interface State {
    comments?: CommentInfo[]
}

class SelectedThingComponent extends Component<Props, State> {
    constructor(props: Props) {
        super(props)

        this.state = {
            comments: this.props.comments
        }
    }

    addComment = (comment: string) => {
        const userName: string = this.props.userName

        const newState = {
            comments: [{
                userName: userName, 
                commentText: comment
            }, ...this.state.comments]
        }
        this.setState(newState)
    }

    render() {
        const {urlImage, rate, description} = this.props;
        const { comments } = this.state
        let CommentsList = comments ? comments.map((comment, index) => {
            return <Comment 
                        key={index} 
                        userName={comment.userName} 
                        commentText={comment.commentText}/>
        }) : []
        
        return (
            <div className='container align-middle'>
                <ThingInfoComponent
                    urlImage={urlImage}
                    rate={rate}
                    description={description}/>
                <div>
                    <WriteCommentPanel
                        label='Comments:'
                        buttonName='Add comment'
                        onButtonPress={this.addComment}/>
                </div>
                <div className='container'>
                    {CommentsList}
                </div>
            </div>
        )
    }
}

export default SelectedThingComponent;