import { Component, OnInit, ViewChild } from '@angular/core';
import { CurrencyConverterService } from './currency-converter-service';
import { faDollarSign } from '@fortawesome/free-solid-svg-icons';
import { faSterlingSign } from '@fortawesome/free-solid-svg-icons';
import { Observable } from "rxjs";


@Component({
  selector: 'app-currency-converter-component',
  templateUrl: './currency-converter-component.component.html',
  styleUrls: ['./currency-converter-component.component.css']
})
export class CurrencyConverterComponent implements OnInit {
  faDollarSign = faDollarSign;
  faSterlingSign = faSterlingSign;
  outputAmount: number = 0.00;
  inputAmount: number = 2.00;

  constructor(private currencyConverterService: CurrencyConverterService) { }


  ngOnInit(): void {
    this.currencyConverterService.getCurrencyConversion(this.inputAmount);
  }

  convertCurrency() {
    this.currencyConverterService.getCurrencyConversion(this.inputAmount).subscribe((res) =>{
        this.outputAmount = res.result;
    })
    //this.outputAmount = this.currencyConverterService.getCurrencyConversion(this.inputAmount);
  }
}
