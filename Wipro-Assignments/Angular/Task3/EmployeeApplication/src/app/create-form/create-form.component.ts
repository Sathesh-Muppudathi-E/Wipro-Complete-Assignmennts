import { Component} from "@angular/core";
import { NgForm } from "@angular/forms";
import { Employee } from "../model/employee";


@Component({
    selector:'create-emp',
    templateUrl:'./create-form.component.html',
    styleUrl:'./create-form.component.css'
})
export class CreateEmployee
{
  emp:Employee={
     name:"",
     gender:"",
     emailid:"",
     password:""
  };
    emailid:string="";
    password:string="";
    gender:string="";
    country:string="";
  getData(formdata:NgForm){

  console.log(formdata.value);
 
  console.log(this.emp);
  console.log(this.emp.emailid);
 
 }
  }
