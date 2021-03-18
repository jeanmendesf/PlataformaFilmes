import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DiretorComponent } from './diretor/diretor.component'

const routes: Routes = [
  { path: 'diretor', component: DiretorComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
