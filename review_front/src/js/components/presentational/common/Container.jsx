import React from 'react'

//don't repeat fuck.
export const Container = function(props) {
    const Content = props.children
    return (
        <div className='container'>
            <Content/>
        </div>
    )
}

export const BorderContainer = function(props) {
    const Content = props.children
    return (
        <div className='container border'>
            <Content/>
        </div>
    )
}