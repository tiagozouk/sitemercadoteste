import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import axios from 'axios';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  email: string;
  senha: string;
  emailEnviado: boolean;
  mensagem: string

  constructor(
    private router: Router
  ) {  }

  ngOnInit(): void {

  }

  async logar() {
    if(this.email == undefined || this.senha == undefined) {
        this.mensagem = 'Usuário ou senha vazios';
        return;
      }

      let token = btoa(this.email+':'+this.senha);

      var config: any = {
        method: 'post',
        url: 'https://dev.sitemercado.com.br/api/login',
        headers: {
          'Authorization': 'Basic '+token
        }
      };
      // Username 11234567890,
      // Password: 09876543211
      let res:any = await axios(config);

      if(res.data.success) {
        console.log('DEU CERTO', res);
        this.router.navigate(['/admin/painel'])
      }else {
        console.log('response', res)
        this.mensagem = res.data.error;

      }



  }


}
