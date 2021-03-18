import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletarDiretorComponent } from './deletar-diretor.component';

describe('DeletarDiretorComponent', () => {
  let component: DeletarDiretorComponent;
  let fixture: ComponentFixture<DeletarDiretorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeletarDiretorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DeletarDiretorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
