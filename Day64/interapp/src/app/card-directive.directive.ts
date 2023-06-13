import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appCardDirective]'
})
export class CardDirectiveDirective {
@HostListener('focus') onFocus(){
  console.log("Focused");
}
@HostListener('blur') onBlur()
 {
  var value = this.myElement.nativeElement.value as string;
  if(value)
  {
    if(value.length == 16)
    {
        var p1 = value.substring(0,4);
        var p2 = value.substring(4,8);
        var p3 = value.substring(8,12);
        var p4 = value.substring(12,16);
        var result = p1+"-"+p2+"-"+p3+"-"+p4;
        this.myElement.nativeElement.value = result;
    }
  }
 }

  @Input() appCardDirective:string;
  constructor(private myElement:ElementRef) { 
   // this.appCardDirective="blue";
    //this.myElement.nativeElement.value = "Hello";
    console.log('check'+this.appCardDirective)
    this.myElement.nativeElement.style.color=this.appCardDirective;
  }

}
