import { NgModule } from '@angular/core';
import { BrowserModule} from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { EmployeeListComponent } from './employee-list/employee-list.component';
import { EmployeeComponent } from './employee/employee.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { TitlePipe } from './title.Pipe';
import { FormsModule } from '@angular/forms';
import { CreateEmployee } from './create-form/create-form.component';
import { RouterModule,Routes } from '@angular/router';
import { HttpClient,HttpHandler,provideHttpClient } from '@angular/common/http';
import { EmployeeService } from './services/employee-service';




@NgModule({
  declarations: [
    AppComponent,
     EmployeeComponent,
    EmployeeListComponent,
    TitlePipe,
    PageNotFoundComponent,
    CreateEmployee
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule
    
  ],
  providers: [EmployeeService,provideHttpClient()
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
