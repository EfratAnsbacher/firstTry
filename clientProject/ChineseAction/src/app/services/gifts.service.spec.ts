import { TestBed } from '@angular/core/testing';

import { giftsService } from './gifts.service';

describe('giftsService', () => {
  let service: giftsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(giftsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
