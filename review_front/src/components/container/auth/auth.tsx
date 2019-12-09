import React from 'react'
import Input from '../../presentational/common/input'
import Button from '../../presentational/common/button'
import { BorderContainer } from '../../presentational/common/container'
import { INPUT_TEXT_TYPE, INPUT_PASSWORD_TYPE } from 'js/components/constants'
import { AuthProps } from './shared'

export const Auth = ({
    login, 
    pass,
    setLogin,
    setPass,
    onBtnAuthClick
}: AuthProps) => {
    return (
        <BorderContainer>
            <>
                <Input
                    text='Login'
                    label='Login'
                    value={login}
                    onInputChange={x => setLogin(x)}
                    type={INPUT_TEXT_TYPE}/>
                <Input
                    text='Password'
                    label='Password'
                    value={pass}
                    onInputChange={x => setPass(x)}
                    type={INPUT_PASSWORD_TYPE}/>
                <Button
                    name='Sign in'
                    type='submit'
                    onBtnClick={onBtnAuthClick}/>
            </>
        </BorderContainer>
    )
}