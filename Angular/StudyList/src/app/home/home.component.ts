import { Component, OnInit } from '@angular/core';
import { StudentsServiceService } from '../students-service.service'
import { NgxSpinnerService } from 'ngx-spinner';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {

  students: any;

  constructor(private studentsServiceService: StudentsServiceService, private spinner: NgxSpinnerService, private _router: Router
  ) { }

  ngOnInit() {
    this.spinner.show();
    this.studentsServiceService.getAllStudnets().subscribe(data => {
      this.students = data;
      this.spinner.hide();
    });
  }

  openDetails(id: any) {
    localStorage.setItem('id', id);
    this._router.navigate(['/detailsofstudent']);
  }
}
