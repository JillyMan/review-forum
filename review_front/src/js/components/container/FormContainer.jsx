import React, {Componets } from 'react'
import Input from '../presentational/Input'

class FormContainer extends Componet {
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
                text="Some title"
                label='title'
                type='text'
                id='title'
                value={title}
                handleChange={this.handleChange}
                />
            </form>
        )
    }
}

export default FormContainer