import { Component } from '@angular/core';
import { AbstractControl, FormControl, FormGroup, Validators } from '@angular/forms';
import { CalculadoraWebApiService } from './calculadora-web-api.service';

@Component({
  selector: 'app-calculadora',
  templateUrl: './calculadora.component.html',
  styleUrls: ['./calculadora.component.css']
})
export class CalculadoraComponent {
  calculadoraForm: FormGroup;
  prazoMeses: number = 0;
  resultado: string = "";

  constructor(
    private calculadoraService: CalculadoraWebApiService
  ) {
    this.calculadoraForm = new FormGroup({
      valorMonetario: new FormControl('', [Validators.required, this.positiveNonZeroNumberValidator]),
      prazoMeses: new FormControl('', [Validators.required, Validators.min(2)]),
    });
  }

  positiveNonZeroNumberValidator(control: AbstractControl): { [key: string]: boolean } | null {
    if (control.value !== null && (isNaN(control.value) || control.value <= 0)) {
      return { 'positiveNonZeroNumber': true };
    }
    return null;
  }

  calcularInvestimento() {
    const valorInicial = this.calculadoraForm.value.valorMonetario;
    const qtdMeses = this.calculadoraForm.value.prazoMeses;

    this.calculadoraService.calcularCDB(valorInicial, qtdMeses).subscribe(
      (response) => {
        console.log('response')
        console.log(response)
        this.resultado = response
      },
      (error) => {
        console.error('Erro ao chamar a API:', error);
        // Lógica de tratamento de erro, se necessário.
      }
    );
  }
}