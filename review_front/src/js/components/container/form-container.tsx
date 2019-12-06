import React, { Component } from 'react'
import Input from '../presentational/common/input'


const FormContainer = (title: string) => {

    const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        // this.setState({[event.target.id]: event.target.value})       
    }

    return (
        <form id='article-form'>
            <Input
                id='title'
                type='text'
                label='title'
                text="Some title"
                value={title}
                onInputChange={handleChange}
            />
            <Input
                id='title'
                type='text2'
                label='title2'
                text="Some title2"
                value={title}
                onInputChange={handleChange}
            />
        </form>
    )
}

export default FormContainer