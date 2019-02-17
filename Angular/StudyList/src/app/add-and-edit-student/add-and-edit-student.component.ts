import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';

import { StudentsServiceService } from '../students-service.service'
import { Student } from '../ViewModels/studentVM'


@Component({
  selector: 'app-add-and-edit-student',
  templateUrl: './add-and-edit-student.component.html',
  styleUrls: ['./add-and-edit-student.component.css']
})
export class AddAndEditStudentComponent implements OnInit {

  studentForm: FormGroup;
  faculties: any;
  studentInfo = new Student();
  constructor(private studentsServiceService: StudentsServiceService, private toastr: ToastrService, private _router: Router, private spinner: NgxSpinnerService) {

    this.studentForm = new FormGroup({
      id: new FormControl(0),
      name: new FormControl('', Validators.required),
      phone: new FormControl('', Validators.required),
      facultyId: new FormControl('', Validators.required),
      dateOfBirth: new FormControl({ value: '', disabled: true }, Validators.required),
      address: new FormControl(''),
      imagePath: new FormControl('')
    });
  }

  ngOnInit() {
    this.studentsServiceService.getAllFaculties().subscribe(data => {
      this.faculties = data;
    })
  }

  save() {
    if (this.studentForm.valid) {
      this.spinner.show();
      this.BindDataForCreate();
      this.studentsServiceService.saveStudent(this.studentInfo).subscribe(data => {
        this.spinner.hide();
        this.toastr.success('Saved');
        this._router.navigate(['/home']);
      })
    }
  }

  BindDataForCreate() {
    this.studentInfo.Name = this.studentForm.get('name').value;
    this.studentInfo.Phone = this.studentForm.get('phone').value;
    this.studentInfo.DateOfBirth = this.studentForm.get('dateOfBirth').value;
    this.studentInfo.FacultyId = this.studentForm.get('facultyId').value;
    this.studentInfo.Address = this.studentForm.get('address').value;
    this.studentInfo.ImagePath = this.studentForm.get('imagePath').value;
  }

}
