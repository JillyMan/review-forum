import React from 'react'
import Navbar from './NavbarContainer'
import SearchContentContainer from './searching/SearchContentContainer'
import SelectedThingComponent from './selected-thing/SelectedThingComponent'

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