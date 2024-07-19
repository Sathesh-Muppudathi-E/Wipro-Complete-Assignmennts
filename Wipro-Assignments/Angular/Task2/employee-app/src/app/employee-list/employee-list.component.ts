import { Component } from '@angular/core';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent {
  
  employees = [
    { firstName: 'sathish', country: 'UK', salary: 8000},
    { firstName: 'shiva', country: 'India', salary: 3000},
    { firstName: 'pavan', country: 'UK', salary: 90000},
    { firstName: 'lokesh', country: 'Australia', salary: 2000 }
  ];
}
