import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObterDiretorComponent } from './obter-diretor.component';

describe('ObterDiretorComponent', () => {
  let component: ObterDiretorComponent;
  let fixture: ComponentFixture<ObterDiretorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ObterDiretorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ObterDiretorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
