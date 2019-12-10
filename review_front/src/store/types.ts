import { AuthState } from "./auth/reducers";
import { UserState } from "./user-info/reducers";
import { ThingsConfig } from "./things/actions";

export interface CommentInfo {
    userName: string,
    text: string,
}

export interface ThingConfig { 
    id: number,
    urlImage: string,
    rate: number,
    description: string,
    comments: CommentInfo[]
}

export interface AppState { 
    auth?: AuthState,
    userInfo?: UserState,
    activeThing?: ThingConfig,
    things?: ThingsConfig,
}
