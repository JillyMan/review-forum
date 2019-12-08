import React, { Component } from 'react'
import ThingInfoComponent from './thing-info-component'
import Comment from '../../presentational/comment'
import WriteCommentPanel from '../../presentational/write-comment-panel'
import { CommentInfo } from '../../shared/types'

// todo: pls create wrapper under comments.
// todo: validate comments.

interface ISelectedThing { 
    id: number,
    userName?: string,
    urlImage: string,
    rate: number,
    description: string,
}

interface IState { 
    comments?: CommentInfo[]
}

const STORAGE_KEY: string = 'SELECTED_THING'

class SelectedThingComponent extends Component<ISelectedThing, IState> {
    constructor(props: ISelectedThing) {
        super(props)
        this.state = {
            comments: []
        }
    }

    componentDidMount() { 
        const saved = JSON.parse(localStorage.getItem(`${STORAGE_KEY}/${this.props.id}` || `{id: ${STORAGE_KEY}/${this.props.id}, comments: []}`)) as IState
        this.setState(saved);
    }

    saveInLocalStorage = (state: IState) => {
        localStorage.setItem(`${STORAGE_KEY}/${this.props.id}`, JSON.stringify(state))
    }

    addComment = (commentText: string) => {
        const userName: string = this.props.userName
        const commentInfo: CommentInfo = {userName, commentText}
        const newState = {
            comments: [commentInfo, ...this.state.comments]
        }
        this.saveInLocalStorage(newState)
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