import { TestBed, inject } from '@angular/core/testing';

import { StudentsServiceService } from './students-service.service';

describe('StudentsServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [StudentsServiceService]
    });
  });

  it('should be created', inject([StudentsServiceService], (service: StudentsServiceService) => {
    expect(service).toBeTruthy();
  }));
});
