import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CalculadoraWebApiService {
  private baseUrl = 'https://localhost:7025';

  constructor(private http: HttpClient) {}

  calcularCDB(valorInicial: number, qtdMeses: number): Observable<any> {
    const url = `${this.baseUrl}/CalcularCDB?valorInicial=${valorInicial}&qtdMeses=${qtdMeses}`;
    return this.http.get(url);
  }
}