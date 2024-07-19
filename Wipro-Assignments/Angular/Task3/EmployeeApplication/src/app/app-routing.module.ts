import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { EmployeeListComponent } from './employee-list/employee-list.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { EmployeeComponent } from './employee/employee.component';
import { CreateEmployee } from './create-form/create-form.component';
const routes: Routes = [

   {path:'employee-list',component:EmployeeListComponent},
   {path:'employee',component:EmployeeComponent},
   {path:'create-emp',component:CreateEmployee},
   {path:'',redirectTo:'/employee-list',pathMatch:'full'},
   {path:'**',component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
