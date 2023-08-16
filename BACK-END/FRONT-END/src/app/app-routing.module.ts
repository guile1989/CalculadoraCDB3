import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalculadoraComponent } from './calculadora/calculadora.component';

const routes: Routes = [
  { path: '', redirectTo: '/calculadora', pathMatch: 'full' }, // Redireciona para a calculadora como padrão
  { path: 'calculadora', component: CalculadoraComponent },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
