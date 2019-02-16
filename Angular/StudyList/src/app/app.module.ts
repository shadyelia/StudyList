import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { AddAndEditStudentComponent } from './add-and-edit-student/add-and-edit-student.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { RouterModule, Routes } from "@angular/router";
import { CustomMaterialModule } from './material.module'

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MatSelectModule, MatDatepickerModule, MatInputModule } from '@angular/material'

import {
  HttpClientModule,
} from '@angular/common/http';

const appRoutes: Routes = [
  { path: '', component: HomeComponent, data: { title: 'Home' } },
  { path: 'home', component: HomeComponent, data: { title: 'HomeComponent' } },
  { path: 'addAndEditStudent', component: AddAndEditStudentComponent, data: { title: 'Add Student' } }]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentDetailsComponent,
    AddAndEditStudentComponent
  ],
  imports: [
    MatInputModule,
    MatDatepickerModule,
    MatSelectModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(
      appRoutes,
      { useHash: true }
    ),
    CustomMaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
