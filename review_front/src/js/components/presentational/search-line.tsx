import React, { Component } from 'react'
import Button from './common/Button'

//todo: props { onSearchClick(text) }

interface Props {
    onBtnClick: (searchValue: string) => void
}

const SearchLine = ({
    onBtnClick
}: Props) => {

    const onSearchClick = () => {
        onBtnClick('put here searced value')
    }

    return (
        <form className='form-inline'>
            <input 
                className='form-control mr-sm-2' 
                type='search' 
                placeholder="Search"></input>
            <Button
                name='Search'
                type='submit'
                onBtnClick={onSearchClick}
                />
        </form>
    )
}

export default SearchLine;