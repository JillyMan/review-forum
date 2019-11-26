import React, { Component } from 'react'
import Input from '../presentational/Input'
import Button from '../presentational/Button'
import {INPUT_EMAIL_TYPE, INPUT_PASSWORD_TYPE} from '../constants'

class RegistrationForm extends Component {
    render() {
        return (
            <form className='container border p-3'>
                    <Input
                        id='email_id'
                        text='Email'
                        label='Email'
                        type={INPUT_EMAIL_TYPE}/>
                    <Input
                        id='pass_id'
                        text='Password'
                        label='Password'
                        type={INPUT_PASSWORD_TYPE}/>
                    <Button
                        name='Submit'
                        type='submit'/>
            </form>
        )
    }
}

export default RegistrationForm;