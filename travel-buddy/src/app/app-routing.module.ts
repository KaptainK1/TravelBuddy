import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TodoListComponent } from './todo-list/todo-list/todo-list.component';
import { TodoListEditComponent } from './todo-list/todo-list-edit/todo-list-edit.component';
import { ToolsComponent } from './tools/tools.component';

const routes: Routes = [
  {path: 'todo', component: TodoListComponent},
  {path: 'tools', component: ToolsComponent},
  {path: 'todo/edit/:id', component: TodoListEditComponent},
  { path: '**', component: ToolsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
