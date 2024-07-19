import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { EmployeeComponent } from './employee/employee.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { TitlePipe } from './title.pipe';
import { AppRoutes } from './app.routes';

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
    AppRoutes
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
