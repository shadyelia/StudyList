import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-and-edit-student',
  templateUrl: './add-and-edit-student.component.html',
  styleUrls: ['./add-and-edit-student.component.css']
})
export class AddAndEditStudentComponent implements OnInit {

  studentForm: FormGroup;
  faculties: any;

  constructor() {
    this.faculties = [
      { id: 'steak-0', viewValue: 'Steak' },
      { id: 'pizza-1', viewValue: 'Pizza' },
      { id: 'tacos-2', viewValue: 'Tacos' }
    ];
    this.studentForm = new FormGroup({
      name: new FormControl('', Validators.required),
      phone: new FormControl('', Validators.required),
      faculty: new FormControl('', Validators.required),
      dateOfBirth: new FormControl('', Validators.required),
      address: new FormControl(''),
      imagePath: new FormControl('')
    });
  }

  ngOnInit() {
  }

}
