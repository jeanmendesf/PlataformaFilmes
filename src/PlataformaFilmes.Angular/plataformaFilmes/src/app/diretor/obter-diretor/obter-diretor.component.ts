import { SharedService } from './../../servicos/shared.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-obter-diretor',
  templateUrl: './obter-diretor.component.html',
  styleUrls: ['./obter-diretor.component.css']
})
export class ObterDiretorComponent implements OnInit {

  constructor(private service: SharedService) { }

  diretorLista: any = [];

  modalTitulo!: string;
  AtivarAddEditDiretor: boolean = false;
  diretor: any;

  ngOnInit(): void {
    this.atualizarListaDiretores();
  }


  fecharClick() {
    this.AtivarAddEditDiretor = false;
    this.atualizarListaDiretores();
  }

  addClick() {
    this.diretor = { Id: 0, Nome: "" }
    this.modalTitulo = "Adicionar diretor";
    this.AtivarAddEditDiretor = true;
  }

  editClick(item: any) {
    this.diretor = item;
    this.modalTitulo = "Editar diretor";
    this.AtivarAddEditDiretor = true;
  }

  deletarClick(item: any) {
    if (confirm('Deseja mesmo deletar?')) {
      this.service.deletarDiretor(item.id).subscribe(data => {
        alert(data.toString())
        this.atualizarListaDiretores()

      })
    }
  }

  atualizarListaDiretores() {
    this.service.obterTodosDiretores().subscribe(data => {
      this.diretorLista = data;
    })
  }

}
