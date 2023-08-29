import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { TodoItem } from 'src/app/models/todo-item';

@Component({
  selector: 'todo-list-edit-component',
  templateUrl: './todo-list-edit.component.html',
  styleUrls: ['./todo-list-edit.component.css']
})
export class TodoListEditComponent implements OnInit {

  constructor() { }

  @Input() todoItem: TodoItem;
  @Output() isCancelled = new EventEmitter<boolean>();

  ngOnInit(): void {
    console.log(this.todoItem);
  }

  onSave(){
    console.log("in on save");
  }

  onCancel(){
    this.isCancelled.emit(true);
  }

}
