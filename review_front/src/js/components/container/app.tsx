import React from 'react'
import NavbarContainer from './navbar-container'
import SelectedThingComponent from './selected-thing/selected-thing-component'
import { CommentInfo } from '../shared/types'

const App = () => {
    let comments: CommentInfo[] = [
        {
            userName: 'Petr',
            commentText: "it's shitty product"
        },
        {
            userName: 'Vasia',
            commentText: "it's pretty product"
        },
    ]
    comments = []
    return (
        <>
            <NavbarContainer />
            <SelectedThingComponent
                urlImage='https://cater.by/wp-content/uploads/2017/06/Makdonalds-kopiya.jpg'
                rate={4}
                description='Karan G. said"Totally worth it!!! Very authentic and amazing quality. We ordered standard north Indian food daal, kadai paneer and butter naan. Love it Recommended !!"read more'
                comments={comments}
                userName='Some user'
            />
        </>
    )
}

export default App