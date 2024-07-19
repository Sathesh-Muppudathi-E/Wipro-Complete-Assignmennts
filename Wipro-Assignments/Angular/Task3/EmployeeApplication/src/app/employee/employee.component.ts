import { Component ,Input } from "@angular/core";
@Component({
    selector:'app-employee',
    templateUrl:'./employee.component.html',
    styleUrls:['./employee.component.css']
})
export class EmployeeComponent{
employee ={firstName: 'John',country:'USA'};
//     @Input() employee!:{firstName:string,salary:number};
 }