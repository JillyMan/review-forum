import React, { Component } from 'react'

import SearchLine from '../presentational/SearchLine'
import SearchResultContainer from './SearchResultContainer'

class SearchContentContainer extends Component {
    render() {
        return (
            <div>
                <SearchLine />
                <SearchResultContainer />
            </div>
        )
    }
}

export default SearchContentContainer;