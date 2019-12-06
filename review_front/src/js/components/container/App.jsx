import React from 'react'
import Navbar from './navbar-container'
import SearchContentContainer from './searching/search-content-container'
import SelectedThingComponent from './selected-thing/selected-thing-component'

const App = () => {
    return (
        <div>
            <Navbar />
            {/* <SearchContentContainer /> */}
            <SelectedThingComponent/>
        </div>
    )
}

export default App