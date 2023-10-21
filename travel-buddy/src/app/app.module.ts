import { NgModule, isDevMode } from '@angular/core';
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
import { StoreDevtoolsModule } from '@ngrx/store-devtools';


//primeng
import { PanelModule } from 'primeng/panel';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SplitterModule } from 'primeng/splitter';
import { AccordionModule } from 'primeng/accordion';

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
    AccordionModule,
    StoreModule.forRoot({todoItems: todoItemReducer}),
    StoreDevtoolsModule.instrument({
      maxAge: 25, // Retains last 25 states
      logOnly: !isDevMode(), // Restrict extension to log-only mode
      autoPause: true, // Pauses recording actions and state changes when the extension window is not open
      trace: false, //  If set to true, will include stack trace for every dispatched action, so you can see it in trace tab jumping directly to that part of code
      traceLimit: 75, // maximum stack trace frames to be stored (in case trace option was provided as true)
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
