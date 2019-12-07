import React, { useRef, createRef, Component } from 'react'
import Button from './common/button';

interface Props { 
    label: string,
    buttonName: string,
    onButtonPress: (value: string) => void
}

interface State {
    isEmpty: boolean
}

class WriteCommentPanel extends Component<Props, State> {
    textAreaRef = createRef<HTMLTextAreaElement>()
    constructor(props: Props) {
        super(props)

        this.state = {
            isEmpty: false
        }
    }

    onBtnClick = () => {
        const commentText = this.textAreaRef.current.value;
        let isEmptyArea = commentText.trim().length == 0
        this.setState({isEmpty: isEmptyArea})

        if(!isEmptyArea) {
            this.props.onButtonPress(commentText)
        }
    }

    render() {
        const { label, buttonName } = this.props

        return (
            <div className='container shadow-lg p-3 mb-5 bg-white rounded'>
                <div className="form-group">
                    <div className="alert alert-danger" role="alert" hidden={!this.state.isEmpty}>
                        Pls put text here!
                    </div>
                    <label htmlFor="comment">{label}</label>
                    <textarea
                        rows={5}
                        id="comment"
                        ref={this.textAreaRef}
                        className="form-control">
                    </textarea>
                </div>
                <Button
                    type='submit'
                    name={buttonName}
                    onBtnClick={this.onBtnClick} />
            </div>
        )
    }
}

export default WriteCommentPanel
