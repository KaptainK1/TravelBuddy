import { Component, OnInit } from '@angular/core';
import { TodoItem } from 'src/app/models/todo-item';
import { TodoListEditComponent } from '../todo-list-edit/todo-list-edit.component';
import { Observable } from 'rxjs';
import { Store } from '@ngrx/store';
import  * as TodoActions from './+state/todo-list.actions';


@Component({
  selector: 'todo-list.component',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {



  public showEdit: boolean = false;
  public selectedItem: TodoItem = null;
  public todoItems$: Observable<TodoItem[]>;

  constructor(
    private store: Store<{todoItems: TodoItem[]}>) { 
      
    }


  ngOnInit(): void {
    this.todoItems$ = this.store.select('todoItems');
  }

  onDelete(index :number){
    this.store.dispatch(TodoActions.deleteItem({index: index}))

  }
  onEdit(item :TodoItem){
    this.selectedItem = item;
    this.showEdit = true;
    console.log(item);
  }

  onCancel(isCancelled: boolean){
    if(isCancelled){
      this.showEdit = false;
    }
  }

}
