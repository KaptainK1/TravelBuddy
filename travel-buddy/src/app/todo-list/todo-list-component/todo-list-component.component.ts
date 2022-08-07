import { Component, OnInit } from '@angular/core';
import { ToDoListService } from './todo-list-service';
import { TodoItem } from 'src/app/models/todo-item';

@Component({
  selector: 'app-todo-list-component',
  templateUrl: './todo-list-component.component.html',
  styleUrls: ['./todo-list-component.component.css']
})
export class TodoListComponent implements OnInit {

  constructor(private todoListService: ToDoListService) { }

  ngOnInit(): void {
  }

  getTodoItems(): TodoItem [] {
    return this.todoListService.todoItems;
  }

  onDelete(index :number){
    console.log(index);
    this.todoListService.deleteItem(index)

  }

}
