import { Component } from "@angular/core";

@Component({
    selector:'app-employee-list',
    templateUrl:'./employee-list.component.html',
    styleUrls:['./employee-list.component.css']

})
export class EmployeeListComponent{
    employees=[{firstName:'john', lastName:'Doe', gender:'male',salary:4000,country:'USA'},
               {firstName:'jane',lastName:'smith',gender:'female',salary:8000,country:'UK'},
               {firstName:'divya',lastName:'thaviti',gender:'female',salary:9000,country:'canada'},
               {firstName:'reddy',lastName:'brown',gender:'male',salary:2000,country:'Australia'}
    ];

}
