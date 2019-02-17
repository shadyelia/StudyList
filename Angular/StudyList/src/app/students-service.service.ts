import { Injectable } from '@angular/core';
import { environment } from '../environments/environment'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Student } from './ViewModels/studentVM'

@Injectable({
  providedIn: 'root'
})
export class StudentsServiceService {

  constructor(public http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Accept': 'application/json',
      //'Content-Type': 'application/json'
    })
  };

  getAllStudnets() {
    let url = environment.BACKEND_URL + 'Students/GetAllStudents';
    return this.http.get(url);
  }

  getStudentInfo(id: any) {
    let url = environment.BACKEND_URL + 'Students/GetStudentInfo/' + id;
    return this.http.get(url);
  }

  getAllFaculties() {
    let url = environment.BACKEND_URL + 'Students/GetAllFaulties';
    return this.http.get(url);
  }

  saveStudent(student: Student) {
    let url = environment.BACKEND_URL + 'Students/CreateOrUpdateStudent';
    return this.http.post(url, student);
  }

  deleteStudent(id: number) {
    let url = environment.BACKEND_URL + 'Students/DeleteStudent/' + id;
    return this.http.post(url, '');
  }
}
