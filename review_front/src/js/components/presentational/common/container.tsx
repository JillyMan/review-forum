import React, { ReactChildren, FunctionComponent, ReactNode } from 'react'

//don't repeat fuck.
export const Container = (childs: React.ReactChild) => {
    return (
        <div className='container'>
            {childs}
        </div>
    )
}

interface Props { 
    children: React.ReactChild;
}

export const BorderContainer = ({
    children
}: Props) => 
    <div className='container border'>{children}</div>
