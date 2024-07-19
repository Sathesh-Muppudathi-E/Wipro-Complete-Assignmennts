import { Routes, RouterModule } from '@angular/router';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { EmployeeComponent } from './employee/employee.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  { path: 'employee-list', component: EmployeeListComponent },
  { path: 'employee', component: EmployeeComponent },
  { path: '', redirectTo: '/employee-list', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

export const AppRoutes = RouterModule.forRoot(routes);
