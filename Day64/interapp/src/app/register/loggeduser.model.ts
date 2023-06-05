export class LoggedInUserModel{
    constructor(public userId:number=0,
                public token:string="",
                public role:string="")
                {

    }
}