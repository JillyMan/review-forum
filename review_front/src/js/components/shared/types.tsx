export default interface CommentProps {
    userName?: string,
    commentText?: string,
    childComments?: CommentProps[]
}
