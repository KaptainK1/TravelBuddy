import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CurrencyConverterComponent } from './tools/currency-converter-component/currency-converter-component.component';
import { TimeConverterComponent } from './tools/time-converter-component/time-converter-component.component';
import { TodoListComponent } from './todo-list/todo-list/todo-list.component';
import { HeaderComponent } from './header-component/header-component.component';
import { FooterComponent } from './footer/footer.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { ToolsComponent } from './tools/tools.component';
import { HttpClientModule } from '@angular/common/http';
import { TodoListEditComponent } from './todo-list/todo-list-edit/todo-list-edit.component';
import { StoreModule } from '@ngrx/store';
import { todoItemReducer } from './todo-list/todo-list/+state/todo-list.reducer';


//primeng
import { PanelModule } from 'primeng/panel';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SplitterModule } from 'primeng/splitter';

@NgModule({
  declarations: [
    AppComponent,
    CurrencyConverterComponent,
    TimeConverterComponent,
    TodoListComponent,
    HeaderComponent,
    FooterComponent,
    ToolsComponent,
    TodoListEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    FormsModule,
    HttpClientModule,
    PanelModule,
    BrowserAnimationsModule,
    SplitterModule,
    StoreModule.forRoot({todoItems: todoItemReducer})
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
