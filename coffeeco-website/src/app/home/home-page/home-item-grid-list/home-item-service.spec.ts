import { TestBed } from '@angular/core/testing';

import { HomeItemService } from './home-item-service';

describe('HomeItemService', () => {
  let service: HomeItemService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HomeItemService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
