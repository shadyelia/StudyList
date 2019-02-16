import { Component, OnInit } from '@angular/core';
import { StudentsServiceService } from '../students-service.service'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit {

  constructor(private studentsServiceService: StudentsServiceService) { }

  ngOnInit() {
    console.log('s');
    this.studentsServiceService.getAllStudnets().subscribe(data => {
      console.log(data);
    });
  }

}
