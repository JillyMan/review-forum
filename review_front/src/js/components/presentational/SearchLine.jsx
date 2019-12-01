import React, { Component } from 'react'
import Button from './common/Button'

//todo: props { onSearchClick(text) }
class SearchLine extends  Component {
    constructor(props) {
        super(props)
    }

    //todo: onSearchPress(searchText)
    onBtnClick(event) {
    }

    render() {
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
}

export default SearchLine;