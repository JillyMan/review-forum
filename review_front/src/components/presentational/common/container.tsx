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
    colSm?: number
    children: React.ReactChild;
}

export const BorderContainer = ({
    colSm,
    children
}: Props) =>  {
    
    const className = `container border col-${colSm ? colSm : '' }`

    return (
        <div className={className}>
            {children}
        </div>
    )
}
