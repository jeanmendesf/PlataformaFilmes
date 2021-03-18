import { SharedService } from './../../servicos/shared.service';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-edit-diretor',
  templateUrl: './add-edit-diretor.component.html',
  styleUrls: ['./add-edit-diretor.component.css']
})
export class AddEditDiretorComponent implements OnInit {

  constructor(private service: SharedService) { }

  @Input() diretor: any;
  Id!: string;
  Nome!: string;

  ngOnInit(): void {
    this.Id = this.diretor.id;
    this.Nome = this.diretor.nome;
  }

  addDiretor() {
    var novoDiretor = { Id: this.Id, Nome: this.Nome };
    this.service.adicionarDiretor(novoDiretor).subscribe(res => {
      alert(res.toString());
    })
  }

  atualizarDiretor() {
    var diretorAtualizado = { Id: this.Id, Nome: this.Nome }
    this.service.atualizarDiretor(diretorAtualizado).subscribe(res => {
      alert('Diretor atualizado!')
    })
  }

}
