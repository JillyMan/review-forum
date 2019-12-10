import React, { useState, useEffect } from 'react'
import Input from '../../presentational/common/input'
import Button from '../../presentational/common/button'
import { BorderContainer } from '../../presentational/common/container'
import { INPUT_TEXT_TYPE, INPUT_PASSWORD_TYPE } from '../../constants'
import { Allert } from '../../presentational/allerts/allert'

interface Props {
    onBtnAuthClick: (login: string, pass: string) => boolean,
}

export const Auth = ({
    onBtnAuthClick
}: Props) => {

    const [login, setLogin] = useState('')
    const [pass, setPass] = useState('')
    const [allertHidden, setAllertHidden] = useState(true)

    return (
        <BorderContainer
            colSm={5}>
            <>
            <div className='mb-3 mt-1'>
                <Allert
                    type='warning'
                    text={'Incorrect login/password'}
                    isHidden={allertHidden}
                />
                <Input
                    text='Login'
                    label='Login'
                    value={login}
                    onInputChange={val => setLogin(val)}
                    type={INPUT_TEXT_TYPE}/>
                <Input
                    text='Password'
                    label='Password'
                    value={pass}
                    onInputChange={val => setPass(val)}
                    type={INPUT_PASSWORD_TYPE}/>
                    <Button
                        name='Sign in'
                        type='submit'
                        onBtnClick={() => setAllertHidden(onBtnAuthClick(login, pass))}/>
                </div>
            </>
        </BorderContainer>
    )
}