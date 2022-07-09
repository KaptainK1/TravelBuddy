import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CurrencyConverterComponent } from './tools/currency-converter-component/currency-converter-component.component';
import { TimeConverterComponent } from './tools/time-converter-component/time-converter-component.component';
import { TodoListComponent } from './todo-list/todo-list-component/todo-list-component.component';
import { HeaderComponent } from './header-component/header-component.component';
import { FooterComponent } from './footer/footer.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { ToolsComponent } from './tools/tools.component';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    CurrencyConverterComponent,
    TimeConverterComponent,
    TodoListComponent,
    HeaderComponent,
    FooterComponent,
    ToolsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
