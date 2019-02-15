import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { AddAndEditStudentComponent } from './add-and-edit-student/add-and-edit-student.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentDetailsComponent,
    AddAndEditStudentComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
