import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddAndEditStudentComponent } from './add-and-edit-student.component';

describe('AddAndEditStudentComponent', () => {
  let component: AddAndEditStudentComponent;
  let fixture: ComponentFixture<AddAndEditStudentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddAndEditStudentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddAndEditStudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
