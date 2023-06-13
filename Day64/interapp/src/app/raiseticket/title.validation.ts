import { AbstractControl } from "@angular/forms";

export class TitleValidator{

    public static checkTitle(myControl:AbstractControl){
       if(myControl.value){
        var value = myControl.value as string;
        var spacePOsition = value.indexOf(' ');
        if(spacePOsition>-1)
        {
            var firstWord = value.substring(0,spacePOsition);
            var secondWord = value.substring(spacePOsition+1,value.length);
            if(firstWord.length>=3 && secondWord.length>=3)
                return null;
        }
       }
        return {"titleError":"Inavlid entry for title"};


    }
}