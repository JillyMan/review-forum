import Redux from 'redux'
import React, { Component } from 'react'
import { connect } from 'react-redux'
import { Comment } from '../../presentational/comment'
import { ThingInfoComponent } from './thing-info-component'
import { AppState, CommentInfo } from '../../../store/types'
import { addComment, ActiveThingAction } from '../../../store/active-thing/actions'
import WriteCommentPanel from '../../presentational/write-comment-panel'

interface StoreProps {
    id: number,
    rate: number,
    isAuth: boolean,
    userName: string,
    urlImage: string,
    description: string,
    comments: CommentInfo[],
}

interface DispatchProps {
    addComment: (comment: CommentInfo) => void,
}

interface State {
    comments: CommentInfo[],
}

type Props = StoreProps & DispatchProps

class ActiveThingComponent extends Component<Props, State> {
    constructor(props: Props) {
        super(props)
    }

    addComment = (text: string) => {
        const userName: string = this.props.userName
        const commentInfo: CommentInfo = {userName, text}
        this.props.addComment(commentInfo)
    }

    render() {
        const { urlImage, rate, description, isAuth, comments } = this.props;
        let CommentsList = comments ? comments.map((comment, index) => {
            return <Comment 
                        key={index} 
                        userName={comment.userName} 
                        commentText={comment.text}/>
        }) : []

        return (
            <div className='container align-middle'>
                <ThingInfoComponent
                    urlImage={urlImage}
                    rate={rate}
                    description={description}/>
                <div>
                    { isAuth ?
                        <WriteCommentPanel
                            label='Comments:'
                            buttonName='Add comment'
                            onButtonPress={this.addComment}/> :
                        <p>For add comment need sign in!</p>
                    }
                </div>
                <div className='container'>
                    {CommentsList}
                </div>
            </div>
        )
    }
}

const mapStateToProps = (state: AppState): StoreProps => ({
    id: state.activeThing.id,
    userName: state.userInfo.userName,
    isAuth: state.auth.isAuth,
    urlImage: state.activeThing.urlImage,
    rate: state.activeThing.rate,
    description: state.activeThing.description,
    comments: state.activeThing.comments.map((item: any): CommentInfo => {
        return {
            userName: item.userName,
            text: item.text
        }
    })
})

const mapDispatchToProps = (dispatch: Redux.Dispatch<ActiveThingAction>): DispatchProps => ({
    addComment: (comment: CommentInfo) => dispatch(addComment(comment))
})

export default connect<StoreProps, DispatchProps>(
    mapStateToProps, 
    mapDispatchToProps
)(ActiveThingComponent)