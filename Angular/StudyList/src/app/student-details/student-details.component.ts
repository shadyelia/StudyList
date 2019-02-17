import { Component, OnInit } from '@angular/core';
import { StudentsServiceService } from '../students-service.service'
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { DialogService } from '../dialog.service'

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent implements OnInit {

  student: any;

  constructor(private studentsServiceService: StudentsServiceService, private toastr: ToastrService, private _router: Router, private spinner: NgxSpinnerService, private dialogService: DialogService) {

    let id = localStorage.getItem('id');
    this.studentsServiceService.getStudentInfo(id).subscribe(data => {
      this.student = data;
    })
  }

  ngOnInit() {

  }

  deleteStudent() {
    this.dialogService.openConfirmDialog("Are you sure to delete " + this.student.name).afterClosed().subscribe(res => {
      if (res) {
        this.spinner.show();
        this.studentsServiceService.deleteStudent(this.student.id).subscribe(data => {
          this.spinner.hide();
          this.toastr.success('deleted');
          this._router.navigate(['/home']);
        });
      }
    })
  }

  edit() {
    localStorage.setItem('studentid', this.student.id);
    this._router.navigate(['/addAndEditStudent']);
  }

}
