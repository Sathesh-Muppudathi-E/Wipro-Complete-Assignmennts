import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { EmployeeComponent } from './employee/employee.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { TitlePipe } from './title.pipe';

const routes: Routes = [
  { path: 'employee-list', component: EmployeeListComponent },
  { path: 'employee', component: EmployeeComponent },
  { path: '', redirectTo: '/employee-list', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    EmployeeListComponent,
    EmployeeComponent,
    PageNotFoundComponent,
    TitlePipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
