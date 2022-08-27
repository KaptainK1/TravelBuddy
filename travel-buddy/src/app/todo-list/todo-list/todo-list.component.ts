import { Component, OnInit } from '@angular/core';
import { ToDoListService } from './todo-list.service';
import { TodoItem } from 'src/app/models/todo-item';
import { TodoListEditComponent } from '../todo-list-edit/todo-list-edit.component';

@Component({
  selector: 'todo-list.component',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  constructor(private todoListService: ToDoListService) { }

  public showEdit: boolean = false;
  public selectedItem: TodoItem = null;

  ngOnInit(): void {
  }

  getTodoItems(): TodoItem [] {
    return this.todoListService.todoItems;
  }

  onDelete(index :number){
    console.log(index);
    this.todoListService.deleteItem(index)

  }
  onEdit(item :TodoItem){
    this.selectedItem = item;
    this.showEdit = true;
    console.log(item);
  }
  // onEdit(){
  //   this.showEdit = true;
  // }

}
