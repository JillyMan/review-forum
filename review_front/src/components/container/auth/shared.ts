export interface AuthProps {
    login?: string,
    pass?: string,
    setLogin?: (login: string) => void,
    setPass?: (pass: string) => void,
    onBtnAuthClick?: () => void,
}