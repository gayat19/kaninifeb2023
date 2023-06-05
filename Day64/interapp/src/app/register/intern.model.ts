import { UserModel } from "./user.model";

export class InternModel
{
    constructor(public id:number= 0,
        public name:string="",
        public dateOfBirth:Date=new Date(),
        public age:number= 0,
        public gender:string ="",
        public phone:string="",
        public email:string="",
        public passwordClear:string="",
        public user:UserModel=new UserModel()){

        }
  
}

