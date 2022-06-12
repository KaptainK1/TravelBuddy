import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TodoListComponent } from './todo-list/todo-list-component/todo-list-component.component';
import { ToolsComponent } from './tools/tools.component';

const routes: Routes = [
  {path: 'todo', component: TodoListComponent},
  {path: 'tools', component: ToolsComponent},
  { path: '**', component: ToolsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
