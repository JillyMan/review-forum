import React from 'react'

import SearchLine from '../../presentational/search-line'
//import SearchResultContainer from './SearchResultContainer'

const SearchContentContainer = () => {

    const onSearchInputChange = (searchString: string) => {
    }

    return (
        <div className='container'>
            <SearchLine 
                onBtnClick={onSearchInputChange}
            />
            {/* <SearchResultContainer /> */}
        </div>
    )

}

export default SearchContentContainer;