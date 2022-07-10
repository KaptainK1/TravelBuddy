import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders, HttpParams, HttpRequest } from "@angular/common/http"
import { map } from 'rxjs/operators';
import { Observable } from "rxjs";
import { environment } from '../../../environments/environment.prod'

@Injectable({
    providedIn: 'root',
})
export class CurrencyConverterService {

    constructor(private http: HttpClient) {}
    getCurrencyConversion(amount: number) : Observable<any> {
        let value: number;
        const headers = new HttpHeaders(
            {'apikey': environment.currencyAPIKey} );
        const queryParams = new HttpParams().append("to","GBP").append("from", "USD").append("amount", amount);
        // this.http.get<{currency: number}>(
           return this.http.get<{result: number}>(
            "https://api.apilayer.com/exchangerates_data/convert",
            {
                headers: headers,
                params: queryParams,
                observe: 'body',
                responseType: 'json'
            },
        );
    }

    //TODO: use below functions to get proper currency codes
    private getInputCurrency(){

    }
    private getOutputCurrency(){

    }

}