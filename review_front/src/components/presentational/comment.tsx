import React from 'react'
//todo: in future will add posibility to add comment to comment 

interface Props {
    userName?: string,
    commentText?: string,
    // childComments?: Props[]
}

export const Comment = ({
    userName,
    commentText,
}: Props) => {

    return (
        <li className='list-group-item'>
            <h4>{userName}</h4>
            <p>{commentText}</p>
        </li>
    )
}