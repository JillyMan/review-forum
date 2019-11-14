import React, { Component } from 'react'
import Input from '../presentational/Input'

class FormContainer extends Component {
    constructor() {
        super()
        this.state = {
            title: ''
        }
        this.handleChange = this.handleChange.bind(this)
    }

    handleChange(event) {
        this.setState({[event.target.id]: event.target.value})       
    }

    render() {
        const { title } = this.state
        return (
            <form id='article-form'>
                <Input
                    id='title'
                    type='text'
                    label='title'
                    text="Some title"
                    value={title}
                    handleChange={this.handleChange}
                />
            </form>
        )
    }
}

export default FormContainer