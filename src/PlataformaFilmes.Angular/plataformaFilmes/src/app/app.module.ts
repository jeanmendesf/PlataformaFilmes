import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DiretorComponent } from './diretor/diretor.component';
import { ObterDiretorComponent } from './diretor/obter-diretor/obter-diretor.component';
import { DeletarDiretorComponent } from './diretor/deletar-diretor/deletar-diretor.component';

import { SharedService } from './servicos/shared.service'

import { HttpClientModule } from '@angular/common/http'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AddEditDiretorComponent } from './diretor/add-edit-diretor/add-edit-diretor.component'

@NgModule({
  declarations: [
    AppComponent,
    DiretorComponent,
    ObterDiretorComponent,
    DeletarDiretorComponent,
    AddEditDiretorComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
