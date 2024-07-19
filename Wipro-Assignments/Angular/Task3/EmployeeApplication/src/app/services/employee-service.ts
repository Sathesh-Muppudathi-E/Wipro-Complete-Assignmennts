import { HttpClient } from '@angular/common/http';
import{ Injectable } from '@angular/core'
import { Observable, map} from 'rxjs'
import { EmployeeList } from '../model/employeelist';

@Injectable()
export class EmployeeService
{
  constructor(private _http:HttpClient)
  {

  }
     employees:any[] =[];
    getEmployees():Observable<EmployeeList[]>{ 
   // API call here
      return this._http.get<EmployeeList[]>("http://localhost:3000/employees");
        //  this.employees = [{
        //     code:'1', name:'Tom', gender:'male',salary:4000, dob :'01/01/1998'
        //   },
        //   {
        //       code:'2', name:'John', gender:'male',salary:6000, dob :'10/04/1997'
        //     },
        //     {
        //       code:'3', name:'Mark', gender:'male',salary:5000, dob :'12/05/1996'
        //     },
        //     {
        //       code:'4', name:'Mary', gender:'Female',salary:2000, dob :'05/07/1995'
        //     }];
        //     return this.employees;
    }
    getEmployeeByCode(empId:string):any{
        this.getEmployees();        
          return this.employees.filter(x=>x.code==empId);
    } 
}