import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TimeConverterComponentComponent } from './time-converter-component.component';

describe('TimeConverterComponentComponent', () => {
  let component: TimeConverterComponentComponent;
  let fixture: ComponentFixture<TimeConverterComponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TimeConverterComponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TimeConverterComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
