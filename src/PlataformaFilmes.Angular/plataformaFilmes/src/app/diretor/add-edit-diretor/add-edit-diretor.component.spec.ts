import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditDiretorComponent } from './add-edit-diretor.component';

describe('AddEditDiretorComponent', () => {
  let component: AddEditDiretorComponent;
  let fixture: ComponentFixture<AddEditDiretorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditDiretorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditDiretorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
