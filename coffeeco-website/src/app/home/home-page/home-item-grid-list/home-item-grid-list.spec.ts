import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeItemGridList } from './home-item-grid-list';

describe('HomeItemGridList', () => {
  let component: HomeItemGridList;
  let fixture: ComponentFixture<HomeItemGridList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HomeItemGridList]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeItemGridList);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
