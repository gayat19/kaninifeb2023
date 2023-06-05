export class UserModel {
   constructor(public userId:number= 0,
    public passwordHash: string="",
    public passwordKey:string="",
    public role:string="",
    public status:string=""){

    }
  }