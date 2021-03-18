import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  readonly APIUrl = "https://localhost:44310/api";

  constructor(private http: HttpClient) { }



  obterTodosDiretores(): Observable<any[]> {
    return this.http.get<any[]>(this.APIUrl + '/diretor')
  }

  // obterDiretor(): Observable<any[]> {
  //   return this.http.get<any>(this.APIUrl + '/diretor');
  // }

  adicionarDiretor(val: any) {
    return this.http.post(this.APIUrl + '/diretor/adicionar', val);
  }

  atualizarDiretor(val: any) {
    return this.http.put(this.APIUrl + '/diretor/atualizar/' + val.id, val);
  }

  deletarDiretor(val: any) {
    return this.http.delete(this.APIUrl + '/diretor/deletar/' + val)
  }

  mensagem(val: any) {

  }

}
