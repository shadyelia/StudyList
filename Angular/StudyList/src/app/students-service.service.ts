import { Injectable } from '@angular/core';
import { environment } from '../environments/environment'
import { HttpClient, HttpHeaders } from '@angular/common/http';

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

}
