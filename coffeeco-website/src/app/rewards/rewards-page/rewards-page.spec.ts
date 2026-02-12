import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RewardsPage } from './rewards-page';

describe('RewardsPage', () => {
  let component: RewardsPage;
  let fixture: ComponentFixture<RewardsPage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RewardsPage]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RewardsPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
