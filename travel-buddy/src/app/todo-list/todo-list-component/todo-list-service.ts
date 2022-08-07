import { Injectable } from "@angular/core";
import { TodoItem } from "src/app/models/todo-item";

@Injectable({
    providedIn: 'root',
})
export class ToDoListService {

    todoItems: TodoItem[] = [

        {
            title: "test",
            description:"test description",
            duration: 1,
            isDone: false
        },
        {
            title: "test2",
            description:"test description2",
            duration: 12,
            isDone: false
        },

    ];


    deleteItem(index: number) {
        if(this.todoItems.length >= index -1 && index > -1){
            this.todoItems.splice(index,1);
        }
    }

    addItem(item: TodoItem) {
        if(item){
            this.todoItems.push(item)
        }
    }

    getItem(id: number): TodoItem {
        if(this.todoItems.length >= id -1 && id > -1){
            return this.todoItems[id];
        }
        return null
    }

    editItem(id: number) {
        
    }

}