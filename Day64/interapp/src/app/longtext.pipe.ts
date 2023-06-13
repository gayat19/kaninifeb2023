import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'longtext'
})
export class LongtextPipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    var data = value as string;
    var len =5;
    if(data){
      if(data.length>5)
      {
        if(args)
        {
          if(args[0])
          {
              len = args[0] as number;
          }
        }
      }
        return data.substring(0,len)+"....";
    }
    return null;
  }

}
