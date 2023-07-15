import { Component, OnInit } from '@angular/core';
import { ToDoListService } from './todo-list.service';
import { TodoItem } from 'src/app/models/todo-item';
import { TodoListEditComponent } from '../todo-list-edit/todo-list-edit.component';
import { Observable } from 'rxjs';
import { Store } from '@ngrx/store';


@Component({
  selector: 'todo-list.component',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {



  public showEdit: boolean = false;
  public selectedItem: TodoItem = null;
  public todoItems$: Observable<TodoItem[]>;

  constructor(private todoListService: ToDoListService,
    private store: Store<{todoItems: TodoItem[]}>) { 
      this.todoItems$ = store.select('todoItems');
    }


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
