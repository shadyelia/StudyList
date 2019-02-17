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

import { MatSelectModule, MatDatepickerModule, MatInputModule, MatDialogModule, MatIconModule, MatButtonModule } from '@angular/material'

import { CommonModule } from '@angular/common';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';

import {
  HttpClientModule,
} from '@angular/common/http';

import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { MatConfirmDialogComponent } from './mat-confirm-dialog/mat-confirm-dialog.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent, data: { title: 'Home' } },
  { path: 'home', component: HomeComponent, data: { title: 'HomeComponent' } },
  { path: 'addAndEditStudent', component: AddAndEditStudentComponent, data: { title: 'Add Student' }, pathMatch: 'full' },
  { path: 'detailsofstudent', component: StudentDetailsComponent, data: { title: 'Details of Student' }, pathMatch: 'full' }

]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    StudentDetailsComponent,
    AddAndEditStudentComponent,
    MatConfirmDialogComponent
  ],
  imports: [
    MatButtonModule,
    MatIconModule,
    MatDialogModule,
    MDBBootstrapModule.forRoot(),
    NgxSpinnerModule,
    MatInputModule,
    MatDatepickerModule,
    MatSelectModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserModule,
    CommonModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added
    RouterModule.forRoot(
      appRoutes,
      { useHash: true }
    ),
    CustomMaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [MatConfirmDialogComponent]
})
export class AppModule { }
