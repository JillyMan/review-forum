import React from 'react'

interface Props {
    text: string,
    isHidden: boolean
}

export const WarningAllert = ({ text, isHidden }: Props) => {
    return (
        <div className="alert alert-danger" role="alert" hidden={isHidden}>
            {text}
        </div>
    )
}