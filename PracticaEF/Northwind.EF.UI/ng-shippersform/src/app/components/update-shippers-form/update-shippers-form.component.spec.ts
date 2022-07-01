import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateShippersFormComponent } from './update-shippers-form.component';

describe('UpdateShippersFormComponent', () => {
  let component: UpdateShippersFormComponent;
  let fixture: ComponentFixture<UpdateShippersFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateShippersFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateShippersFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
